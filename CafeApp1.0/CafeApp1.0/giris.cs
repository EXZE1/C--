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
            yemeksilme();
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
        public void yemeksilme()
        {
            connectdb999.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connectdb999;
            command.CommandText = ("Select * from MENU");
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["türü"].ToString() == "yiyecek")
                {
                    comboBox2.Items.Add(reader["içerik"].ToString());

                }
                if (reader["türü"].ToString() == "içecek")
                {
                    comboBox2.Items.Add(reader["içerik"].ToString());
                }

            }
            connectdb999.Close();
        }

     
       
        
        private void button1_Click(object sender, EventArgs e)//masa sayısı değiştirme 
        {
            connectdb999.Open();
            OleDbCommand KAFEmasaAdedi = new OleDbCommand();
            KAFEmasaAdedi.Connection = connectdb999;

            // Sorguyu parametrelerle oluştur
            KAFEmasaAdedi.CommandText = "UPDATE cafebilgileri SET [key]=@p1 WHERE [value]=@p2";
            KAFEmasaAdedi.Parameters.AddWithValue("@p1", textBox1.Text);
            KAFEmasaAdedi.Parameters.AddWithValue("@p2", "numberoftables");

            // Komutu çalıştır
            KAFEmasaAdedi.ExecuteNonQuery();

            connectdb999.Close();
            MessageBox.Show("masa sayısı değişti..");
            
            
        }
        int günlükkasa = 0;
        int anakasa;
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
            OleDbCommand komut1 = new OleDbCommand("insert into personeller (personelAdi,personelSifresi) values(@p1,@p2)", connectdb999);
            komut1.Parameters.AddWithValue("@p1", textBox3.Text);
            komut1.Parameters.AddWithValue("@p2", textBox6.Text);
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
            MessageBox.Show("menüye ekleme yapıldı...");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            //günlük sattığı ürünlerden ne kadar para elde ettiği
            connectdb999.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connectdb999;
            command.CommandText = ("Select * from Siparis_Gecmisi");
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["sıfırlama"].ToString() == "s")
                {
                    günlükkasa = günlükkasa + Int32.Parse(reader["price"].ToString());
                }
                
            }
            connectdb999.Close();



            //bütün masalarda ki verileri silme...
            DialogResult result = MessageBox.Show("bütün masalarda ki hesaplar silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                connectdb999.Open();
                OleDbCommand hesapsil = new OleDbCommand();
                hesapsil.Connection = connectdb999;
                hesapsil.CommandText = ("Select * from Siparis_Gecmisi");
                OleDbDataReader hesapsilreader = hesapsil.ExecuteReader();
                OleDbCommand hesapclear = new OleDbCommand("delete from Siparis_Gecmisi where sıfırlama=@p1", connectdb999);
                while (hesapsilreader.Read())
                {
                    if (hesapsilreader["sıfırlama"].ToString() == "s")
                    {
                        hesapclear.Parameters.AddWithValue("@p1", "s");
                    }

                }

                hesapclear.ExecuteNonQuery();
                connectdb999.Close();
                MessageBox.Show("bütün masalarda ki hesaplar silindi... " + günlükkasa + "tl "+ "günlük kazancınızdır");
            }
            else
            {
                MessageBox.Show("hesapları temizleme işlemi gerçekleşmedi");
            }
            
            connectdb999.Open();
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connectdb999;
            command1.CommandText = ("Select * from siparisler");
            OleDbDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                
                anakasa = anakasa + Int32.Parse(reader1["fiyati"].ToString());
                

            }
            connectdb999.Close();
            MessageBox.Show(anakasa.ToString()+"TL  Ana kasada para vardır ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("menüden" + comboBox2.Text + "silmek istediğinize eminmisiniz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                connectdb999.Open();
                OleDbCommand hesapsil = new OleDbCommand();
                hesapsil.Connection = connectdb999;
                hesapsil.CommandText = ("Select * from MENU");
                OleDbDataReader hesapsilreader = hesapsil.ExecuteReader();
                OleDbCommand hesapclear = new OleDbCommand("delete from MENU where içerik=@p1", connectdb999);
                while (hesapsilreader.Read())
                {
                    if (hesapsilreader["içerik"].ToString() == comboBox2.Text)
                    {
                        hesapclear.Parameters.AddWithValue("@p1", comboBox2.Text);
                    }

                }

                hesapclear.ExecuteNonQuery();
                connectdb999.Close();
            }
        }
    }
}
