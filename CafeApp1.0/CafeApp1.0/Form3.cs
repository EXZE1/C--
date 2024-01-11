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
    public partial class Form3 : Form
    {
        public Form3(string masaname)
        {

            InitializeComponent();
            Name = masaname;
            MessageBox.Show(Name);
        }

       

       

        OleDbConnection connectdb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");

        

        private void button2_Click(object sender, EventArgs e)
        {
            masalarıAC();
        }
        public void masalarıAC()
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
        string personel;
        public void giris(string masaadi,ref string personel)
        {
            connectdb.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connectdb;
            command.CommandText = ("Select * from personeller");
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["personelAdi"].ToString() == textBox1.Text)
                {
                    personel = reader["personelAdi"].ToString();
                    if (reader["personelSifresi"].ToString() == textBox2.Text)
                    {
                        panel2 menu = new panel2(masaadi,personel);
                        menu.Show();
                        this.Hide();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("personel adı yada şifre  yanlış..");

                    }

                }
                

            }
            connectdb.Close();
        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            giris(Name, ref personel);
        }
    }
}
