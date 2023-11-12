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
            this.cafeName = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.FlowLayoutPanel();
            this.purchased = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.Button();
            this.totalValue = new System.Windows.Forms.Label();
            this.purchased.SuspendLayout();
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
            this.menu.Location = new System.Drawing.Point(13, 91);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(730, 366);
            this.menu.TabIndex = 3;
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
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cafeName;
        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.FlowLayoutPanel purchased;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Label totalValue;
    }
}