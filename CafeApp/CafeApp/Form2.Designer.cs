namespace CafeApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.cafeName = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.FlowLayoutPanel();
            this.purchased = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.Button();
            this.totalValue = new System.Windows.Forms.Label();
            this.cafeDataSet = new CafeApp.cafeDataSet();
            this.cafeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.purchased.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cafeName
            // 
            this.cafeName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cafeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cafeName.Location = new System.Drawing.Point(0, 0);
            this.cafeName.Name = "cafeName";
            this.cafeName.Size = new System.Drawing.Size(1190, 74);
            this.cafeName.TabIndex = 2;
            this.cafeName.Text = "label1";
            this.cafeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu
            // 
            this.menu.AutoScroll = true;
            this.menu.Location = new System.Drawing.Point(12, 91);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(730, 366);
            this.menu.TabIndex = 3;
            this.menu.Paint += new System.Windows.Forms.PaintEventHandler(this.menu_Paint);
            // 
            // purchased
            // 
            this.purchased.Controls.Add(this.label1);
            this.purchased.Location = new System.Drawing.Point(766, 91);
            this.purchased.Margin = new System.Windows.Forms.Padding(0);
            this.purchased.Name = "purchased";
            this.purchased.Size = new System.Drawing.Size(400, 262);
            this.purchased.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.total.Location = new System.Drawing.Point(766, 356);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(209, 49);
            this.total.TabIndex = 1;
            this.total.Text = "TOPLAM";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(981, 356);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(185, 101);
            this.pay.TabIndex = 5;
            this.pay.Text = "ÖDE";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // totalValue
            // 
            this.totalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalValue.Location = new System.Drawing.Point(766, 409);
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(209, 48);
            this.totalValue.TabIndex = 6;
            this.totalValue.Text = "0 TL";
            this.totalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalValue.Click += new System.EventHandler(this.totalValue_Click);
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
            // cafeDataSetBindingSource1
            // 
            this.cafeDataSetBindingSource1.DataSource = this.cafeDataSet;
            this.cafeDataSetBindingSource1.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 491);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(641, 170);
            this.dataGridView1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(766, 512);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(766, 566);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(766, 625);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(766, 672);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 715);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.totalValue);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.purchased);
            this.Controls.Add(this.total);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.cafeName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.purchased.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cafeName;
        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.FlowLayoutPanel purchased;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Label totalValue;
        private System.Windows.Forms.BindingSource cafeDataSetBindingSource;
        private cafeDataSet cafeDataSet;
        private System.Windows.Forms.BindingSource cafeDataSetBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}