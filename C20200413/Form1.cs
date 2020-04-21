using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C20200413
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "098765431";
            label2.Text = "gkfddsa";
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.ForeColor = Color.SeaGreen;
            label2.BackColor = Color.FromArgb(10, 0, 140);

            int i = 1;
            for (i = 1; i <= 12; i++)
                cbx_BM.Items.Add(i);

            int y = DateTime.Today.Year;//取的今天的年
            for (i = y - 130; i <= y; i++)
                cbx_BY.Items.Add(i);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sOpt = "";

            if (textBox1.Text != "")
            {
                sOpt = "姓名:" + textBox1.Text + "\n";
                if (radioButton1.Checked == true)
                {
                    sOpt = sOpt + "性別:" + radioButton1.Text + "\n";

                }
                else if (radioButton2.Checked == true)
                {
                    sOpt += "性別:" + radioButton2.Text + "\n";
                }
                if (rdbtn_A.Checked == true)
                {
                    sOpt = sOpt + "血型:" + rdbtn_A.Text + "\n";
                }
                else if (rdbtn_O.Checked == true)
                {
                    sOpt = sOpt + "血型:" + rdbtn_O.Text + "\n";
                }
                else if (rdbtn_AB.Checked == true)
                {
                    sOpt = sOpt + "血型:" + rdbtn_AB.Text + "\n";
                }
                else if (rdbtn_B.Checked == true)
                {
                    sOpt = sOpt + "血型:" + rdbtn_B.Text + "\n";
                }

                if (ckb_F1.Checked == true || ckb_F2.Checked == true
                    || ckb_F3.Checked == true || ckb_F4.Checked == true)
                {
                    sOpt = sOpt + "興趣: ";
                    if (ckb_F1.Checked == true)
                    {
                        sOpt += ckb_F1.Text + ", ";
                    }
                    if (ckb_F2.Checked == true)
                    {
                        sOpt += ckb_F2.Text + ", ";
                    }
                    if (ckb_F3.Checked == true)
                    {
                        sOpt += ckb_F3.Text + ", ";
                    }
                    if (ckb_F4.Checked == true)
                    {
                        sOpt += ckb_F4.Text + ", ";
                    }
                    sOpt = sOpt.Substring(0, sOpt.Length - 2);
                    sOpt = sOpt + "\n";
                }
                if (!(string.IsNullOrEmpty(cbx_BY.Text)) && !(string.IsNullOrEmpty(cbx_BM.Text))
                    && !(string.IsNullOrEmpty(cbx_BD.Text)))
                {
                    sOpt = sOpt + "生日: " + cbx_BY.Text + "年 " + cbx_BM.Text + "月 " + cbx_BD.Text+"日";
                }
            }
            else
            {
                sOpt = "姓名:" + "請輸入姓名" + "\n";
            }

            label11.Text = sOpt;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            // label11.Text = "按鈕備案下";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // label11.Text = "進入按鈕範圍";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            // label11.Text = "離開按鈕範圍";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //   label11.Text = "停在按鈕範圍";
        }



        private void cbx_BD_MouseLeave(object sender, EventArgs e)
        {
            cbx_BD.Items.Clear();
        }


        private void cbx_BM_MouseDown(object sender, MouseEventArgs e)
        {
           // cbx_BD.Text = "0";
        }

        private void cbx_BD_MouseEnter(object sender, EventArgs e)
        {
            vSetDays();
        }

        private void cbx_BY_SelectedIndexChanged(object sender, EventArgs e)
        {
            vSetDays();
        }

        private void cbx_BM_SelectedIndexChanged(object sender, EventArgs e)
        {
            vSetDays();
        }

        private void cbx_BY_TextChanged(object sender, EventArgs e)
        {
            vSetDays();
        }

        private void vSetDays() {
            cbx_BD.Items.Clear();

            int iYear;
            int iMonth;
            if (string.IsNullOrEmpty(cbx_BY.Text) || string.IsNullOrEmpty(cbx_BM.Text))
            {
                iYear = 0;
                iMonth = 0;
            }
            else
            {
                iYear = int.Parse(cbx_BY.Text);//String轉數字
                iMonth = int.Parse(cbx_BM.Text);//String轉數字
            }
            if (iMonth == 1 || iMonth == 3 || iMonth == 5 || iMonth == 7 ||
                iMonth == 8 || iMonth == 10 || iMonth == 12)
            {
                int i = 1;
                for (i = 1; i <= 31; i++)
                    cbx_BD.Items.Add(i);

            }
            else if (iMonth == 4 || iMonth == 6 || iMonth == 9 ||
                iMonth == 11)
            {
                int i = 1;
                for (i = 1; i <= 30; i++)
                    cbx_BD.Items.Add(i);
            }
            else if (iMonth == 2)
            {
                if (iYear % 400 == 0 || (iYear % 4 == 0 && iYear % 100 != 0))
                {
                    int i = 1;
                    for (i = 1; i <= 29; i++)
                        cbx_BD.Items.Add(i);
                }
                else
                {
                    int i = 1;
                    for (i = 1; i <= 28; i++)
                        cbx_BD.Items.Add(i);
                }
            }
        }
    }
}
