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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeApp1._0
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
            read_data();
        }
        OleDbConnection connectdb999 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");
        private void giris_Load(object sender, EventArgs e) 
        {

        }
        public void read_data()
        {
            connectdb999.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connectdb999;
            command.CommandText = ("Select * from cafebilgileri");
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["value"].ToString() == "cafename")
                {
                    label5.Text = reader["key"].ToString();
                }
                else if (reader["value"].ToString() == "numberoftables")
                {
                    label3.Text = reader["key"].ToString();
                }
            }
            connectdb999.Close();
        }
        //public void kafemasaSayisiDegistirme()
        //{
        //    try
        //    {
        //        connectdb999.Open();
        //        OleDbCommand KAFEadi = new OleDbCommand("update cafebilgileri set key=@p1,value=@p2 where id=@p3", connectdb999);
        //        KAFEadi.Parameters.AddWithValue("@p3", 2);
        //        KAFEadi.Parameters.AddWithValue("@p1", textBox1.Text);
        //        KAFEadi.Parameters.AddWithValue("@p2", "numberoftables");
        //        KAFEadi.ExecuteNonQuery();
        //        connectdb999.Close();
        //    }
        //    catch (ArgumentNullException)
        //    {
        //        MessageBox.Show("Değer girmediniz.");

        //    }
        //    catch (FormatException)
        //    {
        //        MessageBox.Show( "Hatalı türde veri girdiniz.");
        //    }
        //    catch (OverflowException)
        //    {
        //        MessageBox.Show("Girdiğiniz değer çok büyük.");
        //    }
        //    MessageBox.Show("çalıştı.");
        //    //cmd = new OleDbCommand();
        //    //connectdb.Open();
        //    //cmd.Connection = connectdb;
        //    //cmd.CommandText = "update cafebilgileri set  (key) values ('" + textBox1.Text + "')";
        //    //cmd.ExecuteNonQuery();
        //    //connectdb.Close();



        //}

     
       
        //*************BURDA KALDIM*********
        private void button1_Click(object sender, EventArgs e)//masa sayısı değiştirme 
        {
            connectdb999.Open();
            OleDbCommand KAFEmasaAdedi = new OleDbCommand();
            KAFEmasaAdedi.Connection = connectdb999;//******************************* BURDA KALDIMMMMMMMMMMMMMMMMM***************

            // Sorguyu parametrelerle oluştur
            KAFEmasaAdedi.CommandText = "UPDATE cafebilgileri SET [key]=@p1 WHERE [value]=@p2";
            KAFEmasaAdedi.Parameters.AddWithValue("@p1", textBox1.Text);
            KAFEmasaAdedi.Parameters.AddWithValue("@p2", "numberoftables");

            // Komutu çalıştır
            KAFEmasaAdedi.ExecuteNonQuery();

            connectdb999.Close();
            MessageBox.Show("masa sayısı değişti..");
            //connectdb.Open();
            //OleDbCommand command1 = new OleDbCommand();
            //command1.Connection = connectdb;
            //command1.CommandText = ("Select * from cafebilgileri");
            //OleDbDataReader reader1 = command1.ExecuteReader();
            //while (reader1.Read())
            //{
            //    if (reader1["value"].ToString() == "cafename")
            //    {
            //        string kafeadi = reader1["key"].ToString();
            //    }
            //    else if (reader1["value"].ToString() == "numberoftables")
            //    {
            //        string masaSayisi = reader1["key"].ToString();
            //    }
            //}
            //connectdb.Close();
            
        }

        private void button2_Click(object sender, EventArgs e) //kafe adını değiştirme 
        {
            connectdb999.Open();
            OleDbCommand KAFEadi = new OleDbCommand();
            KAFEadi.Connection = connectdb999;

            // Sorguyu parametrelerle oluştur
            KAFEadi.CommandText = "UPDATE cafebilgileri SET [key]=@p1 WHERE [value]=@p2";
            KAFEadi.Parameters.AddWithValue("@p1", textBox2.Text);
            KAFEadi.Parameters.AddWithValue("@p2", "cafename");

            // Komutu çalıştır
            KAFEadi.ExecuteNonQuery();

            connectdb999.Close();

            MessageBox.Show("kafe adı değişti..");
        }

        private void button3_Click(object sender, EventArgs e)//PERSONEL EKLEME
        {
            connectdb999.Open();
            OleDbCommand komut1 = new OleDbCommand("insert into personeller (personelAdi) values(@p1)", connectdb999);
            komut1.Parameters.AddWithValue("@p1", textBox3.Text);
            
            komut1.ExecuteNonQuery();
            connectdb999.Close();
            MessageBox.Show("personel eklenmiştir..");
        }

        private void button4_Click(object sender, EventArgs e)//yiyecek ve içecek ekleme 
        {
            connectdb999.Open();
            OleDbCommand komut1 = new OleDbCommand("insert into MENU (içerik,türü,price) values(@p1,@p2,@p3)", connectdb999);
            komut1.Parameters.AddWithValue("@p1", textBox4.Text);
            komut1.Parameters.AddWithValue("@p2", comboBox1.Text);
            komut1.Parameters.AddWithValue("@p3", textBox5.Text);
            komut1.ExecuteNonQuery();
            connectdb999.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }
    }
}
