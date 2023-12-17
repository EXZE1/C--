using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CafeApp1._0
{
    public partial class menu : Form
    {
        
        public menu(string tableName)
        {
            InitializeComponent();
            read_data();
            orderhistory();
            tableNameLabel.Text = tableName;
        }
        OleDbConnection connectdb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");
        int i;
        OleDbConnection connectdb1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");

        OleDbConnection connectdb2 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");
        DataSet dataSet = new DataSet();
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
                    cafeName.Text = reader["key"].ToString();
                }
                
            }
            connectdb1.Open();
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connectdb;
            command1.CommandText = ("Select * from MENU");
            OleDbDataReader reader1 = command1.ExecuteReader();

            //string[] menu_headers_contents = { "Başlangıçlar:Günün çorbası,Elma dilim patates,Parmak dilim patates",
            //"Sandviçler:Tavuk Lokmalı Sandviç,Baharatlı İtalyan Sandviç",
            //"Burgerler:Klasik Burger,Cheese Burger",
            //"Pizzalar:Klasik Pizza,Margaritta",
            //"Makarnalar:Sade Makarna,İtalyan Makarna",
            //"Tatlılar:Kemal Paşa,Supangle",
            //"Soğuk İçecekler:Kola,Fanta",
            //"Sıcak İçecekler:Kahve,Çay"};


            //for (int i = 0; i < menu_headers_contents.Length; i++)
            //{
            //    Label labelHeader = new Label();
            //    string[] headers_contents = menu_headers_contents[i].Split(':');
            //    string header = headers_contents[0];
            //    string contents = headers_contents[1];

            //    labelHeader.Text = header;
            //    labelHeader.Width = 620;
            //    labelHeader.Font = new Font(labelHeader.Font, FontStyle.Bold);
            //    labelHeader.BackColor = Color.Bisque;
            //    menuu.Controls.Add(labelHeader);


            //    string[] contents_array = contents.Split(',');
            //    for (int j = 0; j < contents_array.Length; j++)
            //    {
            //        Label labelContent = new Label();
            //        labelContent.Text = contents_array[j];
            //        labelContent.Width = 400;
            //        menuu.Controls.Add(labelContent);

            //        Button button = new Button();
            //        button.Text = "Add";

            //        menuu.Controls.Add(button);
            //    }
            //}

            int a = 1;
            int sayac = 0;

            
            while (reader1.Read())
            {
                //türü food olanları sırayla panele yazdırıyor 

                if ((reader1["türü"].ToString()) == "food")
                {
                    //yemek adını yazdırıyor 
                    Label labelfood = new Label();
                    labelfood.Text = reader1["içerik"].ToString();
                    labelfood.Width = 300;
                    labelfood.Font = new Font(labelfood.Font, FontStyle.Bold);
                    labelfood.BackColor = Color.Bisque;
                    menuu.Controls.Add(labelfood);
                    //****fiyat
                    Label labelprice = new Label();
                    labelprice.Text = reader1["price"].ToString();
                    labelprice.Width = 50;
                    labelprice.Font = new Font(labelprice.Font, FontStyle.Bold);
                    labelprice.BackColor = Color.Green;
                    menuu.Controls.Add(labelprice);
                    //***tl yazdırıyor 
                    Label labelTL = new Label();
                    labelTL.Text = "TL";
                    labelTL.Width = 50;
                    labelTL.Font = new Font(labelTL.Font, FontStyle.Bold);              
                    menuu.Controls.Add(labelTL);
                    //buton 
                    Button button = new Button();//(Button)sender;
                    button.Text = "Add";
                    button.Margin = new Padding(0, 0, 2, 2); 
                    button.Name = reader1["içerik"].ToString();
                    button.Click += new System.EventHandler(this.Btn_Click);
                    menuu.Controls.Add((Button)button);

                }

                //türü içecek olanları sırayla panele yazdırıyor 

                else if((reader1["türü"].ToString()) == "drink")
                {
                    if(a == 1)
                    {
                        //***menu başlığını yazdırıyor
                        a++;
                        Label labelDrink = new Label();
                        labelDrink.Text = "DRİNK";
                        labelDrink.Width = 500;
                        labelDrink.Font = new Font("Arial", 14);
                        labelDrink.TextAlign = ContentAlignment.MiddleCenter;
                        
                        labelDrink.Font = new Font(labelDrink.Font, FontStyle.Bold);
                        labelDrink.BackColor = Color.Yellow;
                        menuu.Controls.Add(labelDrink);
                    }
                    //***içecek adını yazdırıyor
                    Label labeldrink= new Label();
                    labeldrink.Text = reader1["içerik"].ToString();
                    labeldrink.Width = 300;
                    labeldrink.Font = new Font(labeldrink.Font, FontStyle.Bold);
                    labeldrink.BackColor = Color.Bisque;
                    menuu.Controls.Add(labeldrink);
                    //***fiyatı yazdırıyor
                    Label labelprice = new Label();
                    labelprice.Text = reader1["price"].ToString();
                    labelprice.Width = 50;
                    labelprice.Font = new Font(labelprice.Font, FontStyle.Bold);
                    labelprice.BackColor = Color.Green;
                    menuu.Controls.Add(labelprice);
                    //***tl yazdırıyor 
                    Label labelTl = new Label();
                    labelTl.Text = "TL";
                    labelTl.Width = 50;
                    labelTl.Font = new Font(labeldrink.Font, FontStyle.Bold);
                    menuu.Controls.Add (labelTl);

                    //***buton 
                    Button button = new Button();
                    button.Text = "Add";
                    button.Margin = new Padding(0, 0, 2, 2);
                    button.Name = reader1["içerik"].ToString();
                    button.Click += new System.EventHandler(this.Btn_Click); // her buton için aynı işlevi vermemizi sağlıyor..
                    menuu.Controls.Add((Button)button);
                }

            }


            connectdb.Close();

        }
        public void orderhistory()
        {
           
           
            
            
            

            
            
            
        }

        

        private void menu_Load(object sender, EventArgs e)
        {
            //****************************************************************
            connectdb2.Open();
            OleDbDataAdapter Da = new OleDbDataAdapter("Select * from orderHistory", connectdb2);
            DataTable Dt = new DataTable();
            Da.Fill(dataSet, "orderHistory");
            dataGridView1.DataSource = dataSet.Tables["orderHistory"];
            Da.Dispose();

            // orderhistory();
            connectdb2.Close();
        }

        public void Btn_Click(object sender, EventArgs e)//her buton için aynı işlem 
        {
            // ilk baştan sipariş geçmişi veri tabanına eklicez ondan sonra eklediklerimizi 
            Button btn = (Button)sender;
            
           
            MessageBox.Show(btn.Name);
            


        }  

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//Provider=Microsoft.ACE.OLEDB.12.0;Data Source="C:\Users\oguzhan yucedag\Desktop\cafe.accdb"

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void button_Click(object sender, EventArgs e)
        {

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("merhaba");
            
        }
    }
}
