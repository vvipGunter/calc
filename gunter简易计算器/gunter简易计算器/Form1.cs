using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gunter计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double updata=0,output=0;        //临时储存值 ,输出        
        public char zh = '0';                            //定义为操作符
        public Label mylabel;
        private void AllOperator()
        {
            if (!mytextbox.Text.Contains(" ") )
            {   updata = Convert.ToDouble(mytextbox.Text);
                switch (zh)
                {
                    case '+': output += updata; break;
                    case '-': output -= updata; break;
                    case '*': output *= updata; break;
                    case '/': output /= updata; break;
                    case '0': output = updata; break;
                }
            }
            if (mytextbox.Text.Contains(" "))
            {
                mytextbox.Text = "输入错误";
            }
            if (mytextbox.Text.Contains("-"))
            {
                updata = Convert.ToDouble(mytextbox.Text);

                switch (zh)
                {
                    case '+': output = output - updata; break;
                    case '-': output = updata - output; break;
                    case '*': output *= updata; break;
                    case '/': output /= updata; break;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.Text = showNowTime();
            //textBox1.ReadOnly = true;
            Timer time = new Timer();
            time.Enabled = true;
            time.Interval = 1000;//time.Interval=1;
            time.Tick += timerCD_Tick;
        }
        private void timerCD_Tick(object sender, EventArgs e)
        {
            this.textBox1.Text = DateTime.Now.ToString("HH:mm:ss:fff");
        }
            
        private void aasdfToolStripMenuItem_Click(object sender, EventArgs e) //编辑
        {
        }
        private void button10_Click(object sender, EventArgs e) //0
        {
            if (mytextbox.Text == "0" || mytextbox.Text.Contains(" ")||mytextbox.Text=="-0") mytextbox.Text = "0";
            else mytextbox.Text += "0";
        }
        private void button1_Click(object sender, EventArgs e)//1
        {
            if (mytextbox.Text == "0"||mytextbox.Text.Contains(" ")||mytextbox.Text=="-0") mytextbox.Text = "1"; 
            else mytextbox.Text += "1";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mytextbox.Text == "0" || mytextbox.Text.Contains(" ") || mytextbox.Text == "-0") mytextbox.Text = "3";
            else mytextbox.Text += "3";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mytextbox.Text == "0" || mytextbox.Text.Contains(" ") || mytextbox.Text == "-0") mytextbox.Text = "2";
            else mytextbox.Text += "2";
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mytextbox.Text == "0" || mytextbox.Text.Contains(" ") || mytextbox.Text == "-0") mytextbox.Text = "4";
            else mytextbox.Text += "4";
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (mytextbox.Text == "0" ||mytextbox.Text.Contains(" ")) mytextbox.Text = "5";
            else mytextbox.Text += "5"; 
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (mytextbox.Text == "0" || mytextbox.Text.Contains(" ") || mytextbox.Text == "-0") mytextbox.Text = "6";
            else mytextbox.Text += "6";
            textBox1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (mytextbox.Text == "0" || mytextbox.Text.Contains(" ") || mytextbox.Text == "-0") mytextbox.Text = "7";
            else mytextbox.Text += "7";
            textBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (mytextbox.Text == "0" || mytextbox.Text.Contains(" ")) mytextbox.Text = "8";
            else mytextbox.Text += "8";
            textBox1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (mytextbox.Text == "0" || mytextbox.Text.Contains(" ") || mytextbox.Text == "-0") mytextbox.Text = "9";
            else mytextbox.Text += "9";
            textBox1.Text = "";
        }

        private void Add_Click(object sender, EventArgs e)//+
        {
            AllOperator();
            zh= '+';
            mytextbox.Text = output.ToString()+' '; 
            textBox1.Text = "";
        }

        private void jian_Click(object sender, EventArgs e)//-
        {
            AllOperator();
            zh = '-';
            mytextbox.Text = output.ToString()+' ' ; 
            textBox1.Text = "";
        }

        private void cheng_Click(object sender, EventArgs e)//*
        {
            AllOperator();
            zh = '*';
            mytextbox.Text = output.ToString()+' '; 
            textBox1.Text = "";
        }

        private void chu_Click(object sender, EventArgs e)// /
        {
            AllOperator();
            zh = '/';
            mytextbox.Text = output.ToString()+' '; 
            textBox1.Text = "";
        }

        private void equal_Click(object sender, EventArgs e)//=
        {
              // AllOperator();
            if (!mytextbox.Text.Contains(" ")) 
                
            {
                updata = Convert.ToDouble(mytextbox.Text);
            }
            { 
                switch (zh)
                {
                    case '+': output += updata; break;
                    case '-': output -= updata; break;
                    case '*': output *= updata; break;
                    case '/': output /= updata; break;
                    //case '0': output = updata; break;
                }
            }
               mytextbox.Text = output.ToString()+' '; 
              textBox1.Text = "";
        }

        private void deleteall_Click(object sender, EventArgs e)//CE
        {
            mytextbox.Text = "0";
            zh='0';
            output = updata = 0;
            textBox1.Text = "";
        }

        private void xiaoshudian_Click(object sender, EventArgs e)//.
        {
            if (!mytextbox.Text.Contains(".")) mytextbox.Text += ".";
            else mytextbox.Text = "错误，已经包含一个点 .";

            textBox1.Text = "";
        }

        private void BackEnter_Click(object sender, EventArgs e)//backspace
        {
            if (mytextbox.Text == "0") { mytextbox.Text = "0"; output = updata = 0; }
            else if (mytextbox.Text.Length == 1) { mytextbox.Text = "0"; output = updata = 0; }
            else mytextbox.Text = mytextbox.Text.Remove(mytextbox.Text.Length - 1);
            textBox1.Text = "";
        }

        private void KaiFang_Click(object sender, EventArgs e)//开方
        {
            if (mytextbox.Text == "0") { mytextbox.Text = "0"; output = updata = 0; }
            else if (Convert.ToDouble(mytextbox.Text) < 0) mytextbox.Text = "负数不能开方";

            else 
            {
                double a = Convert.ToDouble(mytextbox.Text);
                double temp=Math.Sqrt(a);
                mytextbox.Text=temp.ToString();
            }
            textBox1.Text = "";

        }

        private void PingFang_Click(object sender, EventArgs e)//平方
        {
            if (mytextbox.Text == "0") { mytextbox.Text = "0"; output = updata = 0; }
            else
            {
                double b = Convert.ToDouble(mytextbox.Text);
                mytextbox.Text = Convert.ToString(b * b);
            }
            textBox1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "我的母校";
            textBox1.Text = "";
            
        }

        private void button11_Click(object sender, EventArgs e)//sin
        {
            double temp = Convert.ToDouble(mytextbox.Text);
            mytextbox.Text=Math.Sin(temp).ToString();
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)//cos
        {
            double temp = Convert.ToDouble(mytextbox.Text);
            mytextbox.Text = Math.Cos(temp).ToString();
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)//tan
        {
            double temp = Convert.ToDouble(mytextbox.Text);
            mytextbox.Text = Math.Tan(temp).ToString();
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)//Asin
        {
            double temp = Convert.ToDouble(mytextbox.Text);
            mytextbox.Text = Math.Asin(temp).ToString();
            textBox1.Text = "";
        }

        private void jiajianchange_Click(object sender, EventArgs e)// +/-
        {
            if (mytextbox.Text== "0") mytextbox.Text = "0";
            if (mytextbox.Text.Contains("-"))
            {
                double aa = Convert.ToDouble(mytextbox.Text);

                mytextbox.Text = Convert.ToString(Math.Abs(aa));
            }
            else mytextbox.Text = "-" + mytextbox.Text;

            textBox1.Text = "";
        }

        private void Spare_Click(object sender, EventArgs e)//求圆面积
        {   
            double mm = Convert.ToDouble(mytextbox.Text);
            if (mm >= 0)
            {
                double BA = Math.PI * mm * mm;
                mytextbox.Text = "圆的面积" + BA.ToString();
            }
            else
            {
                double BA = Math.PI * Math.Abs(mm )* Math.Abs(mm);
                mytextbox.Text = "圆的面积" + BA.ToString();
            }

        }
        private void QiuTiJi_Click(object sender, EventArgs e)//求圆的体积
        {
            if (Convert.ToDouble(mytextbox.Text) >= 0)
            {
                double mm = Convert.ToDouble(mytextbox.Text);
                double BA = (4 * Math.PI * mm * mm * mm) / 3;
                mytextbox.Text = "圆的体积是" + BA.ToString();
                textBox1.Text = "";
            }
            else
                mytextbox.Text = "负数求体积无意义";
               
           }
        private void textBox1_TextChanged(object sender, EventArgs e) 
        {
            //textBox1.Text = showNowTime();
            //textBox1.Text = Convert.ToString(DateTime.Now.Hour) + ":" + Convert.ToString(DateTime.Now.Minute) + ":" + Convert.ToString(DateTime.Now.Second);//当前时间
        }
        //protected string showNowTime() //TODO
        //{
        //    int hour = 0;
        //    int min = 0;
        //    int sec = 0;
        //    int time = 0;
        //    string realTime = null;
        //        //还是用下面的
        //      // string hour = "";
        //    // string min = "";
        //  // string sec = "";
        ////string time="";
        //    hour = Convert.ToInt32(DateTime.Now.Hour);
        //    min = Convert.ToInt32(DateTime.Now.Minute);
        //    sec = Convert.ToInt32(DateTime.Now.Second);
        //    if (hour <= 10)
        //        hour = "0" + hour;
        //     if(0==hour)
        //         hour="00";
        //     if (min <= 10)
        //         min = "0" + min;
        //     if (sec <= 10)
        //         sec = "0" + sec;
        //     if (0 == sec)
        //         sec = "00";
        //    time = hour + ":" + min + ":" + sec;
        //    return time;
             
        //}
            //string nowtime = DateTime.Now.ToString();
            //textBox1.Text = nowtime;

             //int H;
            //    //int M;
            //    //int S;
             //;
             //DateTime.Now.Minute;
             //DateTime.Now.Second;

            //H=Convert.ToInt32();
            //M=Convert.ToInt32(aa.Minute());
            //S=Convert.ToInt32(aa.Minute());
           //Form1 AA = new Form1();
    } 
}