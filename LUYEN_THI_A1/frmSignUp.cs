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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }
        public frmLogin loginForm;

        //private void btnDangki_Click(object sender, EventArgs e)
        //{
        //    frmLogin frmLogin = new frmLogin();
        //    frmLogin.Show();
        //    Hide();
        //}
        private void frmSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát đăng ký chứ?", "Thoát đăng ký?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                loginForm.Show();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
        private void btnDangki_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtUsername, "");
            errorProvider1.SetError(txtPassword, "");
            errorProvider1.SetError(txtPasswordAgain, "");
            errorProvider1.SetError(txtFullName, "");
            errorProvider1.SetError(cmbSex, "");
            errorProvider1.SetError(cbxDay, "");
            errorProvider1.SetError(cbxMonth, "");
            errorProvider1.SetError(cbxYear, "");
            errorProvider1.SetError(txtAddress, "");
            if (txtUsername.Text == "")
            {
                errorProvider1.SetError(txtUsername, "Không được bỏ trống!");
                return;
            }
            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Không được bỏ trống!");
                return;
            }
            if (txtPasswordAgain.Text == "")
            {
                errorProvider1.SetError(txtPasswordAgain, "Không được bỏ trống!");
                return;
            }
            if (txtFullName.Text == "")
            {
                errorProvider1.SetError(txtFullName, "Không được bỏ trống!");
                return;
            }
            if (cmbSex.Text == "")
            {
                errorProvider1.SetError(cmbSex, "Vui lòng chọn giới tính!");
                return;
            }
            if (cbxDay.Text == "")
            {
                errorProvider1.SetError(cbxDay, "Vui lòng chọn ngày sinh!");
                return;
            }
            if (cbxMonth.Text == "")
            {
                errorProvider1.SetError(cbxMonth, "Vui lòng chọn tháng sinh!");
                return;
            }
            if (cbxYear.Text == "")
            {
                errorProvider1.SetError(cbxYear, "Vui lòng chọn ngày sinh!");
                return;
            }
            if (InputValid())
            {
                String sql = "Select COUNT(*) from ThiSinh";
                int IDindex = Convert.ToInt32(DatabaseManager.executeQuery(sql).Rows[0][0]) + 1;    // Get numbers of ThiSinh
                string maThiSinh = "TS" + Convert.ToString(IDindex).PadLeft(3, '0');
                sql = "exec prc_DangKiTaiKhoan '" + txtUsername.Text + "','" + txtPassword.Text + "','" + maThiSinh + "',N'" + txtFullName.Text + "'," +
                  "'" + Convert.ToInt32(cbxYear.Text) + Convert.ToInt32(cbxMonth.Text).ToString().PadLeft(2, '0')
                  + Convert.ToInt32(cbxDay.Text).ToString().PadLeft(2, '0') + "', '" + (cmbSex.Text.Equals("Nam") ? "M" : "F") + "', N'" + txtAddress.Text + "'";
                DatabaseManager.executeQuery(sql);
                MessageBox.Show("Chúc mừng!!\nBạn đã đăng ký thành công!!", "Đăng ký thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult dr = MessageBox.Show("Bạn đã đăng ký thành công", "Thông báo", MessageBoxButtons.OK);
                frmLogin login = new frmLogin();
                login.Show();
                Hide();
                this.Close();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (UsernameValid())
            {
                MessageBox.Show("Bạn có thể dùng tên đăng nhập này!!", "Tên đăng nhập hơp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        bool UsernameValid()
        {
            if (!txtUsername.Text.Equals(""))
            {
                string sql = "Select Username" +
                            " from TaiKhoan" +
                            " where Username = '" + txtUsername.Text + "'";
                if (DatabaseManager.executeQuery(sql).Rows.Count == 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!!\nMời bạn nhập tên đăng nhập khác!", "Tồn tại tên đăng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!!\nMời bạn nhập tên đăng nhập!", "Lỗi nhập tên đăng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
        }

        bool PasswordValid()
        {
            if (!txtPassword.Text.Equals("") && !txtPassword.Text.Equals(txtPasswordAgain.Text))
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp\nMời bạn nhập lại mật khẩu!", "Lỗi nhập mật khẩu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        bool InputValid()
        {
            int day, month, year;
            bool isDay = !cbxDay.Text.Equals("") && int.TryParse(cbxDay.Text, out day) && day >= 1 && day <= 31;
            bool isMonth = !cbxMonth.Text.Equals("") && int.TryParse(cbxMonth.Text, out month) && month >= 1 && month <= 12;
            bool isYear = !cbxYear.Text.Equals("") && int.TryParse(cbxYear.Text, out year) && year >= 1900 && year <= DateTime.Now.Year;
            bool isSex = (!cmbSex.Text.Equals("") && (Convert.ToString(cmbSex.Text).Equals("M") || Convert.ToString(cmbSex.Text).Equals("F"))) ? true : false;
            bool isFullName = !txtFullName.Equals("");

            if (UsernameValid())
            {
                if (PasswordValid())
                {
                    if (isFullName)
                    {
                        if (isSex)
                        {
                            if (isDay)
                            {

                                if (isMonth)
                                {
                                    if (isYear)
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Lỗi năm không hợp lệ!\nMời bạn chọn lại!", "Lỗi nhập không hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Lỗi tháng không hợp lệ!\nMời bạn chọn lại!", "Lỗi nhập không hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Lỗi ngày không hợp lệ!\nMời bạn chọn lại!", "Lỗi nhập không hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lỗi giới tính không hợp lệ!\nMời bạn chọn lại!", "Lỗi nhập không hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi tên không hợp lệ!\nMời bạn nhập lại!", "Lỗi nhập không hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            return false;
        }
    }
}

