using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace myScheduler
{
    public partial class Form1 : Form
    {
        static string connectionString = "server=localhost;user=guest;database=myscheduler;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        string selectq = "SELECT task_name,pk FROM mytask WHERE due_date=@date AND status=0 ORDER BY priority DESC;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = selectq;
            command.Parameters.Add("@date", MySqlDbType.Date);
            command.Parameters[0].Value = mainCalender.SelectionRange.Start.ToString("yyyy-MM-dd");

            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(ds);


            if(ds.Tables.Count > 0)
            {
                foreach(DataRow r in ds.Tables[0].Rows)
                {
                    toDoBox.Items.Add(r["pk"]+".\t"+r["task_name"]);
                }
            }
            
            connection.Close();
        }


        private void newToDo_Click(object sender, EventArgs e)
        {
            insertTodo myTask = new insertTodo();
            myTask.ShowDialog();
        }

      
    }
}
