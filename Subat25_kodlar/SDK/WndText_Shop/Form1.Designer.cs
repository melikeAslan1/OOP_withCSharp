
namespace WndText_Shop
{
    partial class Form1
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
            this.LstEfektler = new System.Windows.Forms.ListBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnUygula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstEfektler
            // 
            this.LstEfektler.FormattingEnabled = true;
            this.LstEfektler.ItemHeight = 16;
            this.LstEfektler.Location = new System.Drawing.Point(55, 35);
            this.LstEfektler.Name = "LstEfektler";
            this.LstEfektler.Size = new System.Drawing.Size(420, 340);
            this.LstEfektler.TabIndex = 0;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(525, 44);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(349, 22);
            this.txtMesaj.TabIndex = 1;
            this.txtMesaj.Text = "txtMesaj";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(522, 99);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(51, 17);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Text = "LABEL";
            this.lblSonuc.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUygula
            // 
            this.btnUygula.Location = new System.Drawing.Point(525, 165);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(100, 49);
            this.btnUygula.TabIndex = 3;
            this.btnUygula.Text = "btnUygula";
            this.btnUygula.UseVisualStyleBackColor = true;
            this.btnUygula.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 501);
            this.Controls.Add(this.btnUygula);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.LstEfektler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstEfektler;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnUygula;
    }
}

