namespace tek_cift_123
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkCift = new System.Windows.Forms.CheckBox();
            this.chkTek = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(638, 130);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 17;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtToplam
            // 
            this.txtToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplam.Location = new System.Drawing.Point(527, 124);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(60, 29);
            this.txtToplam.TabIndex = 16;
            this.txtToplam.TextChanged += new System.EventHandler(this.txtToplam_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(435, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "toplamı =";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chkCift
            // 
            this.chkCift.AutoSize = true;
            this.chkCift.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkCift.Location = new System.Drawing.Point(283, 142);
            this.chkCift.Name = "chkCift";
            this.chkCift.Size = new System.Drawing.Size(129, 28);
            this.chkCift.TabIndex = 14;
            this.chkCift.Text = "Çift Sayıların";
            this.chkCift.UseVisualStyleBackColor = true;
            this.chkCift.CheckedChanged += new System.EventHandler(this.chkCift_CheckedChanged);
            // 
            // chkTek
            // 
            this.chkTek.AutoSize = true;
            this.chkTek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkTek.Location = new System.Drawing.Point(283, 108);
            this.chkTek.Name = "chkTek";
            this.chkTek.Size = new System.Drawing.Size(136, 28);
            this.chkTek.TabIndex = 13;
            this.chkTek.Text = "Tek Sayıların";
            this.chkTek.UseVisualStyleBackColor = true;
            this.chkTek.CheckedChanged += new System.EventHandler(this.chkTek_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(174, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "arasındaki";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSayi2
            // 
            this.txtSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi2.Location = new System.Drawing.Point(123, 127);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(36, 29);
            this.txtSayi2.TabIndex = 11;
            this.txtSayi2.TextChanged += new System.EventHandler(this.txtSayi2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(88, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "ile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSayi1
            // 
            this.txtSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi1.Location = new System.Drawing.Point(37, 127);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(36, 29);
            this.txtSayi1.TabIndex = 9;
            this.txtSayi1.TextChanged += new System.EventHandler(this.txtSayi1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkCift);
            this.Controls.Add(this.chkTek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkCift;
        private System.Windows.Forms.CheckBox chkTek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi1;
    }
}

