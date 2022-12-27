using LUYEN_THI_A1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUYEN_THI_A1
{
    public partial class frmAdmin : Form
    {
        public frmUser userForm;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình chứ?", "Thoát chương trình?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void thêmCâuHỏiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddQuestions addQuestionForm = new frmAddQuestions();
            addQuestionForm.adminForm = this;
            addQuestionForm.Show();
            this.Hide();
        }

        private void thôngTinNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTin allInformationForm = new frmThongTin();
            allInformationForm.adminForm = this;
            allInformationForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            Hide();
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            string sql = "Select * from NhanVien";
            DataTable dt = DatabaseManager.executeQuery(sql);
            txtMaNV.Text = dt.Rows[0]["MANV"].ToString();
            txtTen.Text = dt.Rows[0]["Hoten"].ToString();
            txtGioiTinh.Text = dt.Rows[0]["GioiTinh"].ToString().Equals("M  ") ? "Nam" : "Nữ";
            txtNgaySinh.Text = dt.Rows[0]["NgaySinh"].ToString();
            txtPhong.Text = dt.Rows[0]["Phong"].ToString();
            txtChucVu.Text = dt.Rows[0]["ChucVu"].ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            Hide();
        }

        private void sữaCâuHỏiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddQuestions them = new frmAddQuestions();
            them.Show();
            Hide();
        }

        private void sữaThôngTinThíSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
