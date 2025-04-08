namespace Test_winform
{
    partial class FormDangNhap
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
            this.button1 = new System.Windows.Forms.Button();
            this.txbtaikhoan = new System.Windows.Forms.RichTextBox();
            this.txbmatkhau = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbotton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(491, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbtaikhoan
            // 
            this.txbtaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtaikhoan.Location = new System.Drawing.Point(281, 56);
            this.txbtaikhoan.Name = "txbtaikhoan";
            this.txbtaikhoan.Size = new System.Drawing.Size(623, 46);
            this.txbtaikhoan.TabIndex = 4;
            this.txbtaikhoan.Text = "";
            this.txbtaikhoan.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txbmatkhau
            // 
            this.txbmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbmatkhau.Location = new System.Drawing.Point(281, 189);
            this.txbmatkhau.Name = "txbmatkhau";
            this.txbmatkhau.Size = new System.Drawing.Size(623, 46);
            this.txbmatkhau.TabIndex = 4;
            this.txbmatkhau.Text = "";
            this.txbmatkhau.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tài khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbotton4
            // 
            this.txtbotton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbotton4.Location = new System.Drawing.Point(734, 255);
            this.txtbotton4.Name = "txtbotton4";
            this.txtbotton4.Size = new System.Drawing.Size(191, 95);
            this.txtbotton4.TabIndex = 6;
            this.txtbotton4.Text = "Thoát";
            this.txtbotton4.UseVisualStyleBackColor = true;
            this.txtbotton4.Click += new System.EventHandler(this.txtbotton4_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 403);
            this.Controls.Add(this.txtbotton4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbmatkhau);
            this.Controls.Add(this.txbtaikhoan);
            this.Controls.Add(this.button1);
            this.Name = "FormDangNhap";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txbtaikhoan;
        private System.Windows.Forms.RichTextBox txbmatkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtbotton4;
    }
}

