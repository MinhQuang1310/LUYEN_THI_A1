using LUYEN_THI_A1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LUYEN_THI_A1
{
    public partial class frmExamination : Form
    {
        public frmUser userForm;
        public frmExamination()
        {
            InitializeComponent();
            Init();
        }
        private void changeBGImageToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Image myimage = new Bitmap(@"D:\Images\myImage1.jpg");
            this.BackgroundImage = myimage;
        }

        // Variables store data from DataBase
        Dictionary<int, string> questionFromDB = new Dictionary<int, string>();
        Dictionary<int, string> imageOfQuestionFromDB = new Dictionary<int, string>();
        Dictionary<int, List<string>> answerFromDB = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> resultOfQuestionFromDB = new Dictionary<int, List<string>>();

        // Variables to show in examination
        Dictionary<int, string> question = new Dictionary<int, string>();
        Dictionary<int, string> imageOfQuestion = new Dictionary<int, string>();
        Dictionary<int, List<string>> answer = new Dictionary<int, List<string>>();
        Dictionary<int, List<string>> resultOfQuestion = new Dictionary<int, List<string>>();

        Dictionary<int, List<string>> answerFromUser = new Dictionary<int, List<string>>();

        CheckBox[] cbxAnswer;
        Label[] lblAnswer;

        int score = 0;
        int timeCountDown = 1200;
        int maxQuestionIndex = 20;
        int questionIndex = 1;
        bool canShowResults = false;

        void Init()
        {
            cbxAnswer = new CheckBox[] { cbxAnswer1, cbxAnswer2, cbxAnswer3, cbxAnswer4 };
            lblAnswer = new Label[] { lblDapan1, lblDapan2, lblDapan3, lblDapan4 };

            GetQuestionFromDB();
            GetAnswerAndResultFromDB();
            GetRandomQuestionAndAnswerAndResult();
            ShowInformation();
            ShowQuestionAndAnswer(questionIndex);
        }

        void GetQuestionFromDB()
        {
            string sql = "Select MaCauHoi, NDCauHoi, Hinh from CauHoi";
            DataTable dataQuestion = DatabaseManager.executeQuery(sql);
            foreach (DataRow row in dataQuestion.Rows)
            {
                questionFromDB.Add(Convert.ToInt32(row["MaCauHoi"]), Convert.ToString(row["NDCauHoi"]));
                imageOfQuestionFromDB.Add(Convert.ToInt32(row["MaCauHoi"]), Convert.ToString(row["Hinh"]));
            }
        }

        void GetAnswerAndResultFromDB()
        {
            string sql = "Select MaCauHoi, NDCauTraLoi, DungSai from DapAn";
            DataTable dataAnswer = DatabaseManager.executeQuery(sql);
            foreach (DataRow row in dataAnswer.Rows)
            {
                int maCauHoi = Convert.ToInt32(row["MaCauHoi"]);
                // Get answer of question
                if (!answerFromDB.ContainsKey(maCauHoi))
                {
                    List<string> list = new List<string>();
                    answerFromDB.Add(maCauHoi, list);
                }
                answerFromDB[maCauHoi].Add(Convert.ToString(row["NDCauTraLoi"]));

                // Get result of question
                if (!resultOfQuestionFromDB.ContainsKey(maCauHoi))
                {
                    List<string> list = new List<string>();
                    resultOfQuestionFromDB.Add(maCauHoi, list);
                }
                if (Convert.ToString(row["DungSai"]).Equals("True"))
                {
                    resultOfQuestionFromDB[maCauHoi].Add(Convert.ToString(row["NDCauTraLoi"]));
                }
            }
        }

        void ShowInformation()
        {
            string sql = "Select MaThiSinh, HoTenThiSinh from ThiSinh where Username = '" + DatabaseManager.username + "'";
            DataTable dataTable = DatabaseManager.executeQuery(sql);
            txtUserID.Text = Convert.ToString(dataTable.Rows[0]["MaThiSinh"]);
            txtName.Text = Convert.ToString(dataTable.Rows[0]["HoTenThiSinh"]);
        }

        void ShowQuestionAndAnswer(int questionID)
        {
            grbQuestion.Text = "CÂU HỎI " + questionIndex;
            lblQuestion.Text = question[questionID];
            if (!imageOfQuestion[questionID].Equals(""))
            {
                string Extention = ".jpg";
                string directoryName = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory + "hinhanh\\");
                picImage.Image = new Bitmap(Path.Combine(directoryName, imageOfQuestion[questionID] + Extention));
                picImage.Location = new Point(picImage.Location.X, lblQuestion.Location.Y + lblQuestion.Height + 15);
                picImage.Show();
            }
            else
            {
                picImage.Hide();
            }

            for (int i = 0; i < cbxAnswer.Length; i++)
            {
                cbxAnswer[i].Checked = false;
                if (i >= answer[questionID].Count)
                {
                    cbxAnswer[i].Hide();
                    lblAnswer[i].Hide();
                    continue;
                }
                if (answerFromUser.ContainsKey(questionID) && answerFromUser[questionID].Contains(answer[questionID][i])) { cbxAnswer[i].Checked = true; }
                cbxAnswer[i].Show();
                lblAnswer[i].Show();
                lblAnswer[i].Text = answer[questionID][i];
                Point location = new Point(lblQuestion.Location.X, (picImage.Visible) ? picImage.Location.Y + picImage.Height + i * 35 : lblQuestion.Location.Y + lblQuestion.Height + i * 70 + 20);
                lblAnswer[i].Location = new Point(location.X + 30, location.Y);
                cbxAnswer[i].Location = new Point(location.X, lblAnswer[i].Location.Y - 8);
            }

            ShowRightAndWrongAnswers(questionID);
        }

        void ShowRightAndWrongAnswers(int questionID)
        {
            if (canShowResults)
            {
                string ques = question[questionID];
                for (int i = 0; i < lblAnswer.Length; i++)
                {
                    cbxAnswer[i].Enabled = false;
                    lblAnswer[i].Enabled = false;
                    lblAnswer[i].Font = new Font("Segoe UI", 12, FontStyle.Regular);
                    lblAnswer[i].ForeColor = Color.Black;
                    if (resultOfQuestion[questionID].Contains(lblAnswer[i].Text))
                    {
                        lblAnswer[i].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                        lblAnswer[i].ForeColor = Color.Green;
                    }
                    else if (cbxAnswer[i].Checked)
                    {
                        lblAnswer[i].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                        lblAnswer[i].ForeColor = Color.Red;
                    }
                }
            }
        }

        void GetRandomQuestionAndAnswerAndResult()
        {
            bool[] chosen = new bool[151];     // Check index chosen


            string sql = "SELECT MaCauHoi FROM CauHoi WHERE MaPhan = '1'";
            DataTable dataTable = DatabaseManager.executeQuery(sql);
            // 10 Ly Thuyet questions   (Ly Thuyet: 1 - 80)
            for (int i = 1; i <= 10; i++)
            {
                int index;


                do
                {
                    index = new Random().Next(1, 81);
                } while (chosen[index]);
                chosen[index] = true;
                question.Add(i, questionFromDB[index]);
                imageOfQuestion.Add(i, imageOfQuestionFromDB[index]);
                answer.Add(i, answerFromDB[index]);
                resultOfQuestion.Add(i, resultOfQuestionFromDB[index]);
            }
            // 5 Bien Bao questions     (Bien Bao: 81 - 115)
            for (int i = 11; i <= 15; i++)
            {
                int index;
                do
                {
                    index = new Random().Next(81, 116);
                } while (chosen[index]);
                chosen[index] = true;
                question.Add(i, questionFromDB[index]);
                imageOfQuestion.Add(i, imageOfQuestionFromDB[index]);
                answer.Add(i, answerFromDB[index]);
                resultOfQuestion.Add(i, resultOfQuestionFromDB[index]);
            }

            // 5 Sa Hinh questions     (Bien Bao: 116 - 150)
            for (int i = 16; i <= 20; i++)
            {
                int index;
                do
                {
                    index = new Random().Next(116, 151);
                } while (chosen[index]);
                chosen[index] = true;
                question.Add(i, questionFromDB[index]);
                imageOfQuestion.Add(i, imageOfQuestionFromDB[index]);
                answer.Add(i, answerFromDB[index]);
                resultOfQuestion.Add(i, resultOfQuestionFromDB[index]);
            }
        }

        void cbxAnswer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbxAnswer.Length; i++)
            {
                if ((CheckBox)sender == cbxAnswer[i])
                {
                    if (cbxAnswer[i].Checked)
                    {
                        if (!answerFromUser.ContainsKey(questionIndex))
                        {
                            List<string> list = new List<string>();
                            answerFromUser.Add(questionIndex, list);
                        }
                        if (!answerFromUser[questionIndex].Contains(lblAnswer[i].Text))
                        {
                            answerFromUser[questionIndex].Add(lblAnswer[i].Text);
                        }
                    }
                    else
                    {
                        if (answerFromUser[questionIndex].Contains(lblAnswer[i].Text))
                        {
                            answerFromUser[questionIndex].Remove(lblAnswer[i].Text);
                        }
                    }
                    return;
                }
            }
        }
        void lblAnswer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lblAnswer.Length; i++)
            {
                if ((Label)sender == lblAnswer[i])
                {
                    if (cbxAnswer[i].Enabled)
                    {
                        cbxAnswer[i].Checked = !cbxAnswer[i].Checked;
                    }
                    if (cbxAnswer[i].Checked)
                    {
                        if (!answerFromUser.ContainsKey(questionIndex))
                        {
                            List<string> list = new List<string>();
                            answerFromUser.Add(questionIndex, list);
                        }
                        if (!answerFromUser[questionIndex].Contains(lblAnswer[i].Text))
                        {
                            answerFromUser[questionIndex].Add(lblAnswer[i].Text);
                        }
                    }
                    else
                    {
                        if (answerFromUser[questionIndex].Contains(lblAnswer[i].Text))
                        {
                            answerFromUser[questionIndex].Remove(lblAnswer[i].Text);
                        }
                    }
                    return;
                }
            }
        }
        private void frmThi_FormClosing(object sender, FormClosingEventArgs e)
        {

            {
                canShowResults = !canShowResults;

                if (canShowResults && answerFromUser.Count == 20)
                {
                    if (MessageBox.Show("Bạn có muốn xem đáp án của từng câu hỏi?", "Xem đáp án?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        e.Cancel = true;
                        ShowRightAndWrongAnswers(questionIndex);
                    }
                    else
                    {
                        userForm.Show();
                    }
                }
                else
                {
                    if (sender != null && MessageBox.Show("Bạn chắc chắn muốn thoát cuộc thi chứ?", "Thoát cuộc thi?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        e.Cancel = true;
                        canShowResults = true;
                    }
                    else
                    {
                        userForm.Show();
                    }
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            {
                questionIndex = Math.Max(1, --questionIndex);
                ShowQuestionAndAnswer(questionIndex);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            {
                questionIndex = Math.Min(maxQuestionIndex, ++questionIndex);
                ShowQuestionAndAnswer(questionIndex);
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeCountDown > 0)
            {
                timeCountDown--;
                TimeSpan time = TimeSpan.FromSeconds(timeCountDown);
                lblTimer.Text = time.ToString(@"mm\:ss");
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Phần thi đã hết giờ!", "Hết giờ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Submit();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (answerFromUser.Count != 20)
            {
                MessageBox.Show("Bạn còn " + (20 - answerFromUser.Count) + " chưa chọn đáp án!\nBạn hãy kiểm tra lại!", "Chưa chọn hết đáp án!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn nộp bài chứ?", "Nộp bài!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Submit();
                }
            }
        }

        void Submit()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (answerFromUser.ContainsKey(i) && answerFromUser[i].Count == resultOfQuestion[i].Count)
                {
                    bool fullAnsCorrect = true;
                    foreach (string ans in answerFromUser[i])
                    {
                        if (!resultOfQuestion[i].Contains(ans))
                        {
                            fullAnsCorrect = false;
                            break;
                        }
                    }
                    if (fullAnsCorrect) { score++; }
                }
            }

            string result = "Số điểm của bạn là: " + score + "/20\n";
            if (score >= 16)
            {
                DialogResult dr = MessageBox.Show(result + "Chúc mừng! Số điểm của bạn đã đạt yêu cầu!", "Kết quả!", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    frmInformationOfUser tt = new frmInformationOfUser();
                    tt.Show();
                    Hide();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show(result + "Rất tiếc! Số điểm bạn không đạt yêu cầu!", "Kết quả!", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    frmInformationOfUser tt = new frmInformationOfUser();
                    tt.Show();
                    Hide();
                }
            }

            // Set result of examination to history
            string sql = "Select COUNT(*) from KetQua where MaThiSinh = (Select MaThiSinh from ThiSinh where Username = '" + DatabaseManager.username + "')";
            int lanThi = Convert.ToInt32(DatabaseManager.executeQuery(sql).Rows[0][0]) + 1;

            sql = "Insert into KetQua(MaThiSinh, ThoiGian, LanThi, KetQua) values(" +
                "(select MaThiSinh from ThiSinh where Username = '" + DatabaseManager.username + "')" +
                ", CURRENT_TIMESTAMP, " + lanThi + ", '" + score.ToString().PadLeft(2, '0') + "/20')";
            DatabaseManager.executeQuery(sql);

            timer.Stop();
            this.Close();
        }
    }
}

