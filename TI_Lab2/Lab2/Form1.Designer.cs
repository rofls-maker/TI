namespace Lab2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtSourceBin = new System.Windows.Forms.RichTextBox();
            this.txtKeyBin = new System.Windows.Forms.RichTextBox();
            this.txtResultBin = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSeed
            // 
            this.txtSeed.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtSeed.Location = new System.Drawing.Point(15, 30);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(300, 23);
            this.txtSeed.TabIndex = 0;
            this.txtSeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeed_KeyPress);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(15, 70);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(120, 30);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Выбрать файл";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.PaleGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(15, 120);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(300, 40);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Зашифровать / Расшифровать";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(150, 70);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(100, 13);
            this.lblFileName.TabIndex = 3;
            this.lblFileName.Text = "Файл не выбран...";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(150, 87);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(55, 13);
            this.lblFileSize.TabIndex = 4;
            this.lblFileSize.Text = "Размер: -";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStatus.Location = new System.Drawing.Point(12, 14);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(155, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Введите состояние (26 бит):";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 170);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 15);
            this.progressBar1.TabIndex = 6;
            // 
            // txtSourceBin
            // 
            this.txtSourceBin.BackColor = System.Drawing.Color.Black;
            this.txtSourceBin.Font = new System.Drawing.Font("Consolas", 8F);
            this.txtSourceBin.ForeColor = System.Drawing.Color.Lime;
            this.txtSourceBin.Location = new System.Drawing.Point(340, 30);
            this.txtSourceBin.Name = "txtSourceBin";
            this.txtSourceBin.ReadOnly = true;
            this.txtSourceBin.Size = new System.Drawing.Size(430, 100);
            this.txtSourceBin.TabIndex = 7;
            this.txtSourceBin.Text = "";
            // 
            // txtKeyBin
            // 
            this.txtKeyBin.BackColor = System.Drawing.Color.Black;
            this.txtKeyBin.Font = new System.Drawing.Font("Consolas", 8F);
            this.txtKeyBin.ForeColor = System.Drawing.Color.Yellow;
            this.txtKeyBin.Location = new System.Drawing.Point(340, 155);
            this.txtKeyBin.Name = "txtKeyBin";
            this.txtKeyBin.ReadOnly = true;
            this.txtKeyBin.Size = new System.Drawing.Size(430, 100);
            this.txtKeyBin.TabIndex = 8;
            this.txtKeyBin.Text = "";
            // 
            // txtResultBin
            // 
            this.txtResultBin.BackColor = System.Drawing.Color.Black;
            this.txtResultBin.Font = new System.Drawing.Font("Consolas", 8F);
            this.txtResultBin.ForeColor = System.Drawing.Color.Cyan;
            this.txtResultBin.Location = new System.Drawing.Point(340, 280);
            this.txtResultBin.Name = "txtResultBin";
            this.txtResultBin.ReadOnly = true;
            this.txtResultBin.Size = new System.Drawing.Size(430, 100);
            this.txtResultBin.TabIndex = 9;
            this.txtResultBin.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(337, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Исходный файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(337, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ключевой поток K";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(337, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Зашифрованные биты";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 60);
            this.label4.TabIndex = 13;
            this.label4.Text = "m=26\nПолином: x^26  + x^8  + x^7  + x + 1\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultBin);
            this.Controls.Add(this.txtKeyBin);
            this.Controls.Add(this.txtSourceBin);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtSeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox txtSourceBin;
        private System.Windows.Forms.RichTextBox txtKeyBin;
        private System.Windows.Forms.RichTextBox txtResultBin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}