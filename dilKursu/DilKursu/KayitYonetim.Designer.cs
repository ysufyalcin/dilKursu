﻿namespace DilKursu
{
    partial class KayitYonetim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FilterTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AciklamaTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaatTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.KYonetimDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Yenile = new System.Windows.Forms.Button();
            this.AraBt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KYonetimDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Yenile);
            this.panel1.Controls.Add(this.AraBt);
            this.panel1.Controls.Add(this.FilterTb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 53);
            this.panel1.TabIndex = 16;
            // 
            // FilterTb
            // 
            this.FilterTb.Location = new System.Drawing.Point(545, 24);
            this.FilterTb.Name = "FilterTb";
            this.FilterTb.Size = new System.Drawing.Size(115, 20);
            this.FilterTb.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("RussellSquare", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(288, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ogrenci Kayit";
            // 
            // AciklamaTb
            // 
            this.AciklamaTb.Location = new System.Drawing.Point(155, 414);
            this.AciklamaTb.Multiline = true;
            this.AciklamaTb.Name = "AciklamaTb";
            this.AciklamaTb.Size = new System.Drawing.Size(146, 95);
            this.AciklamaTb.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(68, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Aciklama";
            // 
            // SaatTb
            // 
            this.SaatTb.Location = new System.Drawing.Point(155, 377);
            this.SaatTb.Name = "SaatTb";
            this.SaatTb.Size = new System.Drawing.Size(146, 20);
            this.SaatTb.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Kurs Saati";
            // 
            // AdTb
            // 
            this.AdTb.Location = new System.Drawing.Point(155, 342);
            this.AdTb.Name = "AdTb";
            this.AdTb.Size = new System.Drawing.Size(146, 20);
            this.AdTb.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Kurs Adi";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(483, 476);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 33);
            this.button4.TabIndex = 55;
            this.button4.Text = "TEMIZLE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(623, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 33);
            this.button3.TabIndex = 54;
            this.button3.Text = "GUNCELLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(763, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 33);
            this.button2.TabIndex = 53;
            this.button2.Text = "SIL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KYonetimDgv
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.KYonetimDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KYonetimDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.KYonetimDgv.ColumnHeadersHeight = 28;
            this.KYonetimDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KYonetimDgv.DefaultCellStyle = dataGridViewCellStyle9;
            this.KYonetimDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.KYonetimDgv.Location = new System.Drawing.Point(0, 59);
            this.KYonetimDgv.Name = "KYonetimDgv";
            this.KYonetimDgv.RowHeadersVisible = false;
            this.KYonetimDgv.RowTemplate.Height = 24;
            this.KYonetimDgv.Size = new System.Drawing.Size(949, 256);
            this.KYonetimDgv.TabIndex = 56;
            this.KYonetimDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.KYonetimDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.KYonetimDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.KYonetimDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.KYonetimDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.KYonetimDgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.KYonetimDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.KYonetimDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Orange;
            this.KYonetimDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.KYonetimDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KYonetimDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.KYonetimDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.KYonetimDgv.ThemeStyle.HeaderStyle.Height = 28;
            this.KYonetimDgv.ThemeStyle.ReadOnly = false;
            this.KYonetimDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.KYonetimDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.KYonetimDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KYonetimDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.KYonetimDgv.ThemeStyle.RowsStyle.Height = 24;
            this.KYonetimDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Brown;
            this.KYonetimDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.KYonetimDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KYonetimDgv_CellClick);
            // 
            // Yenile
            // 
            this.Yenile.Location = new System.Drawing.Point(775, 20);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(54, 27);
            this.Yenile.TabIndex = 37;
            this.Yenile.Text = "Yenile";
            this.Yenile.UseVisualStyleBackColor = true;
            this.Yenile.Click += new System.EventHandler(this.Yenile_Click);
            // 
            // AraBt
            // 
            this.AraBt.Location = new System.Drawing.Point(666, 20);
            this.AraBt.Name = "AraBt";
            this.AraBt.Size = new System.Drawing.Size(103, 27);
            this.AraBt.TabIndex = 36;
            this.AraBt.Text = "ARA";
            this.AraBt.UseVisualStyleBackColor = true;
            this.AraBt.Click += new System.EventHandler(this.AraBt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "<<<";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // KayitYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 530);
            this.Controls.Add(this.KYonetimDgv);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AciklamaTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaatTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KayitYonetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayitYonetim";
            this.Load += new System.EventHandler(this.KayitYonetim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KYonetimDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AciklamaTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SaatTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox FilterTb;
        private Guna.UI2.WinForms.Guna2DataGridView KYonetimDgv;
        private System.Windows.Forms.Button Yenile;
        private System.Windows.Forms.Button AraBt;
        private System.Windows.Forms.Label label7;
    }
}