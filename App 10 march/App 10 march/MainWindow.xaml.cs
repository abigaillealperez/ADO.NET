using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;



namespace App_10_march
{


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connectionStr = "Server=INSTRUCTORIT; Database=IBTCollege; user Id=profileUser; Password=ProfileUser2019";
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                string commandText = String.Format("SELECT * FROM Students");
                SqlCommand cmd = new SqlCommand(commandText, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string fullname = reader["firstname"] + " " + reader["lastName"];
                    listBox.Items.Add(fullname);
                }
                reader.Close();

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string connectionStr = "Server=INSTRUCTORIT; Database=IBTCollege; user Id=profileUser; Pasword=ProfileUser2019";
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                string cmdTextDelete = " DELETE FROM Students WHERE ID=" listBox.Text ";
                SqlCommand cmdDelete = new SqlCommand(cmdTextDelete, conn);
                int rowsAffected = cmdDelete.ExecuteNonQuery();
                
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string connectionStr = "Server=INSTRUCTORIT; Database=IBTCollege; user Id=profileUser; Pasword=ProfileUser2019";
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                string cmdTextUpdate = " UPDATE FROM Students WHERE Id = 1";
                SqlCommand cmdUpdate = new SqlCommand(cmdTextUpdate, conn);
                int rowsAffected = cmdUpdate.ExecuteNonQuery();
                Console.WriteLine("{0} rows affected", rowsAffected.ToString());
            }
        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            string connectionStr = "Server=INSTRUCTORIT; Database=IBTCollege; user Id=profileUser; Pasword=ProfileUser2019";
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                string cmdTextInsert = " INSERT FROM Students WHERE Id = 1";
                SqlCommand cmdInsert = new SqlCommand(cmdTextInsert, conn);
                int rowsAffected = cmdInsert.ExecuteNonQuery();
                Console.WriteLine("{0} rows affected", rowsAffected.ToString());
            }
        }
    }
}
