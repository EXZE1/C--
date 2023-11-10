using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KafeProgramiUretme
{
    public partial class Form1 : Form
    {
        string[] yiyecek = new string[10];
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            string[] yiyecek = new string[listBox1.Items.Count];

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                yiyecek[i] = listBox1.Items[i].ToString();
            }
            string verilerMetni1 = string.Join(Environment.NewLine, yiyecek);
            MessageBox.Show(verilerMetni1, "Liste Verileri");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
            string[] icecek = new string[listBox2.Items.Count];

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                icecek[i] = listBox2.Items[i].ToString();
            }

            string verilerMetni2 = string.Join(Environment.NewLine, icecek);
            MessageBox.Show(verilerMetni2, "Liste Verileri");
        }
    }
}
