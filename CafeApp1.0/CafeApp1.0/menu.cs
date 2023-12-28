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
using System.Xml;
using static System.Net.Mime.MediaTypeNames;


namespace CafeApp1._0
{
    public partial class panel2 : Form
    {
        
        public panel2(string tableName)
        {
            InitializeComponent();
            read_data();         
            tableNameLabel.Text = tableName;
            
            listele();
            masalar(tableNameLabel.Text);
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");

        OleDbConnection connectdb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");//kafe bilgileri
        
        OleDbConnection connectdb1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");//menu

       
        OleDbConnection yemekarama = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");//menu

        OleDbConnection baglanti11 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");
        //OleDbCommand sorgu1;

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


            int a = 1;
            int b = 1;

            
            while (reader1.Read())
            {
                //türü food olanları sırayla panele yazdırıyor 

                if ((reader1["türü"].ToString()) == "food")
                {
                    if (a == 1)
                    {
                        //***menu başlığını yazdırıyor
                        a++;
                        Label labelDrink = new Label();
                        labelDrink.Text = "FOOD";
                        labelDrink.Width = 500;
                        labelDrink.Font = new Font("Arial", 14);
                        labelDrink.TextAlign = ContentAlignment.MiddleCenter;

                        labelDrink.Font = new Font(labelDrink.Font, FontStyle.Bold);
                        labelDrink.BackColor = Color.Yellow;
                        menuu.Controls.Add(labelDrink);
                    }
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
                    if(b == 1)
                    {
                        //***menu başlığını yazdırıyor
                        b++;
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
            connectdb1.Close();
        }
        



        private void menu_Load(object sender, EventArgs e)
        {
            //****************************************************************
            
        }
        public void listele()
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From orderHistory", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }
        int deger;
        
        public void arama(string btnName,ref int deger) // btnName = yemek adı ,deger = yemeğin fiyatıdır menu veri tabanından yemek adından bulup fiyatını degere kaydediyor
        {
            yemekarama.Open();
           
            OleDbCommand yemekarama1 = new OleDbCommand();
            yemekarama1.Connection = yemekarama;
            yemekarama1.CommandText = ("Select * from MENU");
            OleDbDataReader oku1 = yemekarama1.ExecuteReader();
            while (oku1.Read())
            {
                if ((oku1["içerik"].ToString()) == btnName)
                {
                    deger = Convert.ToInt32(oku1["price"]);
                    
                }
            }
            yemekarama.Close();
        }

        int kasa;
        string k;
        

        public void masalar(string tableName)//sipariş geçmişi
        {
            string masaNumarası = tableName;
            baglanti.Open();
            OleDbCommand siparişler = new OleDbCommand();
            siparişler.Connection = baglanti;
            siparişler.CommandText = ("Select * from orderHistory");
            OleDbDataReader siparişleroku = siparişler.ExecuteReader();
            while (siparişleroku.Read())
            {
                if ((siparişleroku["tableName"].ToString()) == masaNumarası)
                {
                    //sipariş edilen yemek adı
                    Label labelsiparis = new Label();
                    labelsiparis.Text = siparişleroku["food"].ToString();
                    labelsiparis.Width = 180;
                    labelsiparis.Font = new Font(labelsiparis.Font, FontStyle.Bold);
                    labelsiparis.BackColor = Color.Bisque;
                    flowLayoutPanel1.Controls.Add(labelsiparis);
                    //*****sipariş edilen yemek fiyatı
                    Label labelsiparisprice = new Label();
                    labelsiparisprice.Text = siparişleroku["price"].ToString();
                    k = siparişleroku["price"].ToString();//kasa**********************************************************kasa
                    kasa = kasa + int.Parse(k);//kasa
                    label4.Text = kasa.ToString();//kasa
                    labelsiparisprice.Width = 30;
                    labelsiparisprice.Font = new Font(labelsiparisprice.Font, FontStyle.Bold);
                    labelsiparisprice.BackColor = Color.Green;
                    flowLayoutPanel1.Controls.Add(labelsiparisprice);
                    //**** sipariş edilen yemek tl 
                    Label labelsiparisTl = new Label();
                    labelsiparisTl.Text = "TL";
                    labelsiparisTl.Width = 30;
                    labelsiparisTl.Font = new Font(labelsiparisTl.Font, FontStyle.Bold);
                    flowLayoutPanel1.Controls.Add(labelsiparisTl);
                    //buton clear
                    Button buttonclear = new Button();
                    buttonclear.Text = "-";
                    buttonclear.Margin = new Padding(0, 0, 2, 2);
                    buttonclear.Name = siparişleroku["food"].ToString();
                    buttonclear.Click += new System.EventHandler(this.buttonclear_Click); // her buton için aynı işlevi vermemizi sağlıyor..
                    flowLayoutPanel1.Controls.Add((Button)buttonclear);
                }
            }
        }
        
        public void Btn_Click(object sender, EventArgs e)//her buton için aynı işlem 
        {
            // ilk baştan sipariş geçmişi veri tabanına eklicez ondan sonra eklediklerimizi 
            Button btn = (Button)sender;
            flowLayoutPanel1.Controls.Clear();
            kasa = 0;
            arama(btn.Name,ref deger);
            MessageBox.Show(tableNameLabel.Text.ToString());
            baglanti.Close();
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("insert into orderHistory (tableName,food,price,staff) values(@p1,@p2,@p3,@p4)", baglanti);
            komut1.Parameters.AddWithValue("@p1", tableNameLabel.Text);
            komut1.Parameters.AddWithValue("@p2", btn.Name);
            komut1.Parameters.AddWithValue("@p3", deger);
            komut1.Parameters.AddWithValue("@p4", comboBox1.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            masalar(tableNameLabel.Text);
            
        }
        public void buttonclear_Click(object sender, EventArgs e)
        {
            Button cleardButton = (Button)sender;
            flowLayoutPanel1.Controls.Clear();
            kasa = 0;
            MessageBox.Show(cleardButton.Name);
            clearfonk(cleardButton.Name,tableNameLabel.Text);

        }
        public void clearfonk(string buttonclear, string tableName1)
        {
            string masaNumarası = tableName1;
            
            
            OleDbCommand siparişler0 = new OleDbCommand();
            siparişler0.Connection = baglanti;
            siparişler0.CommandText = ("Select * from orderHistory");
            OleDbDataReader siparişleroku0 = siparişler0.ExecuteReader();
            while (siparişleroku0.Read())
            {
                if ((siparişleroku0["tableName"].ToString()) == masaNumarası)
                {
                    OleDbCommand clear = new OleDbCommand("delete from orderHistory where food=@p1", baglanti);
                    clear.Parameters.AddWithValue("@p1", buttonclear);
                }
            }
            baglanti.Close();
            masalar(tableNameLabel.Text);




            //    string sorgu = "Delete From orderHistory Where Numara=@no";
            //sorgu1 = new OleDbCommand(sorgu, baglanti);
            //baglanti.Open();



            //flowLayoutPanel1.Controls.Clear();
            //kasa = 0;
            //baglanti.Close();
            //baglanti.Open();
            //OleDbCommand siparişler11 = new OleDbCommand();
            //siparişler11.Connection = baglanti;
            //siparişler11.CommandText = ("Select * from orderHistory");
            //OleDbDataReader siparişleroku11 = siparişler11.ExecuteReader();
            //while (siparişleroku11.Read())
            //{
            //    if (siparişleroku11["tableName"].ToString() == tableNameLabel.Text)
            //    {

            //        OleDbCommand clear = new OleDbCommand("delete from orderHistory where food=@a1", baglanti11);
            //        clear.Parameters.AddWithValue("@a1", buttonclear);
            //    }
            //}
            //baglanti.Close();
            // masalar(tableNameLabel.Text);

            //baglanti.Open();
            //OleDbCommand clear = new OleDbCommand("delete from orderHistory where food=@a1", baglanti11);
            //clear.Parameters.AddWithValue("@a1", buttonclear);
            //clear.ExecuteNonQuery();
            //baglanti11.Close();
            //masalar(tableNameLabel.Text);
            //OleDbCommand verisil = new OleDbCommand("delete from Access_uygulamalar where Sıra_No = " + buttonclear. + "", baglanti11);

            //verisil.ExecuteNonQuery();
            //baglanti.Close();



            //baglanti.Open();
            //OleDbCommand siparişler11 = new OleDbCommand();
            //siparişler11.Connection = baglanti;
            //siparişler11.CommandText = ("Select * from orderHistory");
            //OleDbDataReader siparişleroku11 = siparişler11.ExecuteReader();
            //while (siparişleroku11.Read())
            //{
            //    if (siparişleroku11["tableName"].ToString() == tableNameLabel.Text)
            //    {
            //        OleDbCommand clear = new OleDbCommand("delete from orderHistory where food=@a1", baglanti11);
            //        clear.Parameters.AddWithValue("@a1", buttonclear);
            //    }
            //}
            //    //if (tableNameLabel.Text== siparişleroku11["tableName"].ToString())
            //    //{

            //OleDbCommand clear = new OleDbCommand("delete from orderHistory where food=@a1", baglanti11);
            //clear.Parameters.AddWithValue("@a1", buttonclear);
            //clear.ExecuteNonQuery();
            //baglanti11.Close();


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
            MessageBox.Show("a");
            Form1 form = new Form1();
            this.Hide();
            form.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BUTTON_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(kasa.ToString());
        }

        
    }
}
