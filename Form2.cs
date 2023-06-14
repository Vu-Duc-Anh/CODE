using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Numerics;

namespace demo
{
    public partial class Form2 : Form
    {
        string strCon = @"Data Source=DESKTOP-KLT2OSA\MAYA;Initial Catalog=Nguoidung;Integrated Security=True";

        SqlConnection SqlCon = null;
        
        
        public Form2()
        {
            InitializeComponent();

        }

       

       
        private void btn_Openfile(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Tệp văn bản (*.txt)|*.txt|Tất cả các tệp (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    txtBrower.Text = selectedFilePath;
                }    


            }
        }

        private void btn_OpenFile(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Tệp văn bản (*.txt)|*.txt|Tất cả các tệp (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    TxtEncrypt.Text = selectedFilePath;
                }


            }
        }

        private void btn_Dangxuat(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Lưu(object sender, EventArgs e)
        {
            
            string connectionString = "Data Source=DESKTOP-KLT2OSA\\MAYA;Initial Catalog=Nguoidung;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string fileName = txtBrower.Text;
                string filePath = txtBrower.Text;

                string insertQuery = "INSERT INTO Files (FileName, FilePath) VALUES (@FileName, @FilePath)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@FileName", fileName);
                    command.Parameters.AddWithValue("@FilePath", filePath);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Đường dẫn đã được lưu thành công vào cơ sở dữ liệu.");
            }
        }

        private void btn_openfile(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Tệp văn bản (*.txt)|*.txt|Tất cả các tệp (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    txtDe.Text = selectedFilePath;
                }


            }
        }

        private void buttonKiemTra_Click(object sender, EventArgs e)
        {
            Form3 F = new Form3();
            F.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string md5Hash;
        private string encryptionKey;
        private void btnEn_Click(object sender, EventArgs e)
        {
            string filePath = TxtEncrypt.Text;

            try
            {
                // Tạo đối tượng MD5
                using (MD5 md5 = MD5.Create())
                {
                    // Đọc dữ liệu từ tệp tin
                    byte[] data = File.ReadAllBytes(filePath);

                    // Tính toán giá trị hash MD5 của dữ liệu
                    byte[] hash = md5.ComputeHash(data);

                    // Chuyển đổi giá trị hash sang dạng chuỗi hex để lưu trữ
                    md5Hash = BitConverter.ToString(hash).Replace("-", "");

                    // Ẩn tệp tin và thiết lập thuộc tính chỉ đọc
                    File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.ReadOnly | FileAttributes.Hidden);

                    MessageBox.Show("Tệp tin đã được mã hóa và bảo vệ!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mã hóa tệp tin: " + ex.Message);
            }
        }



        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(md5Hash))
            {
                MessageBox.Show("Không có khóa giải mã.");
                return;
            }

            string filePath = txtDe.Text;

            try
            {
                // Kiểm tra xem tệp tin có thuộc tính chỉ đọc và ẩn không
                if ((File.GetAttributes(filePath) & (FileAttributes.ReadOnly | FileAttributes.Hidden)) == (FileAttributes.ReadOnly | FileAttributes.Hidden))
                {
                    // Xóa thuộc tính chỉ đọc và ẩn
                    File.SetAttributes(filePath, File.GetAttributes(filePath) & ~(FileAttributes.ReadOnly | FileAttributes.Hidden));

                    MessageBox.Show("Tệp tin đã được giải mã và có thể mở lại.");
                }
                else
                {
                    MessageBox.Show("Tệp tin không hợp lệ hoặc không thể giải mã.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể giải mã tệp tin: " + ex.Message);
            }
        }


        private void btn_GenerateKeys_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int key = random.Next(1, 1001); // Tạo số nguyên trong khoảng từ 1 đến 1000

            using (MD5 md5 = MD5.Create())
            {
                byte[] keyBytes = BitConverter.GetBytes(key);
                byte[] hash = md5.ComputeHash(keyBytes);

                // Chuyển đổi khóa sang dạng chuỗi hex để hiển thị trong TextBox
                string keyHex = BitConverter.ToString(hash).Replace("-", "");

                // Gán giá trị khóa vào biến toàn cục
                encryptionKey = keyHex;

                // Gán giá trị khóa vào TextBox
                txtkey.Text = keyHex;
            }
        }
    }
}
