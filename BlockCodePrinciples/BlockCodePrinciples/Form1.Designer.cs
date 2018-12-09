namespace BlockCodePrinciples
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.tbxNhap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvCodewords = new System.Windows.Forms.ListView();
            this.btnEsc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblD = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.lblKQQ = new System.Windows.Forms.Label();
            this.lblKQP = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(836, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Block Code Principles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNhap);
            this.groupBox1.Controls.Add(this.tbxNhap);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(398, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểm tra";
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhap.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhap.ForeColor = System.Drawing.Color.Black;
            this.btnNhap.Location = new System.Drawing.Point(295, 30);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(113, 36);
            this.btnNhap.TabIndex = 5;
            this.btnNhap.Text = "Kiểm tra";
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // tbxNhap
            // 
            this.tbxNhap.Location = new System.Drawing.Point(21, 34);
            this.tbxNhap.Name = "tbxNhap";
            this.tbxNhap.Size = new System.Drawing.Size(251, 23);
            this.tbxNhap.TabIndex = 0;
            this.tbxNhap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbxNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNhap_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvCodewords);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(9, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 513);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Block Code Principles";
            // 
            // lsvCodewords
            // 
            this.lsvCodewords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvCodewords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvCodewords.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsvCodewords.FullRowSelect = true;
            this.lsvCodewords.GridLines = true;
            this.lsvCodewords.Location = new System.Drawing.Point(6, 22);
            this.lsvCodewords.Name = "lsvCodewords";
            this.lsvCodewords.Size = new System.Drawing.Size(371, 485);
            this.lsvCodewords.TabIndex = 0;
            this.lsvCodewords.UseCompatibleStateImageBehavior = false;
            this.lsvCodewords.View = System.Windows.Forms.View.Details;
            this.lsvCodewords.SelectedIndexChanged += new System.EventHandler(this.lsvCodewords_SelectedIndexChanged);
            // 
            // btnEsc
            // 
            this.btnEsc.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsc.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEsc.ForeColor = System.Drawing.Color.Black;
            this.btnEsc.Location = new System.Drawing.Point(629, 558);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(189, 43);
            this.btnEsc.TabIndex = 4;
            this.btnEsc.Text = "Thoát";
            this.btnEsc.UseVisualStyleBackColor = false;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblD);
            this.groupBox3.Controls.Add(this.lblQ);
            this.groupBox3.Controls.Add(this.lblP);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(398, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 162);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hamming distance";
            // 
            // lblD
            // 
            this.lblD.BackColor = System.Drawing.Color.DarkOrange;
            this.lblD.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblD.ForeColor = System.Drawing.Color.Black;
            this.lblD.Location = new System.Drawing.Point(225, 38);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(183, 87);
            this.lblD.TabIndex = 2;
            this.lblD.Text = "d (p , q) = ";
            this.lblD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.BackColor = System.Drawing.Color.DarkOrange;
            this.lblQ.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQ.ForeColor = System.Drawing.Color.Black;
            this.lblQ.Location = new System.Drawing.Point(15, 90);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(186, 35);
            this.lblQ.TabIndex = 1;
            this.lblQ.Text = "q = 1001010";
            // 
            // lblP
            // 
            this.lblP.BackColor = System.Drawing.Color.DarkOrange;
            this.lblP.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblP.ForeColor = System.Drawing.Color.Black;
            this.lblP.Location = new System.Drawing.Point(15, 38);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(171, 35);
            this.lblP.TabIndex = 0;
            this.lblP.Text = "p = ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblKQ);
            this.groupBox4.Controls.Add(this.lblKQQ);
            this.groupBox4.Controls.Add(this.lblKQP);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(398, 357);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 177);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kết quả tốt nhất";
            // 
            // lblKQ
            // 
            this.lblKQ.BackColor = System.Drawing.Color.DarkOrange;
            this.lblKQ.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKQ.ForeColor = System.Drawing.Color.Black;
            this.lblKQ.Location = new System.Drawing.Point(225, 48);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(183, 87);
            this.lblKQ.TabIndex = 5;
            this.lblKQ.Text = "d (p , q) = ";
            this.lblKQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKQQ
            // 
            this.lblKQQ.AutoSize = true;
            this.lblKQQ.BackColor = System.Drawing.Color.DarkOrange;
            this.lblKQQ.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKQQ.ForeColor = System.Drawing.Color.Black;
            this.lblKQQ.Location = new System.Drawing.Point(15, 100);
            this.lblKQQ.Name = "lblKQQ";
            this.lblKQQ.Size = new System.Drawing.Size(186, 35);
            this.lblKQQ.TabIndex = 4;
            this.lblKQQ.Text = "q = 1001010";
            // 
            // lblKQP
            // 
            this.lblKQP.BackColor = System.Drawing.Color.DarkOrange;
            this.lblKQP.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKQP.ForeColor = System.Drawing.Color.Black;
            this.lblKQP.Location = new System.Drawing.Point(15, 48);
            this.lblKQP.Name = "lblKQP";
            this.lblKQP.Size = new System.Drawing.Size(171, 35);
            this.lblKQP.TabIndex = 3;
            this.lblKQP.Text = "p = ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNhapLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapLai.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhapLai.ForeColor = System.Drawing.Color.Black;
            this.btnNhapLai.Location = new System.Drawing.Point(398, 558);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(189, 43);
            this.btnNhapLai.TabIndex = 7;
            this.btnNhapLai.Text = "Nhập Lại";
            this.btnNhapLai.UseVisualStyleBackColor = false;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CodeWord";
            this.columnHeader1.Width = 239;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 0;
            this.columnHeader2.Text = "Code";
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 619);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvCodewords;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Label lblKQQ;
        private System.Windows.Forms.Label lblKQP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

