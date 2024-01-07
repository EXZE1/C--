using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApp1._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection connectdb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");
        //burdayımmmm
        private void button1_Click(object sender, EventArgs e)
        {
            connectdb.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connectdb;
            command.CommandText = ("Select * from login");
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["kullanıcıadi"].ToString() == textBox1.Text)
                {
                    if(reader["sifre"].ToString()==textBox2.Text)
                    {
                        giris giris = new giris();
                        giris.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("şifre  yanlış..");

                    }

                }
                else
                {
                    MessageBox.Show("kullanıcı adı yanlış..");
                }

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }
    }
}
