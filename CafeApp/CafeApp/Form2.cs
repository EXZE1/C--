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

namespace CafeApp
{
    public partial class Form2 : Form
    {

        string[] menu_headers_contents = { "Başlangıçlar:Günün çorbası,Elma dilim patates,Parmak dilim patates",
            "Sandviçler:Tavuk Lokmalı Sandviç,Baharatlı İtalyan Sandviç",
            "Burgerler:Klasik Burger,Cheese Burger", 
            "Pizzalar:Klasik Pizza,Margaritta",
            "Makarnalar:Sade Makarna,İtalyan Makarna", 
            "Tatlılar:Kemal Paşa,Supangle", 
            "Soğuk İçecekler:Kola,Fanta", 
            "Sıcak İçecekler:Kahve,Çay"};

        


        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");

        private void Form2_Load(object sender, EventArgs e)
        {
            cafeName.Text = Form1.cafe_name;

            for (int i = 0; i < menu_headers_contents.Length; i++)
            {
                Label labelHeader = new Label();
                string[] headers_contents = menu_headers_contents[i].Split(':');
                string header = headers_contents[0];
                string contents = headers_contents[1];

                labelHeader.Text = header;
                labelHeader.Width = 620;
                labelHeader.Font = new Font(labelHeader.Font, FontStyle.Bold);
                labelHeader.BackColor = Color.Bisque;
                menu.Controls.Add(labelHeader);


                string[] contents_array = contents.Split(',');
                for (int j = 0; j < contents_array.Length; j++)
                {
                    Label labelContent = new Label();
                    labelContent.Text = contents_array[j];
                    labelContent.Width = 400;
                    menu.Controls.Add(labelContent);

                    Button button = new Button();
                    button.Text = "Add";
                    
                    menu.Controls.Add(button);
                }
            }
        }

        private void totalValue_Click(object sender, EventArgs e)
        {

        }
        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From orderHistory",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pay_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("insert into orderHistory (tableName,food,price,staff) values(@p1,@p2,@p3,@p4)",baglanti);
            komut1.Parameters.AddWithValue("@p1", textBox1.Text);
            komut1.Parameters.AddWithValue("@p2", textBox2.Text);
            komut1.Parameters.AddWithValue("@p3", textBox3.Text);
            komut1.Parameters.AddWithValue("@p4", textBox4.Text);
            komut1.ExecuteNonQuery();
            listele();
            baglanti.Close();


        }
    }
}
