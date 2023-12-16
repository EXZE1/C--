using System.Data.OleDb;

namespace CafeApp1._0
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        //OleDbCommand _command;
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.new_Microsoft_Access_VeritabanıDataSet = new CafeApp1._0.New_Microsoft_Access_VeritabanıDataSet();
            this.newMicrosoftAccessVeritabanıDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
            this.newMicrosoftAccessVeritabanıDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cafeName = new System.Windows.Forms.Label();
            this.menuu = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.new_Microsoft_Access_VeritabanıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMicrosoftAccessVeritabanıDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMicrosoftAccessVeritabanıDataSetBindingSource1)).BeginInit();
            this.menuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // new_Microsoft_Access_VeritabanıDataSet
            // 
            this.new_Microsoft_Access_VeritabanıDataSet.DataSetName = "New_Microsoft_Access_VeritabanıDataSet";
            this.new_Microsoft_Access_VeritabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newMicrosoftAccessVeritabanıDataSetBindingSource
            // 
            this.newMicrosoftAccessVeritabanıDataSetBindingSource.DataSource = this.new_Microsoft_Access_VeritabanıDataSet;
            this.newMicrosoftAccessVeritabanıDataSetBindingSource.Position = 0;
            // 
            // newMicrosoftAccessVeritabanıDataSetBindingSource1
            // 
            this.newMicrosoftAccessVeritabanıDataSetBindingSource1.DataSource = this.new_Microsoft_Access_VeritabanıDataSet;
            this.newMicrosoftAccessVeritabanıDataSetBindingSource1.Position = 0;
            // 
            // cafeName
            // 
            this.cafeName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cafeName.Font = new System.Drawing.Font("Lucida Handwriting", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cafeName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cafeName.Location = new System.Drawing.Point(1, -2);
            this.cafeName.Margin = new System.Windows.Forms.Padding(0);
            this.cafeName.Name = "cafeName";
            this.cafeName.Size = new System.Drawing.Size(1169, 92);
            this.cafeName.TabIndex = 0;
            this.cafeName.Text = "label1";
            this.cafeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuu
            // 
            this.menuu.AutoScroll = true;
            this.menuu.Controls.Add(this.dataGridView1);
            this.menuu.Location = new System.Drawing.Point(8, 93);
            this.menuu.Name = "menuu";
            this.menuu.Size = new System.Drawing.Size(709, 411);
            this.menuu.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(672, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(750, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 229);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(750, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(990, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 124);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(751, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 57);
            this.label2.TabIndex = 5;
            this.label2.Text = "TOTAL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(879, 437);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 67);
            this.label3.TabIndex = 6;
            this.label3.Text = "TL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(750, 437);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 67);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(394, 510);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 148);
            this.listBox1.TabIndex = 1;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 707);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuu);
            this.Controls.Add(this.cafeName);
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.new_Microsoft_Access_VeritabanıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMicrosoftAccessVeritabanıDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMicrosoftAccessVeritabanıDataSetBindingSource1)).EndInit();
            this.menuu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private OleDbConnection oleDbConnection1;
        private System.Windows.Forms.BindingSource newMicrosoftAccessVeritabanıDataSetBindingSource;
        private New_Microsoft_Access_VeritabanıDataSet new_Microsoft_Access_VeritabanıDataSet;
        private OleDbConnection oleDbConnection2;
        private System.Windows.Forms.BindingSource newMicrosoftAccessVeritabanıDataSetBindingSource1;
        private System.Windows.Forms.Label cafeName;
        private System.Windows.Forms.Panel menuu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
    }
}