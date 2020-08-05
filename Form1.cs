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
        static string connectionString = "server=localhost;user=guest;database=myscheduler;charset=utf8";
        MySqlConnection connection;

        string selectq = "SELECT task_name,pk,priority FROM mytask WHERE due_date=@date AND status=0 ORDER BY priority DESC;";
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            update_todobox();
        }


        private void newToDo_Click(object sender, EventArgs e)
        {
            insertTodo myTask = new insertTodo();
            myTask.ShowDialog();
            toDoBox.Items.Clear();
            update_todobox();
        }

        private void update_todobox()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = selectq;
            command.Parameters.Add("@date", MySqlDbType.Date);
            command.Parameters[0].Value = mainCalender.SelectionRange.Start.ToString("yyyy-MM-dd");

            MySqlDataReader rd = command.ExecuteReader();

            while (rd.Read())
            {
                toDoBox.Items.Add(rd["pk"] + ".\t" + rd["task_name"]);
            }

            rd.Close();
            connection.Close();
        }

        private void mainCalender_DateSelected(object sender, DateRangeEventArgs e)
        {
            toDoBox.Items.Clear();
            update_todobox();
        }

        private void toDoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem li in toDoBox.Items)
            {
                if (li.Font.Style == FontStyle.Strikeout && !li.Selected)
                {
                    li.Font = new Font("굴림", 9);
                }
                else if (li.Selected)
                {
                    li.Font = new Font("굴림", 9, FontStyle.Strikeout);
                }
            }
        }
    }
}
