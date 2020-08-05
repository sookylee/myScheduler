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
    public partial class insertTodo : Form
    {
        public insertTodo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            var connectionString = "server=localhost;user=guest;database=myscheduler;";
            var connection = new MySqlConnection(connectionString);

            connection.Open();
            string insertq = "INSERT INTO mytask(task_name, priority, due_date) VALUES('";
            insertq += Taskname.Text + "'," + Priority.Value + ",'" + Calender.SelectionStart.ToString("yyyy-MM-dd") + "');";

            try
            {
                MySqlCommand command = new MySqlCommand(insertq, connection);
            }
            catch(Exception ex)
            {
                MessageBox.Show("mysql insert error!\nPlease retry.","System");
            }
            connection.Close();
            this.Close();
        }
    }
}
