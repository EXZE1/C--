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
        
        public panel2(string tableName,string personel)
        {
            InitializeComponent();
            read_data();         
            tableNameLabel.Text = tableName;
            label5.Text = personel;
            //listele();
            masalar(tableNameLabel.Text);
            //personelfonk();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");

        OleDbConnection connectdb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");//kafe bilgileri
        
        OleDbConnection connectdb1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");//menu

       
        OleDbConnection yiyecekarama = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");//menu

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
                //türü yiyecek olanları sırayla panele yazdırıyor 

                if ((reader1["türü"].ToString()) == "yiyecek")
                {
                    if (a == 1)
                    {
                        //***menu başlığını yazdırıyor
                        a++;
                        Label labeliçecek = new Label();
                        labeliçecek.Text = "yiyecekler";
                        labeliçecek.Width = 500;
                        labeliçecek.Font = new Font("Arial", 14);
                        labeliçecek.TextAlign = ContentAlignment.MiddleCenter;

                        labeliçecek.Font = new Font(labeliçecek.Font, FontStyle.Bold);
                        labeliçecek.BackColor = Color.Yellow;
                        menuu.Controls.Add(labeliçecek);
                    }
                    //yiyecek adını yazdırıyor 
                    Label labelyiyecek = new Label();
                    labelyiyecek.Text = reader1["içerik"].ToString();
                    labelyiyecek.Width = 300;
                    labelyiyecek.Font = new Font(labelyiyecek.Font, FontStyle.Bold);
                    labelyiyecek.BackColor = Color.Bisque;
                    menuu.Controls.Add(labelyiyecek);
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

                else if((reader1["türü"].ToString()) == "içecek")
                {
                    if(b == 1)
                    {
                        //***menu başlığını yazdırıyor
                        b++;
                        Label labeliçecek1 = new Label();
                        labeliçecek1.Text = "içecekler";
                        labeliçecek1.Width = 500;
                        labeliçecek1.Font = new Font("Arial", 14);
                        labeliçecek1.TextAlign = ContentAlignment.MiddleCenter;
                        
                        labeliçecek1.Font = new Font(labeliçecek1.Font, FontStyle.Bold);
                        labeliçecek1.BackColor = Color.Yellow;
                        menuu.Controls.Add(labeliçecek1);
                    }
                    //***içecek adını yazdırıyor
                    Label labeliçecek= new Label();
                    labeliçecek.Text = reader1["içerik"].ToString();
                    labeliçecek.Width = 300;
                    labeliçecek.Font = new Font(labeliçecek.Font, FontStyle.Bold);
                    labeliçecek.BackColor = Color.Bisque;
                    menuu.Controls.Add(labeliçecek);
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
                    labelTl.Font = new Font(labeliçecek.Font, FontStyle.Bold);
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
        //public void listele()
        //{
        //    baglanti.Open();
        //    DataTable dt = new DataTable();
        //    OleDbDataAdapter da = new OleDbDataAdapter("Select * From Siparis_Gecmisi", baglanti);
        //    da.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //    baglanti.Close();

        //}
        int deger;
        
        public void arama(string btnName,ref int deger) // btnName = yiyecek adı ,deger = yemeğin fiyatıdır menu veri tabanından yiyecek adından bulup fiyatını degere kaydediyor
        {
            yiyecekarama.Open();
           
            OleDbCommand yiyecekarama1 = new OleDbCommand();
            yiyecekarama1.Connection = yiyecekarama;
            yiyecekarama1.CommandText = ("Select * from MENU");
            OleDbDataReader oku1 = yiyecekarama1.ExecuteReader();
            while (oku1.Read())
            {
                if ((oku1["içerik"].ToString()) == btnName)
                {
                    deger = Convert.ToInt32(oku1["price"]);
                    
                }
            }
            yiyecekarama.Close();
        }
        int anakasa;
        int kasa;
        string k;
        

        public void masalar(string tableName)//sipariş geçmişi
        {
            kasa = 0;
            string masaNumarası = tableName;
            baglanti.Open();
            OleDbCommand siparişler = new OleDbCommand();
            siparişler.Connection = baglanti;
            siparişler.CommandText = ("Select * from Siparis_Gecmisi");
            OleDbDataReader siparişleroku = siparişler.ExecuteReader();
            while (siparişleroku.Read())
            {
                if ((siparişleroku["tableName"].ToString()) == masaNumarası)
                {
                    //sipariş edilen yiyecek adı
                    Label labelsiparis = new Label();
                    labelsiparis.Text = siparişleroku["yiyecek"].ToString();
                    labelsiparis.Width = 180;
                    labelsiparis.Font = new Font(labelsiparis.Font, FontStyle.Bold);
                    labelsiparis.BackColor = Color.Bisque;
                    flowLayoutPanel1.Controls.Add(labelsiparis);
                    //*****sipariş edilen yiyecek fiyatı
                    Label labelsiparisprice = new Label();
                    labelsiparisprice.Text = siparişleroku["price"].ToString();
                    k = siparişleroku["price"].ToString();//kasa**********************************************************kasa
                    kasa = kasa + int.Parse(k) + 0;//kasa
                    anakasa = anakasa + kasa;                   
                    labelsiparisprice.Width = 50;
                    labelsiparisprice.Font = new Font(labelsiparisprice.Font, FontStyle.Bold);
                    labelsiparisprice.BackColor = Color.Green;
                    flowLayoutPanel1.Controls.Add(labelsiparisprice);
                    //**** sipariş edilen yiyecek tl 
                    Label labelsiparisTl = new Label();
                    labelsiparisTl.Text = "TL";
                    labelsiparisTl.Width = 30;
                    labelsiparisTl.Font = new Font(labelsiparisTl.Font, FontStyle.Bold);
                    flowLayoutPanel1.Controls.Add(labelsiparisTl);
                    //buton clear
                    Button buttonclear = new Button();
                    buttonclear.Text = "-";
                    buttonclear.Margin = new Padding(0, 0, 2, 2);
                    buttonclear.Name = siparişleroku["yiyecek"].ToString();
                    buttonclear.Click += new System.EventHandler(this.buttonclear_Click); // her buton için aynı işlevi vermemizi sağlıyor..
                    flowLayoutPanel1.Controls.Add((Button)buttonclear);
                    
                }
            }
            label4.Text = kasa.ToString();//kasa
        }
        
        public void Btn_Click(object sender, EventArgs e)//her buton için aynı işlem 
        {
            // ilk baştan sipariş geçmişi veri tabanına eklicez ondan sonra eklediklerimizi 
            Button btn = (Button)sender;
            flowLayoutPanel1.Controls.Clear();
            kasa = 0;
            arama(btn.Name,ref deger);
            MessageBox.Show(tableNameLabel.Text.ToString()+" "+"ekleniyor");
            baglanti.Close();
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("insert into Siparis_Gecmisi (tableName,yiyecek,price,staff,sıfırlama) values(@p1,@p2,@p3,@p4,p5)", baglanti);
            komut1.Parameters.AddWithValue("@p1", tableNameLabel.Text);
            komut1.Parameters.AddWithValue("@p2", btn.Name);
            komut1.Parameters.AddWithValue("@p3", deger);
            komut1.Parameters.AddWithValue("@p4", label5.Text);
            komut1.Parameters.AddWithValue("@p5", "s");
            komut1.ExecuteNonQuery();
            baglanti.Close();
            //buraya siparişler tablosuna ekle 
            baglanti.Open();
            OleDbCommand siparisler = new OleDbCommand("insert into siparisler (masaAdi,yiyecekVEicecek,fiyati,personel) values(@p1,@p2,@p3,@p4)", baglanti);
            siparisler.Parameters.AddWithValue("@p1", tableNameLabel.Text);
            siparisler.Parameters.AddWithValue("@p2", btn.Name);
            siparisler.Parameters.AddWithValue("@p3", deger);
            siparisler.Parameters.AddWithValue("@p4", label5.Text); /*label5.Text*/
            siparisler.ExecuteNonQuery();
            baglanti.Close();
            masalar(tableNameLabel.Text);
            anakasa = kasa;

        }
        public void buttonclear_Click(object sender, EventArgs e)
        {
            Button cleardButton = (Button)sender;
            flowLayoutPanel1.Controls.Clear();
            kasa = 0;
            MessageBox.Show(cleardButton.Name+" "+" siliniyor");
            clearfonk(cleardButton.Name,tableNameLabel.Text);

        }
        public void clearfonk(string buttonclear, string tableName1)
        {
            string masaNumarası = tableName1;
            baglanti.Close();
            baglanti.Open();
            OleDbCommand silinecekara = new OleDbCommand();
            silinecekara.Connection = baglanti;
            silinecekara.CommandText = ("Select * from Siparis_Gecmisi");
            OleDbDataReader silinecekara1 = silinecekara.ExecuteReader();
            OleDbCommand clear = new OleDbCommand("delete from Siparis_Gecmisi where yiyecek=@p1", baglanti);
            while (silinecekara1.Read())
            {
                if ((silinecekara1["tableName"].ToString()) == masaNumarası)
                {
                    if(silinecekara1["yiyecek"].ToString() == buttonclear)
                    {
                        //anakasa = anakasa +  kasa;
                        //anakasa = anakasa + int.Parse(silinecekara1["price"].ToString());
                        clear.Parameters.AddWithValue("@p1", buttonclear);
                        break;
                    } 
                }

            }
            
            clear.ExecuteNonQuery();
            baglanti.Close();
            masalar(tableNameLabel.Text);

            //***********************************************************

            //while (siparişleroku0.Read())
            //{
            //    string a = siparişleroku0["yiyecek"].ToString();
            //    string b = buttonclear.ToString();
            //    if ((siparişleroku0["yiyecek"].ToString()) == buttonclear)
            //    {
            //        OleDbCommand clear = new OleDbCommand("delete from Siparis_Gecmisi where yiyecek=@p1", baglanti);
            //        clear.Parameters.AddWithValue("@p1", buttonclear);
            //    }
            //}

            //    string sorgu = "Delete From Siparis_Gecmisi Where Numara=@no";
            //sorgu1 = new OleDbCommand(sorgu, baglanti);
            //baglanti.Open();



            //flowLayoutPanel1.Controls.Clear();
            //kasa = 0;
            //baglanti.Close();
            //baglanti.Open();
            //OleDbCommand siparişler11 = new OleDbCommand();
            //siparişler11.Connection = baglanti;
            //siparişler11.CommandText = ("Select * from Siparis_Gecmisi");
            //OleDbDataReader siparişleroku11 = siparişler11.ExecuteReader();
            //while (siparişleroku11.Read())
            //{
            //    if (siparişleroku11["tableName"].ToString() == tableNameLabel.Text)
            //    {

            //        OleDbCommand clear = new OleDbCommand("delete from Siparis_Gecmisi where yiyecek=@a1", baglanti11);
            //        clear.Parameters.AddWithValue("@a1", buttonclear);
            //    }
            //}
            //baglanti.Close();
            // masalar(tableNameLabel.Text);

            //baglanti.Open();
            //OleDbCommand clear = new OleDbCommand("delete from Siparis_Gecmisi where yiyecek=@a1", baglanti11);
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
            //siparişler11.CommandText = ("Select * from Siparis_Gecmisi");
            //OleDbDataReader siparişleroku11 = siparişler11.ExecuteReader();
            //while (siparişleroku11.Read())
            //{
            //    if (siparişleroku11["tableName"].ToString() == tableNameLabel.Text)
            //    {
            //        OleDbCommand clear = new OleDbCommand("delete from Siparis_Gecmisi where yiyecek=@a1", baglanti11);
            //        clear.Parameters.AddWithValue("@a1", buttonclear);
            //    }
            //}
            //    //if (tableNameLabel.Text== siparişleroku11["tableName"].ToString())
            //    //{

            //OleDbCommand clear = new OleDbCommand("delete from Siparis_Gecmisi where yiyecek=@a1", baglanti11);
            //clear.Parameters.AddWithValue("@a1", buttonclear);
            //clear.ExecuteNonQuery();
            //baglanti11.Close();


        }
        //public void personelfonk()
        //{
        //    baglanti.Close(); 
        //    baglanti.Open();
        //    OleDbCommand per = new OleDbCommand();
        //    per.Connection = baglanti;
        //    per.CommandText = ("Select * from personeller");
        //    OleDbDataReader peroku = per.ExecuteReader();   
        //    while (peroku.Read())
        //    {
        //        string p = peroku["personelAdi"].ToString();
        //        comboBox1.Items.Add(p);
        //    }

        //}

        public void hesabıKapa(string tableName2)
        {
            string masaNumarası1 = tableName2;
            baglanti.Close();
            baglanti.Open();
            OleDbCommand hesapsil = new OleDbCommand();
            hesapsil.Connection = baglanti;
            hesapsil.CommandText = ("Select * from Siparis_Gecmisi");
            OleDbDataReader hesapsilreader = hesapsil.ExecuteReader();
            OleDbCommand hesapclear = new OleDbCommand("delete from Siparis_Gecmisi where tableName=@p1", baglanti);
            while (hesapsilreader.Read())
            {
                if (hesapsilreader["tableName"].ToString() == masaNumarası1)
                {
                    hesapclear.Parameters.AddWithValue("@p1", masaNumarası1);
                }

            }

            hesapclear.ExecuteNonQuery();
            baglanti.Close();
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

    
        //MessageBox.Show("a");
        //Form1 form = new Form1();
        //this.Hide();
        //form.Show();


       
        
       

        private void button1_Click(object sender, EventArgs e)//geri tuşu
        {
            
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void BUTTON_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(kasa.ToString()+" ödendi ve ana kasaya eklendi");
            //anakasa = anakasa + kasa;
            hesabıKapa(tableNameLabel.Text);
            flowLayoutPanel1.Controls.Clear();
            kasa = 0;
            masalar(tableNameLabel.Text);
            MessageBox.Show(anakasa.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); 
            this.Hide();
        }
    }
}
