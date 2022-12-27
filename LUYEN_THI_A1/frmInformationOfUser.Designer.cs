using System.Windows.Forms;

namespace LUYEN_THI_A1
{
    partial class frmInformationOfUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformationOfUser));
            this.gbTT = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.cbxMonth = new System.Windows.Forms.ComboBox();
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.txtBornDate = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.btnSuaTT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTDMK = new System.Windows.Forms.GroupBox();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.txtMKmoi2 = new System.Windows.Forms.TextBox();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThi = new System.Windows.Forms.Button();
            this.btnDX = new System.Windows.Forms.Button();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.gbTT.SuspendLayout();
            this.gbTDMK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTT
            // 
            this.gbTT.Controls.Add(this.rdoFemale);
            this.gbTT.Controls.Add(this.rdoMale);
            this.gbTT.Controls.Add(this.cbxYear);
            this.gbTT.Controls.Add(this.cbxMonth);
            this.gbTT.Controls.Add(this.cbxDay);
            this.gbTT.Controls.Add(this.txtBornDate);
            this.gbTT.Controls.Add(this.txtSex);
            this.gbTT.Controls.Add(this.btnSuaTT);
            this.gbTT.Controls.Add(this.label5);
            this.gbTT.Controls.Add(this.label4);
            this.gbTT.Controls.Add(this.txtDiaChi);
            this.gbTT.Controls.Add(this.txtHoTen);
            this.gbTT.Controls.Add(this.txtMaSo);
            this.gbTT.Controls.Add(this.label3);
            this.gbTT.Controls.Add(this.label2);
            this.gbTT.Controls.Add(this.label1);
            this.gbTT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTT.Location = new System.Drawing.Point(22, 22);
            this.gbTT.Name = "gbTT";
            this.gbTT.Size = new System.Drawing.Size(645, 142);
            this.gbTT.TabIndex = 0;
            this.gbTT.TabStop = false;
            this.gbTT.Text = "Thông Tin";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.Location = new System.Drawing.Point(489, 36);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(41, 19);
            this.rdoFemale.TabIndex = 21;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Nữ";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.Location = new System.Drawing.Point(432, 36);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(51, 19);
            this.rdoMale.TabIndex = 20;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Nam";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // cbxYear
            // 
            this.cbxYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxYear.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Items.AddRange(new object[] {
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010"});
            this.cbxYear.Location = new System.Drawing.Point(524, 66);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(50, 23);
            this.cbxYear.TabIndex = 19;
            this.cbxYear.Text = "1999";
            // 
            // cbxMonth
            // 
            this.cbxMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMonth.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbxMonth.Location = new System.Drawing.Point(478, 66);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(40, 23);
            this.cbxMonth.TabIndex = 18;
            this.cbxMonth.Text = "01";
            // 
            // cbxDay
            // 
            this.cbxDay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDay.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxDay.Location = new System.Drawing.Point(432, 67);
            this.cbxDay.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(40, 23);
            this.cbxDay.TabIndex = 17;
            this.cbxDay.Text = "01";
            // 
            // txtBornDate
            // 
            this.txtBornDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBornDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBornDate.Location = new System.Drawing.Point(432, 66);
            this.txtBornDate.Name = "txtBornDate";
            this.txtBornDate.ReadOnly = true;
            this.txtBornDate.Size = new System.Drawing.Size(150, 21);
            this.txtBornDate.TabIndex = 16;
            this.txtBornDate.Text = "Ngày sinh";
            this.txtBornDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSex.Location = new System.Drawing.Point(432, 34);
            this.txtSex.Margin = new System.Windows.Forms.Padding(2);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(150, 21);
            this.txtSex.TabIndex = 15;
            this.txtSex.Text = "Giới tính";
            this.txtSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSuaTT
            // 
            this.btnSuaTT.Location = new System.Drawing.Point(411, 108);
            this.btnSuaTT.Name = "btnSuaTT";
            this.btnSuaTT.Size = new System.Drawing.Size(171, 28);
            this.btnSuaTT.TabIndex = 11;
            this.btnSuaTT.Text = "Sửa Thông Tin";
            this.btnSuaTT.UseVisualStyleBackColor = true;
            this.btnSuaTT.Click += new System.EventHandler(this.btnSuaTT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới Tính";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(66, 104);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(215, 21);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(66, 69);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(215, 21);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtMaSo
            // 
            this.txtMaSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSo.Location = new System.Drawing.Point(66, 34);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.ReadOnly = true;
            this.txtMaSo.Size = new System.Drawing.Size(215, 21);
            this.txtMaSo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Số";
            // 
            // gbTDMK
            // 
            this.gbTDMK.Controls.Add(this.btnDoiMK);
            this.gbTDMK.Controls.Add(this.txtMKmoi2);
            this.gbTDMK.Controls.Add(this.txtMKmoi);
            this.gbTDMK.Controls.Add(this.txtMK);
            this.gbTDMK.Controls.Add(this.label8);
            this.gbTDMK.Controls.Add(this.label7);
            this.gbTDMK.Controls.Add(this.label6);
            this.gbTDMK.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTDMK.Location = new System.Drawing.Point(28, 231);
            this.gbTDMK.Name = "gbTDMK";
            this.gbTDMK.Size = new System.Drawing.Size(639, 134);
            this.gbTDMK.TabIndex = 1;
            this.gbTDMK.TabStop = false;
            this.gbTDMK.Text = "Thay Đổi Mật Khẩu";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(450, 96);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(171, 28);
            this.btnDoiMK.TabIndex = 7;
            this.btnDoiMK.Text = "Đổi Mật Khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtMKmoi2
            // 
            this.txtMKmoi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKmoi2.Location = new System.Drawing.Point(154, 95);
            this.txtMKmoi2.Name = "txtMKmoi2";
            this.txtMKmoi2.Size = new System.Drawing.Size(276, 21);
            this.txtMKmoi2.TabIndex = 6;
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKmoi.Location = new System.Drawing.Point(154, 61);
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.Size = new System.Drawing.Size(276, 21);
            this.txtMKmoi.TabIndex = 5;
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(154, 27);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(276, 21);
            this.txtMK.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Xác Nhận Mật Khẩu Mới";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mật Khẩu Mới";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mật Khẩu Hiện Tại";
            // 
            // btnThi
            // 
            this.btnThi.BackColor = System.Drawing.Color.Red;
            this.btnThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThi.ForeColor = System.Drawing.Color.Black;
            this.btnThi.Location = new System.Drawing.Point(288, 402);
            this.btnThi.Margin = new System.Windows.Forms.Padding(2);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(211, 30);
            this.btnThi.TabIndex = 2;
            this.btnThi.Text = "THI SÁT HẠCH A1";
            this.btnThi.UseVisualStyleBackColor = false;
            this.btnThi.Click += new System.EventHandler(this.btnThi_Click);
            // 
            // btnDX
            // 
            this.btnDX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDX.ForeColor = System.Drawing.Color.White;
            this.btnDX.Location = new System.Drawing.Point(539, 400);
            this.btnDX.Margin = new System.Windows.Forms.Padding(2);
            this.btnDX.Name = "btnDX";
            this.btnDX.Size = new System.Drawing.Size(128, 32);
            this.btnDX.TabIndex = 3;
            this.btnDX.Text = "ĐĂNG XUẤT";
            this.btnDX.UseVisualStyleBackColor = false;
            this.btnDX.Click += new System.EventHandler(this.btnDX_Click);
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(686, 22);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.Size = new System.Drawing.Size(509, 410);
            this.dgvHistory.TabIndex = 4;
            // 
            // frmInformationOfUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 453);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.btnDX);
            this.Controls.Add(this.btnThi);
            this.Controls.Add(this.gbTDMK);
            this.Controls.Add(this.gbTT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInformationOfUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN NGƯỜI LUYỆN  THI";
            this.Load += new System.EventHandler(this.frmThongtinDuThi_Load);
            this.gbTT.ResumeLayout(false);
            this.gbTT.PerformLayout();
            this.gbTDMK.ResumeLayout(false);
            this.gbTDMK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuaTT;
        private System.Windows.Forms.GroupBox gbTDMK;
        private System.Windows.Forms.TextBox txtMKmoi2;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Button btnThi;
        private System.Windows.Forms.Button btnDX;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.ComboBox cbxMonth;
        private System.Windows.Forms.ComboBox cbxDay;
        private System.Windows.Forms.TextBox txtBornDate;
        private System.Windows.Forms.TextBox txtSex;
        private DataGridView dgvHistory;
    }
}