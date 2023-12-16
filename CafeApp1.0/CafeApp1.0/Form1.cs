﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CafeApp1._0
{
    public partial class Form1 : Form
    {
        int number_of_tables = 30;
        public static string cafe_name = "Milano Kafe";
        public Form1()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cafeName.Text = cafe_name;

            for (int i = 1; i <= number_of_tables; i++)
            {
                Button btn = new Button();
                btn.Name = i.ToString();
                btn.Font = new Font("Times New Roman", 13);
                btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffe700");
                btn.Text = " MASA "+i.ToString();
                btn.Width = 170;
                btn.Height = 80;
                btn.Click += Btn_Click; //anlamadım 
                flowLayoutPanel1.Controls.Add(btn);
            }
        }


        public void Btn_Click(object sender, EventArgs e)
        {
            //Button btn = sender as Button;
            Button btn = (Button)sender; // anlamadım 
            menu menu = new menu();
            menu.Show();
            Hide();


        }
    }
}
