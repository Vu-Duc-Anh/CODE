namespace demo
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
            this.lbl_LuuFile = new System.Windows.Forms.Label();
            this.txtBrower = new System.Windows.Forms.TextBox();
            this.lblmahoagiaima = new System.Windows.Forms.Label();
            this.TxtEncrypt = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnBrower = new System.Windows.Forms.Button();
            this.btn_Brower3 = new System.Windows.Forms.Button();
            this.btn_Brower2 = new System.Windows.Forms.Button();
            this.butDangxuat = new System.Windows.Forms.Button();
            this.btn_luuFile = new System.Windows.Forms.Button();
            this.btn_Kiemtra = new System.Windows.Forms.Button();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.btnEn = new System.Windows.Forms.Button();
            this.lblLuufile = new System.Windows.Forms.Label();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_LuuFile
            // 
            this.lbl_LuuFile.AutoSize = true;
            this.lbl_LuuFile.Location = new System.Drawing.Point(43, 34);
            this.lbl_LuuFile.Name = "lbl_LuuFile";
            this.lbl_LuuFile.Size = new System.Drawing.Size(0, 15);
            this.lbl_LuuFile.TabIndex = 1;
            // 
            // txtBrower
            // 
            this.txtBrower.Location = new System.Drawing.Point(12, 92);
            this.txtBrower.Name = "txtBrower";
            this.txtBrower.Size = new System.Drawing.Size(372, 23);
            this.txtBrower.TabIndex = 2;
            // 
            // lblmahoagiaima
            // 
            this.lblmahoagiaima.AutoSize = true;
            this.lblmahoagiaima.Location = new System.Drawing.Point(43, 171);
            this.lblmahoagiaima.Name = "lblmahoagiaima";
            this.lblmahoagiaima.Size = new System.Drawing.Size(116, 15);
            this.lblmahoagiaima.TabIndex = 3;
            this.lblmahoagiaima.Text = "2. Mã hóa và giải mã";
            // 
            // TxtEncrypt
            // 
            this.TxtEncrypt.Location = new System.Drawing.Point(20, 314);
            this.TxtEncrypt.Name = "TxtEncrypt";
            this.TxtEncrypt.Size = new System.Drawing.Size(139, 23);
            this.TxtEncrypt.TabIndex = 4;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(357, 343);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnBrower
            // 
            this.btnBrower.Location = new System.Drawing.Point(440, 312);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(86, 25);
            this.btnBrower.TabIndex = 0;
            this.btnBrower.Text = "Browers...";
            this.btnBrower.UseVisualStyleBackColor = true;
            this.btnBrower.Click += new System.EventHandler(this.btn_openfile);
            // 
            // btn_Brower3
            // 
            this.btn_Brower3.Location = new System.Drawing.Point(404, 90);
            this.btn_Brower3.Name = "btn_Brower3";
            this.btn_Brower3.Size = new System.Drawing.Size(86, 25);
            this.btn_Brower3.TabIndex = 10;
            this.btn_Brower3.Text = "Browers...";
            this.btn_Brower3.UseVisualStyleBackColor = true;
            this.btn_Brower3.Click += new System.EventHandler(this.btn_Openfile);
            // 
            // btn_Brower2
            // 
            this.btn_Brower2.Location = new System.Drawing.Point(165, 312);
            this.btn_Brower2.Name = "btn_Brower2";
            this.btn_Brower2.Size = new System.Drawing.Size(86, 25);
            this.btn_Brower2.TabIndex = 11;
            this.btn_Brower2.Text = "Browers...";
            this.btn_Brower2.UseVisualStyleBackColor = true;
            this.btn_Brower2.Click += new System.EventHandler(this.btn_OpenFile);
            // 
            // butDangxuat
            // 
            this.butDangxuat.Location = new System.Drawing.Point(415, 393);
            this.butDangxuat.Name = "butDangxuat";
            this.butDangxuat.Size = new System.Drawing.Size(75, 23);
            this.butDangxuat.TabIndex = 12;
            this.butDangxuat.Text = "Đăng xuất";
            this.butDangxuat.UseVisualStyleBackColor = true;
            this.butDangxuat.Click += new System.EventHandler(this.btn_Dangxuat);
            // 
            // btn_luuFile
            // 
            this.btn_luuFile.Location = new System.Drawing.Point(404, 133);
            this.btn_luuFile.Name = "btn_luuFile";
            this.btn_luuFile.Size = new System.Drawing.Size(75, 23);
            this.btn_luuFile.TabIndex = 13;
            this.btn_luuFile.Text = "Lưu ";
            this.btn_luuFile.UseVisualStyleBackColor = true;
            this.btn_luuFile.Click += new System.EventHandler(this.btn_Lưu);
            // 
            // btn_Kiemtra
            // 
            this.btn_Kiemtra.Location = new System.Drawing.Point(309, 133);
            this.btn_Kiemtra.Name = "btn_Kiemtra";
            this.btn_Kiemtra.Size = new System.Drawing.Size(75, 23);
            this.btn_Kiemtra.TabIndex = 14;
            this.btn_Kiemtra.Text = "Kiểm Tra";
            this.btn_Kiemtra.UseVisualStyleBackColor = true;
            this.btn_Kiemtra.Click += new System.EventHandler(this.buttonKiemTra_Click);
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(293, 314);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(139, 23);
            this.txtDe.TabIndex = 15;
            // 
            // btnEn
            // 
            this.btnEn.Location = new System.Drawing.Point(84, 343);
            this.btnEn.Name = "btnEn";
            this.btnEn.Size = new System.Drawing.Size(75, 23);
            this.btnEn.TabIndex = 16;
            this.btnEn.Text = "Encrypt";
            this.btnEn.UseVisualStyleBackColor = true;
            this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
            // 
            // lblLuufile
            // 
            this.lblLuufile.AutoSize = true;
            this.lblLuufile.Location = new System.Drawing.Point(29, 38);
            this.lblLuufile.Name = "lblLuufile";
            this.lblLuufile.Size = new System.Drawing.Size(35, 15);
            this.lblLuufile.TabIndex = 17;
            this.lblLuufile.Text = "1. file";
            this.lblLuufile.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Location = new System.Drawing.Point(29, 221);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(86, 23);
            this.btnGenerateKeys.TabIndex = 19;
            this.btnGenerateKeys.Text = "tạo khóa ";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btn_GenerateKeys_Click);
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(134, 221);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(152, 23);
            this.txtkey.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 428);
            this.Controls.Add(this.txtkey);
            this.Controls.Add(this.btnGenerateKeys);
            this.Controls.Add(this.lblLuufile);
            this.Controls.Add(this.btnEn);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.btn_Kiemtra);
            this.Controls.Add(this.btn_luuFile);
            this.Controls.Add(this.butDangxuat);
            this.Controls.Add(this.btn_Brower2);
            this.Controls.Add(this.btn_Brower3);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.TxtEncrypt);
            this.Controls.Add(this.lblmahoagiaima);
            this.Controls.Add(this.txtBrower);
            this.Controls.Add(this.lbl_LuuFile);
            this.Controls.Add(this.btnBrower);
            this.Name = "Form2";
            this.Text = "Đouble AA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_LuuFile;
        private TextBox txtBrower;
        private Label lblmahoagiaima;
        private TextBox TxtEncrypt;
        private TextBox txtDecrypt;
        private Button btnDecrypt;
        private Button btnBrower;
        private Button btn_Brower3;
        private Button btn_Brower2;
        private Button butDangxuat;
        private Button btn_luuFile;
        private Button btn_Kiemtra;
        private TextBox txtDe;
        private Button btnEn;
        private Label lblLuufile;
        private Button btnGenerateKeys;
        private TextBox txtkey;
    }
}
