using LabLFSR;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private string _inputFilePath = string.Empty;

        private const int RegisterSize = 26;

        public Form1()
        {
            InitializeComponent();

            txtSeed.MaxLength = RegisterSize;
            lblStatus.Text = $"Введите {RegisterSize} бит (0/1)";
        }

        private void txtSeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _inputFilePath = ofd.FileName;
                    lblFileName.Text = Path.GetFileName(_inputFilePath);

                    double sizeMb = new FileInfo(_inputFilePath).Length / 1024.0 / 1024.0;
                    lblFileSize.Text = $"Размер: {sizeMb:F2} МБ";
                }
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_inputFilePath) || !File.Exists(_inputFilePath))
            {
                MessageBox.Show("Выберите файл!");
                return;
            }

            if (txtSeed.Text.Length != RegisterSize)
            {
                MessageBox.Show($"Ошибка: нужно {RegisterSize} бит.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                FileName = "processed_" + Path.GetFileName(_inputFilePath)
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            string outputFilePath = sfd.FileName;

            LFSR lfsr = new LFSR(txtSeed.Text);

            btnStart.Enabled = false;
            progressBar1.Value = 0;
            lblStatus.Text = "Обработка данных...";

            try
            {
                await ProcessFileAsync(_inputFilePath, outputFilePath, lfsr);
                MessageBox.Show("Файл успешно обработан!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                btnStart.Enabled = true;
            }
        }

       
        private async Task ProcessFileAsync(string inputPath, string outputPath, LFSR lfsr)
        {
            byte[] sourceBytes = File.ReadAllBytes(inputPath);
            byte[] keyBytes = new byte[sourceBytes.Length];
            byte[] resultBytes = new byte[sourceBytes.Length];

            await Task.Run(() =>
            {
                for (int i = 0; i < sourceBytes.Length; i++)
                {
                    byte keyByte = lfsr.NextByte();

                    keyBytes[i] = keyByte;
                    resultBytes[i] = (byte)(sourceBytes[i] ^ keyByte);

                    if (i % 1000 == 0 || i == sourceBytes.Length - 1)
                    {
                        int progress = (int)((i * 100L) / sourceBytes.Length);
                        this.Invoke(new Action(() => progressBar1.Value = progress));
                    }
                }
            });

            txtSourceBin.Text = ToBinaryString(sourceBytes);
            txtKeyBin.Text = ToBinaryString(keyBytes);
            txtResultBin.Text = ToBinaryString(resultBytes);

            File.WriteAllBytes(outputPath, resultBytes);

            progressBar1.Value = 100;
            lblStatus.Text = "Готово!";
        }

        private string ToBinaryString(byte[] data)
        {
            if (data == null || data.Length == 0)
                return "";

            StringBuilder sb = new StringBuilder(data.Length * 9);

            foreach (byte b in data)
            {
                sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
                sb.Append(" ");
            }

            return sb.ToString();
        }
    }
}