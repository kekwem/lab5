using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void compress()
        {
            byte[] data = System.Text.Encoding.Default.GetBytes(contentTextBox.Text);
            using (FileStream fs = new FileStream(pathTextBox.Text, FileMode.Create))
            {
                using (Stream ds = new DeflateStream(fs, CompressionMode.Compress))
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        ds.WriteByte(data[i]);
                    }
                }
            }
            using (FileStream fs = new FileStream(pathTextBox.Text, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    contentTextBox.Text = sr.ReadToEnd();
                }
            }
        }
        
        void decompress()
        {
            byte[] data = System.Text.Encoding.Default.GetBytes(File.ReadAllText(pathTextBox.Text));
            using (FileStream fs = new FileStream(pathTextBox.Text, FileMode.Create))
            {
                using (Stream ds = new DeflateStream(fs, CompressionMode.Decompress))
                {
                    ds.Read(data, 0, data.Length);
                }
            }
            string napis = System.Text.Encoding.Default.GetString(data);
            contentTextBox.Text = napis;
        }

        string hash = "qsqv@41";

        void encryption()
        {
            byte[] data = System.Text.Encoding.Default.GetBytes(contentTextBox.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = key,
                    Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    contentTextBox.Text = Convert.ToBase64String(result, 0, result.Length);
                }
            }
        }

        void decryption()
        {
            byte[] data = Convert.FromBase64String(contentTextBox.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] key = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = key,
                    Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    contentTextBox.Text = System.Text.Encoding.Default.GetString(result, 0, result.Length);
                }
            }
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            pathTextBox.Text = openFileDialog.FileName;
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (compressCheckBox.Checked) compress();
            if (szyfrowanieCheckBox1.Checked) encryption();
            FileStream fs = new FileStream(pathTextBox.Text, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(contentTextBox.Text);
            sw.Close();
            fs.Close();
            contentTextBox.Text = "";
        }
        
        private void odczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FileStream fs = new FileStream(pathTextBox.Text, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            contentTextBox.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            if (compressCheckBox.Checked) decompress();
            if (szyfrowanieCheckBox1.Checked) decryption();
        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
