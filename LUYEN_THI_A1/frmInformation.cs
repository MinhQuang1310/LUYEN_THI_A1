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
    public partial class frmThongTin : Form
    {
        public frmAdmin adminForm;
        public frmThongTin()
        {
            InitializeComponent();
        }




        void ShowAllInformation()
        {
            string sql = "Select MaThiSinh AS N'Mã Thí Sinh', HoTenThiSinh AS N'Họ Tên', CONVERT(VARCHAR(10), NgaySinh, 103) AS N'Ngày Sinh', GioiTinh AS N'Giới Tính', DiaChi AS N'Địa Chỉ' from ThiSinh";
            dgvUser.DataSource = DatabaseManager.executeQuery(sql);
            dgvUser.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold);
            foreach (DataGridViewColumn column in dgvUser.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.DefaultCellStyle.Font = new Font("Segoe UI", 12.75F);
                column.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        void ShowSearchInfo()
        {
            if (txtFindUser.Text.Equals(""))
            {
                MessageBox.Show("Bạn cần nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                String sql = "prc_TimKiemThongTinThiSinh N'" + txtFindUser.Text + "'";
                DataTable dataTableInformation = DatabaseManager.executeQuery(sql);
                dgvUser.DataSource = dataTableInformation;
                if (dataTableInformation.Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy thông tin cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                else
                {
                    dgvUser.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold);
                    foreach (DataGridViewColumn column in dgvUser.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        column.DefaultCellStyle.Font = new Font("Segoe UI", 12.75F);
                        column.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }


        void ShowSearchResult()
        {
            if (txtFindKQ.Text.Equals(""))
            {
                MessageBox.Show("Bạn cần nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                String sql = "prc_TimKiemKetQua N'" + txtFindKQ.Text + "'";
                dgvLichSu.DataSource = DatabaseManager.executeQuery(sql);
                if (DatabaseManager.executeQuery(sql).Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy thông tin cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                else
                {
                    dgvLichSu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold);
                    foreach (DataGridViewColumn column in dgvLichSu.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        column.DefaultCellStyle.Font = new Font("Segoe UI", 12.75F);
                        column.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }
        void ShowAllHistory()
        {
            string sql = "Select T.MaThiSinh AS N'Mã Thí Sinh', HoTenThiSinh AS N'Họ Tên', LanThi AS N'Lần Thi', ThoiGian AS N'Thời Gian', KetQua AS N'Kết Quả'" +
                            " from KetQua K inner join ThiSinh T on K.MaThiSinh = T.MaThiSinh order by T.MaThiSinh, LanThi";
            dgvLichSu.DataSource = DatabaseManager.executeQuery(sql);

            dgvLichSu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold);
            foreach (DataGridViewColumn column in dgvLichSu.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.DefaultCellStyle.Font = new Font("Segoe UI", 12.75F);
                column.DefaultCellStyle.ForeColor = Color.Black;
            }
        }


        private void btnFindUser_Click(object sender, EventArgs e)
        {
            ShowSearchInfo();
        }

        private void btnFindKQ_Click(object sender, EventArgs e)
        {
            ShowSearchResult();
        }
        private void frmThongTin_FormClosing(object sender, FormClosingEventArgs e)
        {
            adminForm.Show();
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            ShowAllInformation();
            ShowAllHistory();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowAllHistory();
            txtFindUser.Clear();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowAllHistory();
            txtFindKQ.Clear();
        }
    }
}

