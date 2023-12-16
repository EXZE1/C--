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
    public partial class menu : Form
    {
        
        public menu()
        {
            InitializeComponent();
            
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\oguzhan yucedag\Desktop\cafe.accdb");
        int i;
        void menu1()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from tables", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = (dt);
            //DataTable dt = new DataTable();
            //using (OleDbDataAdapter da = new OleDbDataAdapter("Select * From tables", baglanti))
            //{
            //    da.Fill(dt);
            //}
            //dataGridView1.DataSource = dt;

        }
        private void menu_Load(object sender, EventArgs e)
        {
            cafeName.Text = Form1.cafe_name;
            menu1();
            //DataTable DT = new DataTable();
            //OleDbDataAdapter DA = new OleDbDataAdapter("Select coffees from coffeesMenu", baglanti);
            //Label labelHeader = new Label();
            //labelHeader.Text = DA.
            //DA.Fill(DT);

            OleDbCommand komut;
            OleDbDataReader oku;
               
                string[] mevsimler;
                mevsimler = new string[5];
                baglanti.Open();
                komut = new OleDbCommand();
                komut.CommandText = "Select coffees from coffeesMenu\", baglanti";
                komut.Connection = baglanti;
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                
                mevsimler[1] = oku[0].ToString();
                i++;
                    break;
                }
                for(int k= 0; k < 5; k++)
                {
                listBox1.Items.Add(i);
                listBox1.Items.Add(mevsimler[1]);
                }
                baglanti.Close();


            //for (int j = 0; j < contents_array.Length; j++)
            //{
            //    Label labelContent = new Label();
            //    labelContent.Text = contents_array[j];
            //    labelContent.Width = 400;
            //    menuu.Controls.Add(labelContent);

            //    Button button = new Button();
            //    button.Text = "Add";

            //    menuu.Controls.Add(button);
            //}
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
    }
}
