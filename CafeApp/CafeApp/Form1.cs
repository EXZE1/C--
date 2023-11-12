using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApp
{
    public partial class Form1 : Form
    {
        public static string cafe_name = "Milano Kafe";
        int number_of_tables = 15;
        string date = "12.11.2023 15:30";


        public Form1()
        {
            InitializeComponent();
        
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            cafeName.Text = cafe_name;

            for (int i = 1; i <= number_of_tables; i++)
            {
                Button btn = new Button();
                btn.Name = i.ToString();
                btn.Text = i.ToString();
                btn.Width = 170;
                btn.Height = 100;
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }


            
        }
        public void Btn_Click(object sender, EventArgs e)
        {
            //Button btn = sender as Button;
            Button btn = (Button)sender;
            Form2 form2 = new Form2();
            form2.Show();
            Hide();

            
        }
    }
}
