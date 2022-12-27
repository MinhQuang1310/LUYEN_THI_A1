using LUYEN_THI_A1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LUYEN_THI_A1
{
    public partial class frmInformationOfUser : Form
    {
        public frmUser userForm;
        public frmInformationOfUser()
        {
            InitializeComponent();
        }

        private void frmThongtinDuThi_Load(object sender, EventArgs e)
        {
            ShowInformation();
            ShowAllHistory();
        }
        void ShowInformation()
        {
            foreach (RadioButton rdoSex in gbTT.Controls.OfType<RadioButton>())
            {
                rdoSex.Hide();
            }
            foreach (ComboBox cbxInfor in gbTT.Controls.OfType<ComboBox>())
            {
                cbxInfor.Hide();
            }

            string sql = "Select ThiSinh.MaThiSinh, HoTenThiSinh, CONVERT(VARCHAR(10), NgaySinh, 103) AS 'NgaySinh', GioiTinh, DiaChi, KetQua.KetQua" +
                            " from ThiSinh, KetQua" +
                            " where Username = '" + DatabaseManager.username + "'";
            DataTable dataTable = DatabaseManager.executeQuery(sql);
            txtMaSo.Text = Convert.ToString(dataTable.Rows[0]["MaThiSinh"]);
            txtHoTen.Text = Convert.ToString(dataTable.Rows[0]["HoTenThiSinh"]);
            txtSex.Text = Convert.ToString(dataTable.Rows[0]["GioiTinh"]).Equals("M  ") ? "Nam" : "Nữ";
            txtBornDate.Text = Convert.ToString(dataTable.Rows[0]["NgaySinh"]);
            txtDiaChi.Text = Convert.ToString(dataTable.Rows[0]["DiaChi"]);
        }

        bool CheckDateValid()
        {
            int day, month, year;
            bool isDay, isMonth, isYear;
            isDay = int.TryParse(cbxDay.Text, out day);
            isMonth = int.TryParse(cbxMonth.Text, out month);
            isYear = int.TryParse(cbxYear.Text, out year);

            if (!isDay || day <= 0 || day > 32)
            {
                MessageBox.Show("Bạn đã nhập sai ngày sinh!\nMời bạn nhập lại!!", "Lỗi nhập ngày sinh!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!isMonth || month <= 0 || month > 12)
            {
                MessageBox.Show("Bạn đã nhập sai tháng sinh!\nMời bạn nhập lại!!", "Lỗi nhập tháng sinh!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!isYear || year <= 0)
            {
                MessageBox.Show("Bạn đã nhập sai năm sinh!\nMời bạn nhập lại!!", "Lỗi nhập năm sinh!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day > 31)
                    {
                        MessageBox.Show("Bạn đã nhập sai ngày sinh!\nMời bạn nhập lại!!", "Lỗi nhập ngày sinh!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day > 30)
                    {
                        MessageBox.Show("Bạn đã nhập sai ngày sinh!\nMời bạn nhập lại!!", "Lỗi nhập ngày sinh!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    break;
                case 2:
                    if (isLeapYear(year))
                    {
                        if (day > 29)
                        {
                            MessageBox.Show("Bạn đã nhập sai ngày sinh!\nMời bạn nhập lại!!", "Lỗi nhập ngày sinh!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    else
                    {
                        if (day > 28)
                        {
                            MessageBox.Show("Bạn đã nhập sai ngày sinh!\nMời bạn nhập lại!!", "Lỗi nhập ngày sinh!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    break;
            }

            return true;
        }

        bool isLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }

            if (year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }

            return false;
        }

        void UpdateInformation()
        {
            if (btnSuaTT.Text.Equals("SỬA THÔNG TIN"))
            {
                btnSuaTT.Text = "CẬP NHẬT THÔNG TIN";

                txtSex.Hide();
                txtBornDate.Hide();
                foreach (TextBox textbox in gbTT.Controls.OfType<TextBox>())
                {
                    if (textbox != txtMaSo)
                    {
                        textbox.ReadOnly = false;
                    }
                }
                foreach (RadioButton rdoSex in gbTT.Controls.OfType<RadioButton>())
                {
                    rdoSex.Show();
                }
                foreach (ComboBox cbxInfor in gbTT.Controls.OfType<ComboBox>())
                {
                    cbxInfor.Show();
                }

                string sql = "Select CONVERT(VARCHAR(10), NgaySinh, 103) AS 'NgaySinh', GioiTinh" +
                            " from ThiSinh" +
                            " where Username = '" + DatabaseManager.username + "'";
                DataTable data = DatabaseManager.executeQuery(sql);
                string dateBorn = data.Rows[0]["NgaySinh"].ToString();
                string sex = data.Rows[0]["GioiTinh"].ToString();


                if (sex.Equals("M"))
                {
                    rdoMale.Checked = true;
                }
                else
                {
                    rdoFemale.Checked = true;
                }
                cbxDay.Text = dateBorn.Substring(0, 2);
                cbxMonth.Text = dateBorn.Substring(3, 2);
                cbxYear.Text = dateBorn.Substring(6, 4);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thay đổi thông tin?", "Xác nhận thay đổi thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnSuaTT.Text = "SỬA THÔNG TIN";

                    txtSex.Show();
                    txtBornDate.Show();
                    foreach (TextBox textbox in gbTT.Controls.OfType<TextBox>())
                    {
                        if (textbox != txtMaSo)
                        {
                            textbox.ReadOnly = true;
                        }
                    }
                    foreach (RadioButton rdoSex in gbTT.Controls.OfType<RadioButton>())
                    {
                        rdoSex.Hide();
                    }
                    foreach (ComboBox cbxInfor in gbTT.Controls.OfType<ComboBox>())
                    {
                        cbxInfor.Hide();
                    }

                    if (CheckDateValid())
                    {
                        string sql = "prc_SuaThongTinThiSinh '" + DatabaseManager.username + "', N'" + txtHoTen.Text + "'," +
                            " '" + cbxYear.Text + cbxMonth.Text + cbxDay.Text + "', '" + (rdoMale.Checked ? "M" : "F") + "', N'" + txtDiaChi.Text + "'";
                        Console.WriteLine(sql);
                        DatabaseManager.executeQuery(sql);
                        ShowInformation();
                        MessageBox.Show("Chỉnh sửa thông tin thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        void ChangePassword()
        {
            if (!txtMK.Text.Equals(""))
            {
                if (!txtMKmoi.Text.Equals(""))
                {
                    if (!txtMKmoi2.Text.Equals(""))
                    {
                        if (txtMKmoi2.Text.Equals(txtMKmoi.Text))
                        {
                            string sql = "select * from TaiKhoan where Username='" + DatabaseManager.username + "' AND Password='" + txtMK.Text + "'";
                            if (DatabaseManager.executeQuery(sql).Rows.Count != 0)
                            {
                                if (!txtMK.Text.Equals(txtMKmoi.Text))
                                {
                                    if (MessageBox.Show("Bạn có muốn đổi mật khẩu?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        sql = "prc_SuaMatKhau '" + DatabaseManager.username + "', '" + txtMKmoi.Text + "'";
                                        DatabaseManager.executeQuery(sql);
                                        MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtMK.Clear();
                                        txtMKmoi.Clear();
                                        txtMKmoi2.Clear();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu hiện tại!", "Lỗi nhập sai!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtMKmoi.Clear();
                                    txtMKmoi2.Clear();
                                    txtMKmoi.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nhập sai mật khẩu hiện tại!\nMời bạn nhập lại!", "Lỗi nhập sai!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtMK.Clear();
                                txtMK.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Xác nhận mật khẩu và mật khẩu mới phải giống nhau!", "Lỗi nhập sai!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMKmoi2.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập xác nhận mật khẩu!", "Lỗi chưa nhập!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMKmoi2.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu mới!", "Lỗi chưa nhập!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMKmoi.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu hiện tại!", "Lỗi chưa nhập!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMK.Focus();
            }
        }


        private void frmThongtinDuThi_FormClosing(object sender, FormClosingEventArgs e)
        {
            userForm.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            UpdateInformation();
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            Hide();
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            frmExamination examinationForm = new frmExamination();
            frmUser frmUser = new frmUser();
            examinationForm.userForm = frmUser;
            examinationForm.Show();
            this.Hide();
        }
        void ShowAllHistory()
        {
            string sql = "Select T.MaThiSinh AS N'Mã Thí Sinh', HoTenThiSinh AS N'Họ Tên', LanThi AS N'Lần Thi', ThoiGian AS N'Thời Gian', KetQua AS N'Kết Quả'" +
                            " from KetQua K inner join ThiSinh T on K.MaThiSinh = T.MaThiSinh " + " where Username = '" + DatabaseManager.username + "'" +
                            " order by T.MaThiSinh, LanThi";
            dgvHistory.DataSource = DatabaseManager.executeQuery(sql);
            foreach (DataGridViewColumn column in dgvHistory.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.DefaultCellStyle.Font = new Font("Segoe UI", 12.75F);
                column.DefaultCellStyle.ForeColor = Color.Black;
            }
        }
    }
}

