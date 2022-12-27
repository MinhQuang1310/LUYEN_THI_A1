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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        private void btnThi_Click(object sender, EventArgs e)
        {

            frmExamination examinationForm = new frmExamination();
            examinationForm.userForm = this;
            examinationForm.Show();
            this.Hide();
        }

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            frmInformationOfUser informationAndHistoryForm = new frmInformationOfUser();
            informationAndHistoryForm.userForm = this;
            informationAndHistoryForm.Show();
            this.Hide();
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình chứ?", "Thoát chương trình?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}

