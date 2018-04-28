using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace estate

{

    public partial class Test : Form
    {
        bool finish = false;
        List<string> salmons = new List<string>();
        int ind = -1;
        int num_q = 0;
        int count_ques = 4;
        int j = 0;
        int c = 0;
        string add_ = "";
        string[] question;
        string[] answer;
        string[] res;
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            Answer4.Visible = false;


            MessageBox.Show("Данный тест поможет Вам выбрать область в которую вы сможете переехать в связи с Вашими предпочтениями. Если не хотите проходить данный тест, то можете закрыть окно");
        }

        private void Zero()
        {
            Answer1.Checked = false;
            Answer2.Checked = false;
            Answer3.Checked = false;
            Answer4.Checked = false;
        }

        private void anotherQustion(int n_q,string[] q, string[] ans)
        {
            Lbl_question.Text = q[n_q];

            do
            {
                ind++;
                Answer1.Text = ans[ind];
                ind++;
                Answer2.Text = ans[ind];
                ind++;
                Answer3.Text = ans[ind];
                ind++;
                Answer4.Text = ans[ind];
                ind++;

                if (Answer3.Text != " ")
                {
                    Answer3.Visible = true;
                }
                else
                {
                    Answer3.Visible = false;
                }

                if (Answer4.Text != " ")
                {
                    Answer4.Visible = true;
                }
                else
                {
                    Answer4.Visible = false;
                }

            } while (ans[ind] == "/");
        }

        public static bool CheckAdd(string s, List<string> lis)
        {
            foreach (var salmon in lis)
            {
                if (salmon == s)
                {
                    return false;
                }
            }

            return true;
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            // _______________________________________В Ы Б О Р  Т Е С Т А______________________________________
            if (Answer1.Checked && num_q == 0)
            {
                c = 1;
                System.IO.StreamReader file = new System.IO.StreamReader("testlg.txt");
                string s = file.ReadToEnd();
                file.Close();
                add_ = "";
                System.IO.StreamReader file2 = new System.IO.StreamReader("answerlg.txt");
                string s2 = file2.ReadLine();

                question = s.Split('\n');
                int ind = Convert.ToInt32(s2);

                string[] pack = new string[ind];
                answer = new string[ind];
                res = new string[ind];
                int i = 0;

                while (file2.Peek() != -1)
                {
                    pack[i] = file2.ReadLine();
                    i++;
                }
                file2.Close();

                int r = 0;

                for (int n = 0; n <= pack.GetUpperBound(0); n++)
                {
                    r = pack[n].IndexOf("/");
                    answer[n] = pack[n].Substring(0, r);
                   
                    res[n] = pack[n].Substring(r + 1);
                    
                }

                Zero();

                //_______________________MEDIUM



                // _______________________________________В Ы Б О Р  К О Н Е Ц______________________________________
                
            }


            //_______________________MEDIUM

            if (Answer2.Checked && num_q == 0)
            {
                c = 2;
                System.IO.StreamReader file = new System.IO.StreamReader("testms.txt");
                string s = file.ReadToEnd();
                file.Close();
                add_ = "";
                System.IO.StreamReader file2 = new System.IO.StreamReader("answerms.txt");
                string s2 = file2.ReadLine();

                question = s.Split('\n');
                int ind = Convert.ToInt32(s2);

                string[] pack = new string[ind];
                answer = new string[ind];
                res = new string[ind];
                int i = 0;

                while (file2.Peek() != -1)
                {
                    pack[i] = file2.ReadLine();
                    i++;
                }
                file2.Close();

                int r = 0;

                for (int n = 0; n <= pack.GetUpperBound(0); n++)
                {
                    r = pack[n].IndexOf("/");
                    answer[n] = pack[n].Substring(0, r);

                    res[n] = pack[n].Substring(r + 1);

                }

                Zero();
            }

            //____________________---EASY

            if (Answer3.Checked && num_q == 0)
            {
                c = 3;
                System.IO.StreamReader file = new System.IO.StreamReader("testes.txt");
                string s = file.ReadToEnd();
                file.Close();
                add_ = "";
                System.IO.StreamReader file2 = new System.IO.StreamReader("answeres.txt");
                string s2 = file2.ReadLine();

                question = s.Split('\n');
                int ind = Convert.ToInt32(s2);

                string[] pack = new string[ind];
                answer = new string[ind];
                res = new string[ind];
                int i = 0;

                while (file2.Peek() != -1)
                {
                    pack[i] = file2.ReadLine();
                    i++;
                }
                file2.Close();

                int r = 0;

                for (int n = 0; n <= pack.GetUpperBound(0); n++)
                {
                    r = pack[n].IndexOf("/");
                    answer[n] = pack[n].Substring(0, r);

                    res[n] = pack[n].Substring(r + 1);

                }

                Zero();
            }

            if (num_q < 4 && c==1)
            {
                anotherQustion(num_q, question, answer);
                j = 15;
                if (num_q == 1)
                {
                    j = 0;
                }
                else if(num_q == 2)
                {
                    j = 5;
                }
                else if (num_q == 3)
                {
                    j = 10;
                }
                
            }

            if (num_q < 3 && c == 2)
            {
                anotherQustion(num_q, question, answer);
                
                if (num_q == 1)
                {
                    j = 0;
                }
                else if (num_q == 2)
                {
                    j = 5;
                }
                else if (num_q == 3)
                {
                    j = 10;
                }

            }

            if (num_q < 2 && c == 3)
            {
                if (num_q < 1)
                {
                    anotherQustion(num_q, question, answer);
                }

                if (num_q == 1)
                {
                    j = 0;
                }
                else if (num_q == 2)
                {
                    j = 5;
                }
                else if (num_q == 3)
                {
                    j = 10;
                }

            }

            num_q++;
            

            if (num_q > 0)
            {
                if (Answer1.Checked)
                {
                   if (CheckAdd(res[j], salmons))
                    {
                        label1.Text += res[j] + " ; ";
                        salmons.Add(res[j]);
                    }

                   
                    Zero();
                }
                else if (Answer2.Checked)
                {
                    if (CheckAdd(res[j+1], salmons))
                    {
                        label1.Text += res[j+1] + " ; ";
                        salmons.Add(res[j+1]);
                    }
                    Zero();
                }
                else if (Answer3.Checked)
                {
                    if (CheckAdd(res[j+2], salmons))
                    {
                        label1.Text += res[j+2] + " ; ";
                        salmons.Add(res[j+2]);
                    }
                    Zero();
                }
                else if (Answer4.Checked)
                {
                    if (CheckAdd(res[j+3], salmons))
                    {
                        label1.Text += res[j+3] + " ";
                        salmons.Add(res[j+3]);
                    }
                    Zero();
                }
            }

            if(num_q == 5 && c == 1)
            {
                Btn_next.Enabled = false;
                label1.Visible = true;
            }

            if (num_q == 4 && c == 2)
            {
                Btn_next.Enabled = false;
                label1.Visible = true;

            }

            if (num_q == 2 && c == 3)
            {
                Btn_next.Enabled = false;
                label1.Visible = true;

            }

        }
    }
}
