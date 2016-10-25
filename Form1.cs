using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace n1
{
    public partial class Form1 : Form
    {
        Random tangoRand = new Random();
        //int wa,wa2;
        //string va,va2;
        string fav;
        string temp;
        //allTango为每行组成的字符串数组
        string[] allTango, favSet, tempTango;
        //tango为单行拆开后的字符串数组，重复使用
        string[] tango = new string[6];
        int tangoAmount, testAmount, right, track;
        int i, answer;
        Color dftCol = Color.FromName("control");
        Color ansCol = Color.FromName("LightGreen");
        RadioButton[] options = new RadioButton[4];


        //tangoIndex是所有元素（全部或fav）的索引
        //index是单次循环中随机提取的4个元素的索引
        int[] tangoIndex, index;
        //int[] optIndex = { 1, 2, 3, 4 };
        char[] delimLine = { '\n' };
        char[] delimField = { ',' };
        public Form1()
        {
            InitializeComponent();
            options[0] = ckA;
            options[1] = ckB;
            options[2] = ckC;
            options[3] = ckD;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            boxAmount.Enabled = false;
            ckLog.Enabled = false;
            ckFav.Enabled = false;
            ckA.Visible = true;
            ckB.Visible = true;
            ckC.Visible = true;
            ckD.Visible = true;
            btnNext.Visible = true;

            System.IO.StreamReader fileTango = new System.IO.StreamReader(@"D:\N1.txt");
            temp = fileTango.ReadToEnd();
            fileTango.Close();
            allTango = temp.Split(delimLine);
            tangoAmount = allTango.Length;

            track = 1;
            right = 0;
            stsScore.Text = "Right: " + right.ToString();

            //勾选fav，则读取fav.txt的内容（单行数字组成的逗号分隔符文件）
            //同时tangoIndex的元素就是fav的单个数字
            //默认fav中的数字总数不小于4
            if (ckFav.Checked)
            {
                System.IO.StreamReader fileFav = new System.IO.StreamReader(@"D:\fav.txt");
                fav = fileFav.ReadLine();
                favSet = fav.Split(delimField);
                fileFav.Close();
                tangoIndex = new int[favSet.Length];
                for (i = 0; i < favSet.Length; i++)
                    tangoIndex[i] = Convert.ToInt16(favSet[i]);
            }
            //不勾选fav，tangoIndex的元素就是0到allTango.Length-1的序数
            else
            {
                tangoIndex = new int[allTango.Length];
                for (i = 0; i < allTango.Length; i++)
                    tangoIndex[i] = i;
            }
            
            tangoAmount = tangoIndex.Length;

            testAmount = Convert.ToInt16(boxAmount.Text);
            txtAll.Text = testAmount.ToString();
            txtCurrent.Text = "1";
            //每次循环，从tangoIndex里面随机提取4个元素，作为索引
            //单次提取的4个元素不重复，多次循环中提取的元素允许重复
            //用tempTango代替allTango进行操作，避免allTango元素被修改
            tempTango = new string[allTango.Length];
            allTango.CopyTo(tempTango, 0);
            //tempTango = allTango;
            index = new int[4];
            for (i = 0; i < 4; i++)
            {
                index[i] = tangoRand.Next(0, tangoAmount - i);
                tango = tempTango[tangoIndex[index[i]]].Split(delimField);
                tempTango[tangoIndex[index[i]]] = tempTango[tangoIndex[tangoAmount - 1 - i]];
                options[i].Text = tango[3];
            }
            answer = tangoRand.Next(0, 4);
            txtTango.Text = allTango[tangoIndex[index[answer]]].Split(delimField)[0];
        }

        private void ckA_CheckedChanged(object sender, EventArgs e)
        {
            options[answer].BackColor = ansCol;
            ckA.Enabled = false;
            ckB.Enabled = false;
            ckC.Enabled = false;
            ckD.Enabled = false;
            if (answer == 0 && ckA.Checked)
            {
                right++;
                stsScore.Text = "Right: " + right.ToString();
            }
        }

        private void ckB_CheckedChanged(object sender, EventArgs e)
        {
            options[answer].BackColor = ansCol;
            ckA.Enabled = false;
            ckB.Enabled = false;
            ckC.Enabled = false;
            ckD.Enabled = false;
            if (answer == 1 && ckB.Checked)
            {
                right++;
                stsScore.Text = "Right: " + right.ToString();
            }
        }

        private void ckC_CheckedChanged(object sender, EventArgs e)
        {
            options[answer].BackColor = ansCol;
            ckA.Enabled = false;
            ckB.Enabled = false;
            ckC.Enabled = false;
            ckD.Enabled = false;
            if (answer == 2 && ckC.Checked)
            {
                right++;
                stsScore.Text = "Right: " + right.ToString();
            }
        }

        private void ckD_CheckedChanged(object sender, EventArgs e)
        {
            options[answer].BackColor = ansCol;
            ckA.Enabled = false;
            ckB.Enabled = false;
            ckC.Enabled = false;
            ckD.Enabled = false;
            if (answer == 3 && ckD.Checked)
            {
                right++;
                stsScore.Text = "Right: " + right.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (track < testAmount)
            {
                track++;
                txtCurrent.Text = track.ToString();

                //还原颜色
                ckA.Checked = false;
                ckB.Checked = false;
                ckC.Checked = false;
                ckD.Checked = false;
                ckA.Enabled = true;
                ckB.Enabled = true;
                ckC.Enabled = true;
                ckD.Enabled = true;
                ckA.BackColor = dftCol;
                ckB.BackColor = dftCol;
                ckC.BackColor = dftCol;
                ckD.BackColor = dftCol;

                //重置tempTango
                allTango.CopyTo(tempTango, 0);
                for (i = 0; i < 4; i++)
                {
                    index[i] = tangoRand.Next(0, tangoAmount - i);
                    tango = tempTango[tangoIndex[index[i]]].Split(delimField);
                    tempTango[tangoIndex[index[i]]] = tempTango[tangoIndex[tangoAmount - 1 - i]];
                    options[i].Text = tango[0];
                }
                answer = tangoRand.Next(0, 4);
                txtTango.Text = allTango[tangoIndex[index[answer]]].Split(delimField)[0];
            }
        }


       
    }
}
