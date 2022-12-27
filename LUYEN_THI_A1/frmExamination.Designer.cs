using System.Windows.Forms;

namespace LUYEN_THI_A1
{
    partial class frmExamination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExamination));
            this.grbThongtin = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblMaso = new System.Windows.Forms.Label();
            this.grbQuestion = new System.Windows.Forms.GroupBox();
            this.cbxAnswer4 = new System.Windows.Forms.CheckBox();
            this.cbxAnswer3 = new System.Windows.Forms.CheckBox();
            this.cbxAnswer2 = new System.Windows.Forms.CheckBox();
            this.cbxAnswer1 = new System.Windows.Forms.CheckBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDapan4 = new System.Windows.Forms.Label();
            this.lblDapan3 = new System.Windows.Forms.Label();
            this.lblDapan2 = new System.Windows.Forms.Label();
            this.lblDapan1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.grbThongtin.SuspendLayout();
            this.grbQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongtin
            // 
            this.grbThongtin.Controls.Add(this.txtName);
            this.grbThongtin.Controls.Add(this.txtUserID);
            this.grbThongtin.Controls.Add(this.lblTimer);
            this.grbThongtin.Controls.Add(this.lblHoten);
            this.grbThongtin.Controls.Add(this.lblMaso);
            this.grbThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongtin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbThongtin.Location = new System.Drawing.Point(29, 13);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Size = new System.Drawing.Size(895, 100);
            this.grbThongtin.TabIndex = 0;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "THÔNG TIN";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(126, 68);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(203, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(126, 35);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(203, 21);
            this.txtUserID.TabIndex = 1;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(809, 49);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(66, 26);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "20:00";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblHoten.Location = new System.Drawing.Point(20, 71);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(62, 15);
            this.lblHoten.TabIndex = 0;
            this.lblHoten.Text = "Họ và Tên";
            // 
            // lblMaso
            // 
            this.lblMaso.AutoSize = true;
            this.lblMaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMaso.Location = new System.Drawing.Point(20, 38);
            this.lblMaso.Name = "lblMaso";
            this.lblMaso.Size = new System.Drawing.Size(43, 15);
            this.lblMaso.TabIndex = 0;
            this.lblMaso.Text = "Mã Số";
            // 
            // grbQuestion
            // 
            this.grbQuestion.Controls.Add(this.cbxAnswer4);
            this.grbQuestion.Controls.Add(this.cbxAnswer3);
            this.grbQuestion.Controls.Add(this.cbxAnswer2);
            this.grbQuestion.Controls.Add(this.cbxAnswer1);
            this.grbQuestion.Controls.Add(this.picImage);
            this.grbQuestion.Controls.Add(this.btnNext);
            this.grbQuestion.Controls.Add(this.btnPrevious);
            this.grbQuestion.Controls.Add(this.btnSubmit);
            this.grbQuestion.Controls.Add(this.lblDapan4);
            this.grbQuestion.Controls.Add(this.lblDapan3);
            this.grbQuestion.Controls.Add(this.lblDapan2);
            this.grbQuestion.Controls.Add(this.lblDapan1);
            this.grbQuestion.Controls.Add(this.lblQuestion);
            this.grbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbQuestion.Location = new System.Drawing.Point(29, 136);
            this.grbQuestion.Name = "grbQuestion";
            this.grbQuestion.Size = new System.Drawing.Size(895, 454);
            this.grbQuestion.TabIndex = 1;
            this.grbQuestion.TabStop = false;
            this.grbQuestion.Text = "CÂU HỎI";
            // 
            // cbxAnswer4
            // 
            this.cbxAnswer4.AutoSize = true;
            this.cbxAnswer4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAnswer4.ForeColor = System.Drawing.Color.Black;
            this.cbxAnswer4.Location = new System.Drawing.Point(23, 275);
            this.cbxAnswer4.MaximumSize = new System.Drawing.Size(755, 0);
            this.cbxAnswer4.MinimumSize = new System.Drawing.Size(0, 40);
            this.cbxAnswer4.Name = "cbxAnswer4";
            this.cbxAnswer4.Size = new System.Drawing.Size(15, 40);
            this.cbxAnswer4.TabIndex = 16;
            this.cbxAnswer4.UseVisualStyleBackColor = true;
            this.cbxAnswer4.Click += new System.EventHandler(this.cbxAnswer_Click);
            // 
            // cbxAnswer3
            // 
            this.cbxAnswer3.AutoSize = true;
            this.cbxAnswer3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAnswer3.ForeColor = System.Drawing.Color.Black;
            this.cbxAnswer3.Location = new System.Drawing.Point(23, 214);
            this.cbxAnswer3.MaximumSize = new System.Drawing.Size(755, 0);
            this.cbxAnswer3.MinimumSize = new System.Drawing.Size(0, 40);
            this.cbxAnswer3.Name = "cbxAnswer3";
            this.cbxAnswer3.Size = new System.Drawing.Size(15, 40);
            this.cbxAnswer3.TabIndex = 15;
            this.cbxAnswer3.UseVisualStyleBackColor = true;
            this.cbxAnswer3.Click += new System.EventHandler(this.cbxAnswer_Click);
            // 
            // cbxAnswer2
            // 
            this.cbxAnswer2.AutoSize = true;
            this.cbxAnswer2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAnswer2.ForeColor = System.Drawing.Color.Black;
            this.cbxAnswer2.Location = new System.Drawing.Point(23, 149);
            this.cbxAnswer2.MaximumSize = new System.Drawing.Size(755, 0);
            this.cbxAnswer2.MinimumSize = new System.Drawing.Size(0, 40);
            this.cbxAnswer2.Name = "cbxAnswer2";
            this.cbxAnswer2.Size = new System.Drawing.Size(15, 40);
            this.cbxAnswer2.TabIndex = 14;
            this.cbxAnswer2.UseVisualStyleBackColor = true;
            this.cbxAnswer2.Click += new System.EventHandler(this.cbxAnswer_Click);
            // 
            // cbxAnswer1
            // 
            this.cbxAnswer1.AutoSize = true;
            this.cbxAnswer1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAnswer1.ForeColor = System.Drawing.Color.Black;
            this.cbxAnswer1.Location = new System.Drawing.Point(23, 88);
            this.cbxAnswer1.MaximumSize = new System.Drawing.Size(755, 0);
            this.cbxAnswer1.MinimumSize = new System.Drawing.Size(0, 40);
            this.cbxAnswer1.Name = "cbxAnswer1";
            this.cbxAnswer1.Size = new System.Drawing.Size(15, 40);
            this.cbxAnswer1.TabIndex = 13;
            this.cbxAnswer1.UseVisualStyleBackColor = true;
            this.cbxAnswer1.Click += new System.EventHandler(this.cbxAnswer_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(163, 99);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(400, 200);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 12;
            this.picImage.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(623, 413);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 35);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(582, 413);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(35, 35);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(317, 408);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(165, 40);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "NỘP BÀI";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDapan4
            // 
            this.lblDapan4.AutoSize = true;
            this.lblDapan4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapan4.Location = new System.Drawing.Point(68, 285);
            this.lblDapan4.MaximumSize = new System.Drawing.Size(740, 0);
            this.lblDapan4.Name = "lblDapan4";
            this.lblDapan4.Size = new System.Drawing.Size(74, 20);
            this.lblDapan4.TabIndex = 7;
            this.lblDapan4.Text = "Đáp án 4";
            this.lblDapan4.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // lblDapan3
            // 
            this.lblDapan3.AutoSize = true;
            this.lblDapan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapan3.Location = new System.Drawing.Point(68, 224);
            this.lblDapan3.MaximumSize = new System.Drawing.Size(740, 0);
            this.lblDapan3.Name = "lblDapan3";
            this.lblDapan3.Size = new System.Drawing.Size(74, 20);
            this.lblDapan3.TabIndex = 7;
            this.lblDapan3.Text = "Đáp án 3";
            this.lblDapan3.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // lblDapan2
            // 
            this.lblDapan2.AutoSize = true;
            this.lblDapan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapan2.Location = new System.Drawing.Point(68, 159);
            this.lblDapan2.MaximumSize = new System.Drawing.Size(740, 0);
            this.lblDapan2.Name = "lblDapan2";
            this.lblDapan2.Size = new System.Drawing.Size(74, 20);
            this.lblDapan2.TabIndex = 7;
            this.lblDapan2.Text = "Đáp án 2";
            this.lblDapan2.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // lblDapan1
            // 
            this.lblDapan1.AutoSize = true;
            this.lblDapan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapan1.Location = new System.Drawing.Point(68, 98);
            this.lblDapan1.MaximumSize = new System.Drawing.Size(740, 0);
            this.lblDapan1.Name = "lblDapan1";
            this.lblDapan1.Size = new System.Drawing.Size(74, 20);
            this.lblDapan1.TabIndex = 7;
            this.lblDapan1.Text = "Đáp án 1";
            this.lblDapan1.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuestion.CausesValidation = false;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Red;
            this.lblQuestion.Location = new System.Drawing.Point(19, 40);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(760, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(85, 24);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Câu hỏi?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(950, 617);
            this.Controls.Add(this.grbQuestion);
            this.Controls.Add(this.grbThongtin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExamination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THI BẰNG LÁI XE HAI BÁNH";
            this.grbThongtin.ResumeLayout(false);
            this.grbThongtin.PerformLayout();
            this.grbQuestion.ResumeLayout(false);
            this.grbQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.GroupBox grbThongtin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label lblMaso;
        private System.Windows.Forms.GroupBox grbQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDapan4;
        private System.Windows.Forms.Label lblDapan3;
        private System.Windows.Forms.Label lblDapan2;
        private System.Windows.Forms.Label lblDapan1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.CheckBox cbxAnswer4;
        private System.Windows.Forms.CheckBox cbxAnswer3;
        private System.Windows.Forms.CheckBox cbxAnswer2;
        private System.Windows.Forms.CheckBox cbxAnswer1;
    }
}