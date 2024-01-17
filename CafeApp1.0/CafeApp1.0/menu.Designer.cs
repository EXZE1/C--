using System.Data.OleDb;

namespace CafeApp1._0
{
    partial class panel2
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
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.BUTTON = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuu = new System.Windows.Forms.FlowLayoutPanel();
            this.cafeDataSet = new CafeApp1._0.cafeDataSet();
            this.cafeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.new_Microsoft_Access_VeritabanıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMicrosoftAccessVeritabanıDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMicrosoftAccessVeritabanıDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSetBindingSource)).BeginInit();
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
            this.cafeName.Size = new System.Drawing.Size(1189, 92);
            this.cafeName.TabIndex = 0;
            this.cafeName.Text = "label1";
            this.cafeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableNameLabel.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNameLabel.ForeColor = System.Drawing.Color.Black;
            this.tableNameLabel.Location = new System.Drawing.Point(710, 93);
            this.tableNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(480, 53);
            this.tableNameLabel.TabIndex = 3;
            this.tableNameLabel.Text = "label1";
            this.tableNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BUTTON
            // 
            this.BUTTON.Location = new System.Drawing.Point(990, 380);
            this.BUTTON.Name = "BUTTON";
            this.BUTTON.Size = new System.Drawing.Size(200, 125);
            this.BUTTON.TabIndex = 4;
            this.BUTTON.Text = "Hesabı Kapa";
            this.BUTTON.UseVisualStyleBackColor = true;
            this.BUTTON.Click += new System.EventHandler(this.BUTTON_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(710, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 58);
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
            this.label3.Size = new System.Drawing.Size(102, 68);
            this.label3.TabIndex = 6;
            this.label3.Text = "TL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(716, 437);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 68);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuu
            // 
            this.menuu.AutoScroll = true;
            this.menuu.Location = new System.Drawing.Point(9, 93);
            this.menuu.Name = "menuu";
            this.menuu.Size = new System.Drawing.Size(695, 418);
            this.menuu.TabIndex = 8;
            // 
            // cafeDataSet
            // 
            this.cafeDataSet.DataSetName = "cafeDataSet";
            this.cafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cafeDataSetBindingSource
            // 
            this.cafeDataSetBindingSource.DataSource = this.cafeDataSet;
            this.cafeDataSetBindingSource.Position = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(710, 149);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(480, 225);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "EKLEYEN PERSONEL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 517);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 14;
            this.button1.Text = "geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(617, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 15;
            this.button2.Text = "ayarlar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(173, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 552);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BUTTON);
            this.Controls.Add(this.tableNameLabel);
            this.Controls.Add(this.cafeName);
            this.Name = "panel2";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.new_Microsoft_Access_VeritabanıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMicrosoftAccessVeritabanıDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMicrosoftAccessVeritabanıDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private OleDbConnection oleDbConnection1;
        private System.Windows.Forms.BindingSource newMicrosoftAccessVeritabanıDataSetBindingSource;
        private New_Microsoft_Access_VeritabanıDataSet new_Microsoft_Access_VeritabanıDataSet;
        private OleDbConnection oleDbConnection2;
        private System.Windows.Forms.BindingSource newMicrosoftAccessVeritabanıDataSetBindingSource1;
        private System.Windows.Forms.Label cafeName;
        private System.Windows.Forms.Label tableNameLabel;
        private System.Windows.Forms.Button BUTTON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel menuu;
        private System.Windows.Forms.BindingSource cafeDataSetBindingSource;
        private cafeDataSet cafeDataSet;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}