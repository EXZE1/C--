using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CafeApp1._0
{
    public partial class Form1 : Form
    {
        int number_of_tables;
        public static string cafe_name ;
        public Form1()
        {
            InitializeComponent();
            read_data();
        }
        OleDbConnection connectdb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");


        public void read_data()
        {
            connectdb.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connectdb;
            command.CommandText = ("Select * from cafebilgileri");
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["value"].ToString() == "cafename")
                {
                    cafe_name = reader["key"].ToString();
                }
                else if (reader["value"].ToString() == "numberoftables")
                {
                    number_of_tables = Int32.Parse(reader["key"].ToString());
                }
            }
            connectdb.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cafeName.Text = cafe_name;

            for (int i = 1; i <= number_of_tables; i++)
            {
                Button btn = new Button();
                btn.Name = i.ToString() + ". Masa";
                btn.Font = new Font("Times New Roman", 13);
                btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffe700");
                btn.Text = " MASA "+i.ToString();
                btn.Width = 170;
                btn.Height = 80;
                btn.Click += Btn_Click; //anlamadım 
                flowLayoutPanel1.Controls.Add(btn);
            }
        }


        public void Btn_Click(object sender, EventArgs e)
        {
            //Button btn = sender as Button;
            Button btn = (Button)sender; // anlamadım 
            panel2 menu = new panel2(btn.Name);
            menu.Show();
            Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
