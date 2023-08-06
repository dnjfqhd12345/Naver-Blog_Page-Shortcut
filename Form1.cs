using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == false && radioButton1.Checked == false)
            {
                MessageBox.Show("검색 단위를 먼저 선택해야 합니다!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String url = "https://blog.naver.com/PostList.naver?from=postList&blogId=";
                url += textBox1.Text;
                url += "&categoryNo=0&currentPage=";
                int num;
                if (radioButton2.Checked)
                {
                    if(textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("방문하실 블로그 아이디와 탐색할 글번호 및 페이지 번호를 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    try
                    {
                        num = 5 * Int32.Parse(textBox2.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("글번호나 페이지 번호는 숫자를 입력하셔야만 합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    num = 5 * Int32.Parse(textBox2.Text);
                    url += num.ToString();
                }
                else
                {
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("방문하실 블로그 아이디와 탐색할 글번호 및 페이지 번호를 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    try
                    {
                        num = 5 * Int32.Parse(textBox2.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("글번호나 페이지 번호는 숫자를 입력하셔야만 합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    url += textBox2.Text;
                }
                System.Diagnostics.Process.Start(url);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제작자: 전산쟁이(zzzz7037)\n블로그에 방문하시면 업데이트 소식을 받아보실 수 있습니다.","프로그램 제작자 정보",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://blog.naver.com/zzzz7037");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
