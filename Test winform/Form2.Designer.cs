namespace Test_winform
{
    partial class FormChuongTrinh
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
            this.txtbutton3 = new System.Windows.Forms.Button();
            this.txtbotton4 = new System.Windows.Forms.Button();
            this.labelHoten = new System.Windows.Forms.Label();
            this.LabelThongtin = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbutton3
            // 
            this.txtbutton3.Location = new System.Drawing.Point(739, 664);
            this.txtbutton3.Name = "txtbutton3";
            this.txtbutton3.Size = new System.Drawing.Size(196, 99);
            this.txtbutton3.TabIndex = 0;
            this.txtbutton3.Text = "Đăng xuất";
            this.txtbutton3.UseVisualStyleBackColor = true;
            this.txtbutton3.Click += new System.EventHandler(this.txtbutton3_Click);
            // 
            // txtbotton4
            // 
            this.txtbotton4.Location = new System.Drawing.Point(977, 668);
            this.txtbotton4.Name = "txtbotton4";
            this.txtbotton4.Size = new System.Drawing.Size(191, 95);
            this.txtbotton4.TabIndex = 0;
            this.txtbotton4.Text = "Thoát";
            this.txtbotton4.UseVisualStyleBackColor = true;
            this.txtbotton4.Click += new System.EventHandler(this.txtbotton4_Click);
            // 
            // labelHoten
            // 
            this.labelHoten.Location = new System.Drawing.Point(293, 115);
            this.labelHoten.Name = "labelHoten";
            this.labelHoten.Size = new System.Drawing.Size(669, 88);
            this.labelHoten.TabIndex = 1;
            this.labelHoten.Click += new System.EventHandler(this.labelHoten_Click);
            // 
            // LabelThongtin
            // 
            this.LabelThongtin.Location = new System.Drawing.Point(293, 243);
            this.LabelThongtin.Name = "LabelThongtin";
            this.LabelThongtin.Size = new System.Drawing.Size(669, 88);
            this.LabelThongtin.TabIndex = 1;
            this.LabelThongtin.Click += new System.EventHandler(this.LabelThongtin_Click);
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.Location = new System.Drawing.Point(293, 378);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(669, 88);
            this.labelDiaChi.TabIndex = 1;
            this.labelDiaChi.Click += new System.EventHandler(this.labelDiaChi_Click);
            // 
            // FormChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 937);
            this.Controls.Add(this.labelDiaChi);
            this.Controls.Add(this.LabelThongtin);
            this.Controls.Add(this.labelHoten);
            this.Controls.Add(this.txtbotton4);
            this.Controls.Add(this.txtbutton3);
            this.Name = "FormChuongTrinh";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChuongTrinh_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtbutton3;
        private System.Windows.Forms.Button txtbotton4;
        private System.Windows.Forms.Label labelHoten;
        private System.Windows.Forms.Label LabelThongtin;
        private System.Windows.Forms.Label labelDiaChi;
    }
}