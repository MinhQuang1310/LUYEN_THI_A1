using System.Windows.Forms;

namespace LUYEN_THI_A1
{
    partial class frmAddQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddQuestions));
            this.lblThemCauHoi = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.txtCauA = new System.Windows.Forms.TextBox();
            this.txtCauB = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtCauC = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtCauD = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.cbxCauA = new System.Windows.Forms.CheckBox();
            this.cbxCauB = new System.Windows.Forms.CheckBox();
            this.cbxCauC = new System.Windows.Forms.CheckBox();
            this.cbxCauD = new System.Windows.Forms.CheckBox();
            this.btnThemCauHoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoidung = new System.Windows.Forms.TextBox();
            this.grbLoaiCauHoi = new System.Windows.Forms.GroupBox();
            this.rdoQuestionType3 = new System.Windows.Forms.RadioButton();
            this.rdoQuestionType2 = new System.Windows.Forms.RadioButton();
            this.rdoQuestionType1 = new System.Windows.Forms.RadioButton();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.grbLoaiCauHoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThemCauHoi
            // 
            this.lblThemCauHoi.AutoSize = true;
            this.lblThemCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThemCauHoi.ForeColor = System.Drawing.Color.Red;
            this.lblThemCauHoi.Location = new System.Drawing.Point(297, 7);
            this.lblThemCauHoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThemCauHoi.Name = "lblThemCauHoi";
            this.lblThemCauHoi.Size = new System.Drawing.Size(183, 26);
            this.lblThemCauHoi.TabIndex = 0;
            this.lblThemCauHoi.Text = "THÊM CÂU HỎI";
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LblA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblA.Location = new System.Drawing.Point(123, 314);
            this.LblA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(41, 13);
            this.LblA.TabIndex = 4;
            this.LblA.Text = "Câu A";
            // 
            // txtCauA
            // 
            this.txtCauA.Location = new System.Drawing.Point(191, 314);
            this.txtCauA.Margin = new System.Windows.Forms.Padding(2);
            this.txtCauA.Multiline = true;
            this.txtCauA.Name = "txtCauA";
            this.txtCauA.Size = new System.Drawing.Size(419, 29);
            this.txtCauA.TabIndex = 5;
            // 
            // txtCauB
            // 
            this.txtCauB.Location = new System.Drawing.Point(191, 362);
            this.txtCauB.Margin = new System.Windows.Forms.Padding(2);
            this.txtCauB.Multiline = true;
            this.txtCauB.Name = "txtCauB";
            this.txtCauB.Size = new System.Drawing.Size(419, 31);
            this.txtCauB.TabIndex = 7;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblB.Location = new System.Drawing.Point(123, 362);
            this.lblB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(41, 13);
            this.lblB.TabIndex = 6;
            this.lblB.Text = "Câu B";
            // 
            // txtCauC
            // 
            this.txtCauC.Location = new System.Drawing.Point(191, 411);
            this.txtCauC.Margin = new System.Windows.Forms.Padding(2);
            this.txtCauC.Multiline = true;
            this.txtCauC.Name = "txtCauC";
            this.txtCauC.Size = new System.Drawing.Size(419, 29);
            this.txtCauC.TabIndex = 9;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblC.Location = new System.Drawing.Point(123, 411);
            this.lblC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(41, 13);
            this.lblC.TabIndex = 8;
            this.lblC.Text = "Câu C";
            // 
            // txtCauD
            // 
            this.txtCauD.Location = new System.Drawing.Point(191, 459);
            this.txtCauD.Margin = new System.Windows.Forms.Padding(2);
            this.txtCauD.Multiline = true;
            this.txtCauD.Name = "txtCauD";
            this.txtCauD.Size = new System.Drawing.Size(419, 29);
            this.txtCauD.TabIndex = 11;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblD.Location = new System.Drawing.Point(123, 459);
            this.lblD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(42, 13);
            this.lblD.TabIndex = 10;
            this.lblD.Text = "Câu D";
            // 
            // cbxCauA
            // 
            this.cbxCauA.AutoSize = true;
            this.cbxCauA.Location = new System.Drawing.Point(638, 326);
            this.cbxCauA.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCauA.Name = "cbxCauA";
            this.cbxCauA.Size = new System.Drawing.Size(52, 17);
            this.cbxCauA.TabIndex = 12;
            this.cbxCauA.Text = "Đúng";
            this.cbxCauA.UseVisualStyleBackColor = true;
            // 
            // cbxCauB
            // 
            this.cbxCauB.AutoSize = true;
            this.cbxCauB.Location = new System.Drawing.Point(638, 376);
            this.cbxCauB.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCauB.Name = "cbxCauB";
            this.cbxCauB.Size = new System.Drawing.Size(52, 17);
            this.cbxCauB.TabIndex = 13;
            this.cbxCauB.Text = "Đúng";
            this.cbxCauB.UseVisualStyleBackColor = true;
            // 
            // cbxCauC
            // 
            this.cbxCauC.AutoSize = true;
            this.cbxCauC.Location = new System.Drawing.Point(638, 423);
            this.cbxCauC.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCauC.Name = "cbxCauC";
            this.cbxCauC.Size = new System.Drawing.Size(52, 17);
            this.cbxCauC.TabIndex = 14;
            this.cbxCauC.Text = "Đúng";
            this.cbxCauC.UseVisualStyleBackColor = true;
            // 
            // cbxCauD
            // 
            this.cbxCauD.AutoSize = true;
            this.cbxCauD.Location = new System.Drawing.Point(638, 472);
            this.cbxCauD.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCauD.Name = "cbxCauD";
            this.cbxCauD.Size = new System.Drawing.Size(52, 17);
            this.cbxCauD.TabIndex = 15;
            this.cbxCauD.Text = "Đúng";
            this.cbxCauD.UseVisualStyleBackColor = true;
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.BackColor = System.Drawing.Color.Red;
            this.btnThemCauHoi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCauHoi.ForeColor = System.Drawing.Color.Black;
            this.btnThemCauHoi.Location = new System.Drawing.Point(584, 508);
            this.btnThemCauHoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemCauHoi.Name = "btnThemCauHoi";
            this.btnThemCauHoi.Size = new System.Drawing.Size(106, 45);
            this.btnThemCauHoi.TabIndex = 16;
            this.btnThemCauHoi.Text = "Thêm";
            this.btnThemCauHoi.UseVisualStyleBackColor = false;
            this.btnThemCauHoi.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(52, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nội dung";
            // 
            // txtNoidung
            // 
            this.txtNoidung.Location = new System.Drawing.Point(134, 251);
            this.txtNoidung.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoidung.Multiline = true;
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(558, 40);
            this.txtNoidung.TabIndex = 18;
            // 
            // grbLoaiCauHoi
            // 
            this.grbLoaiCauHoi.Controls.Add(this.rdoQuestionType3);
            this.grbLoaiCauHoi.Controls.Add(this.rdoQuestionType2);
            this.grbLoaiCauHoi.Controls.Add(this.rdoQuestionType1);
            this.grbLoaiCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLoaiCauHoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbLoaiCauHoi.Location = new System.Drawing.Point(43, 46);
            this.grbLoaiCauHoi.Name = "grbLoaiCauHoi";
            this.grbLoaiCauHoi.Size = new System.Drawing.Size(258, 176);
            this.grbLoaiCauHoi.TabIndex = 22;
            this.grbLoaiCauHoi.TabStop = false;
            this.grbLoaiCauHoi.Text = "Loại Câu Hỏi";
            // 
            // rdoQuestionType3
            // 
            this.rdoQuestionType3.AutoSize = true;
            this.rdoQuestionType3.Location = new System.Drawing.Point(46, 128);
            this.rdoQuestionType3.Name = "rdoQuestionType3";
            this.rdoQuestionType3.Size = new System.Drawing.Size(84, 24);
            this.rdoQuestionType3.TabIndex = 0;
            this.rdoQuestionType3.TabStop = true;
            this.rdoQuestionType3.Text = "Sa Hình";
            this.rdoQuestionType3.UseVisualStyleBackColor = true;
            // 
            // rdoQuestionType2
            // 
            this.rdoQuestionType2.AutoSize = true;
            this.rdoQuestionType2.Location = new System.Drawing.Point(46, 81);
            this.rdoQuestionType2.Name = "rdoQuestionType2";
            this.rdoQuestionType2.Size = new System.Drawing.Size(90, 24);
            this.rdoQuestionType2.TabIndex = 0;
            this.rdoQuestionType2.TabStop = true;
            this.rdoQuestionType2.Text = "Biển báo";
            this.rdoQuestionType2.UseVisualStyleBackColor = true;
            // 
            // rdoQuestionType1
            // 
            this.rdoQuestionType1.AutoSize = true;
            this.rdoQuestionType1.Location = new System.Drawing.Point(46, 38);
            this.rdoQuestionType1.Name = "rdoQuestionType1";
            this.rdoQuestionType1.Size = new System.Drawing.Size(177, 24);
            this.rdoQuestionType1.TabIndex = 0;
            this.rdoQuestionType1.TabStop = true;
            this.rdoQuestionType1.Text = "Giao thông đường bộ";
            this.rdoQuestionType1.UseVisualStyleBackColor = true;
            // 
            // picExit
            // 
            this.picExit.Image = global::LUYEN_THI_A1.Properties.Resources.OIP__4_;
            this.picExit.InitialImage = null;
            this.picExit.Location = new System.Drawing.Point(707, 508);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(49, 45);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 24;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // picImage
            // 
            this.picImage.Image = global::LUYEN_THI_A1.Properties.Resources.OIP__3_;
            this.picImage.Location = new System.Drawing.Point(480, 84);
            this.picImage.Margin = new System.Windows.Forms.Padding(2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(91, 95);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // frmAddQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 564);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.grbLoaiCauHoi);
            this.Controls.Add(this.txtNoidung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemCauHoi);
            this.Controls.Add(this.cbxCauD);
            this.Controls.Add(this.cbxCauC);
            this.Controls.Add(this.cbxCauB);
            this.Controls.Add(this.cbxCauA);
            this.Controls.Add(this.txtCauD);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.txtCauC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtCauB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtCauA);
            this.Controls.Add(this.LblA);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.lblThemCauHoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm câu hỏi ";
            this.grbLoaiCauHoi.ResumeLayout(false);
            this.grbLoaiCauHoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThemCauHoi;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.TextBox txtCauA;
        private System.Windows.Forms.TextBox txtCauB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtCauC;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtCauD;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.CheckBox cbxCauA;
        private System.Windows.Forms.CheckBox cbxCauB;
        private System.Windows.Forms.CheckBox cbxCauC;
        private System.Windows.Forms.CheckBox cbxCauD;
        private System.Windows.Forms.Button btnThemCauHoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoidung;
        private System.Windows.Forms.GroupBox grbLoaiCauHoi;
        private System.Windows.Forms.RadioButton rdoQuestionType3;
        private System.Windows.Forms.RadioButton rdoQuestionType2;
        private System.Windows.Forms.RadioButton rdoQuestionType1;
        private PictureBox picExit;
    }
}