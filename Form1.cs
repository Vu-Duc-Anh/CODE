using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Thoat(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txttaikhoan.Focus();
            txtMatkhau.Focus();

            txttaikhoan.KeyPress += Txttaikhoan_KeyPress;
            txtMatkhau.KeyPress += txtMatkhau_KeyPress;
        }

        private void Txttaikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtMatkhau.Focus();
                e.Handled = true; // Ngăn chặn ký tự Enter xuất hiện trong TextBox
            }
        }
        private void txtMatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
                e.Handled = true; // Ngăn chặn ký tự Enter xuất hiện trong TextBox

                if (this.txttaikhoan.Text == "Tuandat" && this.txtMatkhau.Text == "123456")
                {
                    Form2 f = new Form2();
                    f.Show();
                    this.Hide();
                }
            }
        }

        private void Login()
        {
            if (txttaikhoan.Text.Length == 0 && txtMatkhau.Text.Length == 0)
                MessageBox.Show("Bạn chưa đăng nhập mật khẩu");
            else
                if (this.txttaikhoan.Text.Length == 0)
                    MessageBox.Show("Bạn chưa đăng nhập Tài Khoản");
                else
                    if (this.txtMatkhau.Text.Length == 0)
                        MessageBox.Show("Bạn chưa đăng nhập mật khẩu");
                    else
                        if (this.txttaikhoan.Text == "Tuandat" && this.txtMatkhau.Text == "123456")
                            MessageBox.Show("Đăng nhập thành công");
                        else
                            MessageBox.Show("Đăng nhập không thành công");
        }
        private void btn_Login(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            if (this.txttaikhoan.Text == "Tuandat" && this.txtMatkhau.Text == "123456")
            {
                f.Show();
                this.Hide();
            }
            Login();
        }
    }
}
