using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_9
{
    public partial class 周期计算 : Form
    {

        string s_year = null, s_month = null, s_day = null;
        string now_year = null, now_month = null, now_day = null;

    public 周期计算()
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            string dt24 = dt.ToString("yyyy 年 MM 月 dd 日");
            label2.Text = "抚顺市矿务局医院妇产科    今天 : " + dt24;
        }

        int[] months = new int[13] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bottom.Enabled = false;
            switch(comboBox2.SelectedIndex)
            {
                case 0:
                    comboBox3.Items.Clear();
                    s_day = null;
                    comboBox3.Items.Add("01");
                    comboBox3.Items.Add("02");
                    comboBox3.Items.Add("03");
                    comboBox3.Items.Add("04");
                    comboBox3.Items.Add("05");
                    comboBox3.Items.Add("06");
                    comboBox3.Items.Add("07");
                    comboBox3.Items.Add("08");
                    comboBox3.Items.Add("09");
                    comboBox3.Items.Add("10");
                    comboBox3.Items.Add("11");
                    comboBox3.Items.Add("12");
                    comboBox3.Items.Add("13");
                    comboBox3.Items.Add("14");
                    comboBox3.Items.Add("15");
                    comboBox3.Items.Add("16");
                    comboBox3.Items.Add("17");
                    comboBox3.Items.Add("18");
                    comboBox3.Items.Add("19");
                    comboBox3.Items.Add("20");
                    comboBox3.Items.Add("21");
                    comboBox3.Items.Add("22");
                    comboBox3.Items.Add("23");
                    comboBox3.Items.Add("24");
                    comboBox3.Items.Add("25");
                    comboBox3.Items.Add("26");
                    comboBox3.Items.Add("27");
                    comboBox3.Items.Add("28");
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");
                    break;
                case 1:
                    string s = comboBox1.SelectedItem.ToString();
                    int year = int.Parse(s);
                    if ( (year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0) )
                    {
                        comboBox3.Items.Clear();
                        s_day = null;
                        comboBox3.Items.Add("1");
                        comboBox3.Items.Add("2");
                        comboBox3.Items.Add("3");
                        comboBox3.Items.Add("4");
                        comboBox3.Items.Add("5");
                        comboBox3.Items.Add("6");
                        comboBox3.Items.Add("7");
                        comboBox3.Items.Add("8");
                        comboBox3.Items.Add("9");
                        comboBox3.Items.Add("10");
                        comboBox3.Items.Add("11");
                        comboBox3.Items.Add("12");
                        comboBox3.Items.Add("13");
                        comboBox3.Items.Add("14");
                        comboBox3.Items.Add("15");
                        comboBox3.Items.Add("16");
                        comboBox3.Items.Add("17");
                        comboBox3.Items.Add("18");
                        comboBox3.Items.Add("19");
                        comboBox3.Items.Add("20");
                        comboBox3.Items.Add("21");
                        comboBox3.Items.Add("22");
                        comboBox3.Items.Add("23");
                        comboBox3.Items.Add("24");
                        comboBox3.Items.Add("25");
                        comboBox3.Items.Add("26");
                        comboBox3.Items.Add("27");
                        comboBox3.Items.Add("28");
                        comboBox3.Items.Add("29");
                        break;
                    }
                    else
                    {
                        comboBox3.Items.Clear();
                        s_day = null;
                        comboBox3.Items.Add("1");
                        comboBox3.Items.Add("2");
                        comboBox3.Items.Add("3");
                        comboBox3.Items.Add("4");
                        comboBox3.Items.Add("5");
                        comboBox3.Items.Add("6");
                        comboBox3.Items.Add("7");
                        comboBox3.Items.Add("8");
                        comboBox3.Items.Add("9");
                        comboBox3.Items.Add("10");
                        comboBox3.Items.Add("11");
                        comboBox3.Items.Add("12");
                        comboBox3.Items.Add("13");
                        comboBox3.Items.Add("14");
                        comboBox3.Items.Add("15");
                        comboBox3.Items.Add("16");
                        comboBox3.Items.Add("17");
                        comboBox3.Items.Add("18");
                        comboBox3.Items.Add("19");
                        comboBox3.Items.Add("20");
                        comboBox3.Items.Add("21");
                        comboBox3.Items.Add("22");
                        comboBox3.Items.Add("23");
                        comboBox3.Items.Add("24");
                        comboBox3.Items.Add("25");
                        comboBox3.Items.Add("26");
                        comboBox3.Items.Add("27");
                        comboBox3.Items.Add("28");
                        break;
                    }
                case 2:
                    comboBox3.Items.Clear();
                    s_day = null;
                    comboBox3.Items.Add("1");
                    comboBox3.Items.Add("2");
                    comboBox3.Items.Add("3");
                    comboBox3.Items.Add("4");
                    comboBox3.Items.Add("5");
                    comboBox3.Items.Add("6");
                    comboBox3.Items.Add("7");
                    comboBox3.Items.Add("8");
                    comboBox3.Items.Add("9");
                    comboBox3.Items.Add("10");
                    comboBox3.Items.Add("11");
                    comboBox3.Items.Add("12");
                    comboBox3.Items.Add("13");
                    comboBox3.Items.Add("14");
                    comboBox3.Items.Add("15");
                    comboBox3.Items.Add("16");
                    comboBox3.Items.Add("17");
                    comboBox3.Items.Add("18");
                    comboBox3.Items.Add("19");
                    comboBox3.Items.Add("20");
                    comboBox3.Items.Add("21");
                    comboBox3.Items.Add("22");
                    comboBox3.Items.Add("23");
                    comboBox3.Items.Add("24");
                    comboBox3.Items.Add("25");
                    comboBox3.Items.Add("26");
                    comboBox3.Items.Add("27");
                    comboBox3.Items.Add("28");
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");
                    break;
                case 3:
                    comboBox3.Items.Clear();
                    s_day = null;
                    comboBox3.Items.Add("1");
                    comboBox3.Items.Add("2");
                    comboBox3.Items.Add("3");
                    comboBox3.Items.Add("4");
                    comboBox3.Items.Add("5");
                    comboBox3.Items.Add("6");
                    comboBox3.Items.Add("7");
                    comboBox3.Items.Add("8");
                    comboBox3.Items.Add("9");
                    comboBox3.Items.Add("10");
                    comboBox3.Items.Add("11");
                    comboBox3.Items.Add("12");
                    comboBox3.Items.Add("13");
                    comboBox3.Items.Add("14");
                    comboBox3.Items.Add("15");
                    comboBox3.Items.Add("16");
                    comboBox3.Items.Add("17");
                    comboBox3.Items.Add("18");
                    comboBox3.Items.Add("19");
                    comboBox3.Items.Add("20");
                    comboBox3.Items.Add("21");
                    comboBox3.Items.Add("22");
                    comboBox3.Items.Add("23");
                    comboBox3.Items.Add("24");
                    comboBox3.Items.Add("25");
                    comboBox3.Items.Add("26");
                    comboBox3.Items.Add("27");
                    comboBox3.Items.Add("28");
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    break;
                case 4:
                    comboBox3.Items.Clear();
                    s_day = null;
                    comboBox3.Items.Add("1");
                    comboBox3.Items.Add("2");
                    comboBox3.Items.Add("3");
                    comboBox3.Items.Add("4");
                    comboBox3.Items.Add("5");
                    comboBox3.Items.Add("6");
                    comboBox3.Items.Add("7");
                    comboBox3.Items.Add("8");
                    comboBox3.Items.Add("9");
                    comboBox3.Items.Add("10");
                    comboBox3.Items.Add("11");
                    comboBox3.Items.Add("12");
                    comboBox3.Items.Add("13");
                    comboBox3.Items.Add("14");
                    comboBox3.Items.Add("15");
                    comboBox3.Items.Add("16");
                    comboBox3.Items.Add("17");
                    comboBox3.Items.Add("18");
                    comboBox3.Items.Add("19");
                    comboBox3.Items.Add("20");
                    comboBox3.Items.Add("21");
                    comboBox3.Items.Add("22");
                    comboBox3.Items.Add("23");
                    comboBox3.Items.Add("24");
                    comboBox3.Items.Add("25");
                    comboBox3.Items.Add("26");
                    comboBox3.Items.Add("27");
                    comboBox3.Items.Add("28");
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");
                    break;
                case 5:
                    comboBox3.Items.Clear();
                    s_day = null;
                    comboBox3.Items.Add("1");
                    comboBox3.Items.Add("2");
                    comboBox3.Items.Add("3");
                    comboBox3.Items.Add("4");
                    comboBox3.Items.Add("5");
                    comboBox3.Items.Add("6");
                    comboBox3.Items.Add("7");
                    comboBox3.Items.Add("8");
                    comboBox3.Items.Add("9");
                    comboBox3.Items.Add("10");
                    comboBox3.Items.Add("11");
                    comboBox3.Items.Add("12");
                    comboBox3.Items.Add("13");
                    comboBox3.Items.Add("14");
                    comboBox3.Items.Add("15");
                    comboBox3.Items.Add("16");
                    comboBox3.Items.Add("17");
                    comboBox3.Items.Add("18");
                    comboBox3.Items.Add("19");
                    comboBox3.Items.Add("20");
                    comboBox3.Items.Add("21");
                    comboBox3.Items.Add("22");
                    comboBox3.Items.Add("23");
                    comboBox3.Items.Add("24");
                    comboBox3.Items.Add("25");
                    comboBox3.Items.Add("26");
                    comboBox3.Items.Add("27");
                    comboBox3.Items.Add("28");
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    break;
                case 6:
                    comboBox3.Items.Clear();
                    s_day = null;
                    comboBox3.Items.Add("1");
                    comboBox3.Items.Add("2");
                    comboBox3.Items.Add("3");
                    comboBox3.Items.Add("4");
                    comboBox3.Items.Add("5");
                    comboBox3.Items.Add("6");
                    comboBox3.Items.Add("7");
                    comboBox3.Items.Add("8");
                    comboBox3.Items.Add("9");
                    comboBox3.Items.Add("10");
                    comboBox3.Items.Add("11");
                    comboBox3.Items.Add("12");
                    comboBox3.Items.Add("13");
                    comboBox3.Items.Add("14");
                    comboBox3.Items.Add("15");
                    comboBox3.Items.Add("16");
                    comboBox3.Items.Add("17");
                    comboBox3.Items.Add("18");
                    comboBox3.Items.Add("19");
                    comboBox3.Items.Add("20");
                    comboBox3.Items.Add("21");
                    comboBox3.Items.Add("22");
                    comboBox3.Items.Add("23");
                    comboBox3.Items.Add("24");
                    comboBox3.Items.Add("25");
                    comboBox3.Items.Add("26");
                    comboBox3.Items.Add("27");
                    comboBox3.Items.Add("28");
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");
                    break;
                case 7:
                    comboBox3.Items.Clear();
                    s_day = null;
                    comboBox3.Items.Add("1");
                    comboBox3.Items.Add("2");
                    comboBox3.Items.Add("3");
                    comboBox3.Items.Add("4");
                    comboBox3.Items.Add("5");
                    comboBox3.Items.Add("6");
                    comboBox3.Items.Add("7");
                    comboBox3.Items.Add("8");
                    comboBox3.Items.Add("9");
                    comboBox3.Items.Add("10");
                    comboBox3.Items.Add("11");
                    comboBox3.Items.Add("12");
                    comboBox3.Items.Add("13");
                    comboBox3.Items.Add("14");
                    comboBox3.Items.Add("15");
                    comboBox3.Items.Add("16");
                    comboBox3.Items.Add("17");
                    comboBox3.Items.Add("18");
                    comboBox3.Items.Add("19");
                    comboBox3.Items.Add("20");
                    comboBox3.Items.Add("21");
                    comboBox3.Items.Add("22");
                    comboBox3.Items.Add("23");
                    comboBox3.Items.Add("24");
                    comboBox3.Items.Add("25");
                    comboBox3.Items.Add("26");
                    comboBox3.Items.Add("27");
                    comboBox3.Items.Add("28");
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");
                    break;
                case 8:
                    comboBox3.Items.Clear();
                    s_day = null;
                    comboBox3.Items.Add("1");
                    comboBox3.Items.Add("2");
                    comboBox3.Items.Add("3");
                    comboBox3.Items.Add("4");
                    comboBox3.Items.Add("5");
                    comboBox3.Items.Add("6");
                    comboBox3.Items.Add("7");
                    comboBox3.Items.Add("8");
                    comboBox3.Items.Add("9");
                    comboBox3.Items.Add("10");
                    comboBox3.Items.Add("11");
                    comboBox3.Items.Add("12");
                    comboBox3.Items.Add("13");
                    comboBox3.Items.Add("14");
                    comboBox3.Items.Add("15");
                    comboBox3.Items.Add("16");
                    comboBox3.Items.Add("17");
                    comboBox3.Items.Add("18");
                    comboBox3.Items.Add("19");
                    comboBox3.Items.Add("20");
                    comboBox3.Items.Add("21");
                    comboBox3.Items.Add("22");
                    comboBox3.Items.Add("23");
                    comboBox3.Items.Add("24");
                    comboBox3.Items.Add("25");
                    comboBox3.Items.Add("26");
                    comboBox3.Items.Add("27");
                    comboBox3.Items.Add("28");
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    break;
                case 9:
                    comboBox3.Items.Clear();
                    s_day = null;
                    comboBox3.Items.Add("1");
                    comboBox3.Items.Add("2");
                    comboBox3.Items.Add("3");
                    comboBox3.Items.Add("4");
                    comboBox3.Items.Add("5");
                    comboBox3.Items.Add("6");
                    comboBox3.Items.Add("7");
                    comboBox3.Items.Add("8");
                    comboBox3.Items.Add("9");
                    comboBox3.Items.Add("10");
                    comboBox3.Items.Add("11");
                    comboBox3.Items.Add("12");
                    comboBox3.Items.Add("13");
                    comboBox3.Items.Add("14");
                    comboBox3.Items.Add("15");
                    comboBox3.Items.Add("16");
                    comboBox3.Items.Add("17");
                    comboBox3.Items.Add("18");
                    comboBox3.Items.Add("19");
                    comboBox3.Items.Add("20");
                    comboBox3.Items.Add("21");
                    comboBox3.Items.Add("22");
                    comboBox3.Items.Add("23");
                    comboBox3.Items.Add("24");
                    comboBox3.Items.Add("25");
                    comboBox3.Items.Add("26");
                    comboBox3.Items.Add("27");
                    comboBox3.Items.Add("28");
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");
                    break;
                case 10:
                    comboBox3.Items.Clear();
                    s_day = null;
                    comboBox3.Items.Add("1");
                    comboBox3.Items.Add("2");
                    comboBox3.Items.Add("3");
                    comboBox3.Items.Add("4");
                    comboBox3.Items.Add("5");
                    comboBox3.Items.Add("6");
                    comboBox3.Items.Add("7");
                    comboBox3.Items.Add("8");
                    comboBox3.Items.Add("9");
                    comboBox3.Items.Add("10");
                    comboBox3.Items.Add("11");
                    comboBox3.Items.Add("12");
                    comboBox3.Items.Add("13");
                    comboBox3.Items.Add("14");
                    comboBox3.Items.Add("15");
                    comboBox3.Items.Add("16");
                    comboBox3.Items.Add("17");
                    comboBox3.Items.Add("18");
                    comboBox3.Items.Add("19");
                    comboBox3.Items.Add("20");
                    comboBox3.Items.Add("21");
                    comboBox3.Items.Add("22");
                    comboBox3.Items.Add("23");
                    comboBox3.Items.Add("24");
                    comboBox3.Items.Add("25");
                    comboBox3.Items.Add("26");
                    comboBox3.Items.Add("27");
                    comboBox3.Items.Add("28");
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    break;
                case 11:
                    comboBox3.Items.Clear();
                    s_day = null;
                    comboBox3.Items.Add("1");
                    comboBox3.Items.Add("2");
                    comboBox3.Items.Add("3");
                    comboBox3.Items.Add("4");
                    comboBox3.Items.Add("5");
                    comboBox3.Items.Add("6");
                    comboBox3.Items.Add("7");
                    comboBox3.Items.Add("8");
                    comboBox3.Items.Add("9");
                    comboBox3.Items.Add("10");
                    comboBox3.Items.Add("11");
                    comboBox3.Items.Add("12");
                    comboBox3.Items.Add("13");
                    comboBox3.Items.Add("14");
                    comboBox3.Items.Add("15");
                    comboBox3.Items.Add("16");
                    comboBox3.Items.Add("17");
                    comboBox3.Items.Add("18");
                    comboBox3.Items.Add("19");
                    comboBox3.Items.Add("20");
                    comboBox3.Items.Add("21");
                    comboBox3.Items.Add("22");
                    comboBox3.Items.Add("23");
                    comboBox3.Items.Add("24");
                    comboBox3.Items.Add("25");
                    comboBox3.Items.Add("26");
                    comboBox3.Items.Add("27");
                    comboBox3.Items.Add("28");
                    comboBox3.Items.Add("29");
                    comboBox3.Items.Add("30");
                    comboBox3.Items.Add("31");
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bottom.Enabled = false;
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            lab.Text = "";
            al_day.Text = "";
            Rest_day.Text = "";
            s_day = null;
            s_month = null;
           /* switch (comboBox1.SelectedIndex)
            {
                case 0:
                    comboBox2.Items.Clear();
                    s_month = null;
                    s_day = null;
                    comboBox2.Items.Add("01");
                    comboBox2.Items.Add("02");
                    comboBox2.Items.Add("03");
                    comboBox2.Items.Add("04");
                    comboBox2.Items.Add("05");
                    comboBox2.Items.Add("06");
                    comboBox2.Items.Add("07");
                    comboBox2.Items.Add("08");
                    comboBox2.Items.Add("09");
                    comboBox2.Items.Add("10");
                    comboBox2.Items.Add("11");
                    comboBox2.Items.Add("12");
                    break;
                case 1:
                    comboBox2.Items.Clear();
                    s_month = null;
                    s_day = null;
                    comboBox2.Items.Add("01");
                    comboBox2.Items.Add("02");
                    comboBox2.Items.Add("03");
                    comboBox2.Items.Add("04");
                    comboBox2.Items.Add("05");
                    comboBox2.Items.Add("06");
                    comboBox2.Items.Add("07");
                    comboBox2.Items.Add("08");
                    comboBox2.Items.Add("09");
                    comboBox2.Items.Add("10");
                    comboBox2.Items.Add("11");
                    comboBox2.Items.Add("12");
                    break;
                case 2:
                    comboBox2.Items.Clear();
                    s_month = null;
                    s_day = null;
                    comboBox2.Items.Add("01");
                    comboBox2.Items.Add("02");
                    comboBox2.Items.Add("03");
                    comboBox2.Items.Add("04");
                    comboBox2.Items.Add("05");
                    comboBox2.Items.Add("06");
                    comboBox2.Items.Add("07");
                    comboBox2.Items.Add("08");
                    comboBox2.Items.Add("09");
                    comboBox2.Items.Add("10");
                    comboBox2.Items.Add("11");
                    comboBox2.Items.Add("12");
                    break;
                case 3:
                    comboBox2.Items.Clear();
                    s_month = null;
                    s_day = null;
                    comboBox2.Items.Add("01");
                    comboBox2.Items.Add("02");
                    comboBox2.Items.Add("03");
                    comboBox2.Items.Add("04");
                    comboBox2.Items.Add("05");
                    comboBox2.Items.Add("06");
                    comboBox2.Items.Add("07");
                    comboBox2.Items.Add("08");
                    comboBox2.Items.Add("09");
                    comboBox2.Items.Add("10");
                    comboBox2.Items.Add("11");
                    comboBox2.Items.Add("12");
                    break;
                case 4:
                    comboBox2.Items.Clear();
                    s_month = null;
                    s_day = null;
                    comboBox2.Items.Add("01");
                    comboBox2.Items.Add("02");
                    comboBox2.Items.Add("03");
                    comboBox2.Items.Add("04");
                    comboBox2.Items.Add("05");
                    comboBox2.Items.Add("06");
                    comboBox2.Items.Add("07");
                    comboBox2.Items.Add("08");
                    comboBox2.Items.Add("09");
                    comboBox2.Items.Add("10");
                    comboBox2.Items.Add("11");
                    comboBox2.Items.Add("12");
                    break;
            }*/
            if (comboBox1.SelectedIndex != -1)
            {
                comboBox2.Items.Clear();
                s_month = null;
                s_day = null;
                comboBox2.Items.Add("01");
                comboBox2.Items.Add("02");
                comboBox2.Items.Add("03");
                comboBox2.Items.Add("04");
                comboBox2.Items.Add("05");
                comboBox2.Items.Add("06");
                comboBox2.Items.Add("07");
                comboBox2.Items.Add("08");
                comboBox2.Items.Add("09");
                comboBox2.Items.Add("10");
                comboBox2.Items.Add("11");
                comboBox2.Items.Add("12");
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bottom.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_StyleChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bottom_Click(object sender, EventArgs e)
        {
            solve();
            solve_1();
            string ans = "预产期 : " + s_year + " 年 " + s_month + " 月 " + s_day + " 日 ";
            this.lab.Text = ans;
            s_year = null;
            s_month = null;
            s_day = null;
        }

        private void solve()
        {
           // int[] months = new int[13] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


            if (this.comboBox1.SelectedItem.ToString() != null)
            {
                s_year = this.comboBox1.SelectedItem.ToString();
            }


            if (this.comboBox2.SelectedItem.ToString() != null)
            {
                s_month = this.comboBox2.SelectedItem.ToString();
            }


            if (this.comboBox3.SelectedItem.ToString() != null)
            {
                s_day = this.comboBox3.SelectedItem.ToString();
            }

            int i_year = int.Parse(s_year);
            int i_month = int.Parse(s_month);
            int i_day = int.Parse(s_day);

          /*  if ((i_month + 9) > 12)
            {
                i_month -= 3;
                i_year++;
            }
            else
            {
                i_month += 9;
            }


            if ((i_day + 7) > months[i_month])
            {
                i_day = (i_day + 7 - months[i_month]);
                i_month++;
            }
            else
            {
                i_day += 7;
            }


            if (i_month > 12)
            {
                i_year++;
                i_month -= 12;
            }*/



            s_year = i_year.ToString();
            s_month = i_month.ToString();
            s_day = i_day.ToString();
        }

        private void solve_1() // 算目前已经多少天了，外加产期！
        {
            DateTime dt = DateTime.Now;
            now_year = dt.ToString("yyyy");
            now_month = dt.ToString("MM");
            now_day = dt.ToString("dd");
            int now_year_1nt = int.Parse(now_year);
            int now_month_1nt = int.Parse(now_month);
            int now_day_1nt = int.Parse(now_day);

            int i_year = int.Parse(s_year);
            int i_month = int.Parse(s_month);
            int i_day = int.Parse(s_day);

            int temp_month;

            int have_day = 0;


            if (i_year < now_year_1nt)
            {
                temp_month = (12 - i_month) + now_month_1nt - 1;
            }
            else
            {
                temp_month = now_month_1nt - i_month - 1;
            }


            for (int i = 1; i <= temp_month; ++i)
            {
                if (i_month + i <= 12)
                {
                    have_day += months[i_month + i];
                }
                else
                {
                    have_day += months[i_month + i - 12];
                }
            }
            // have_day!!
            if (temp_month < 0) // 取中间月份！ 俩月是一个月
            {
                have_day = now_day_1nt - i_day;
            }
            else if (temp_month == 0) // 两个月挨着
            {
                have_day = (months[i_month] - i_day  + now_day_1nt);
            }
            else // 俩月不挨着
            {
                have_day += (months[i_month] - i_day + now_day_1nt);
            }

            int have_week = have_day / 7;

            int have_o_day = have_day % 7;

            string h_day = have_day.ToString();

            string h_week = have_week.ToString();

            string h_o_day = have_o_day.ToString();

            al_day.Text = "恭喜！ 您已怀孕 " + h_day + " 天 （" + h_week + " 周 + " + h_o_day + " 天)";// 已经怀了多久

            int next_day = (280 - have_day);

            string rest_day = next_day.ToString();

            Rest_day.Text = "距离预产期 : " + rest_day + " 天";

            int month_num = 0; // 往后的月份，计数！

            next_day -= (months[now_month_1nt] - now_day_1nt); // 把当前月已经过得天数减掉

            int ii = (now_month_1nt + 1) > 12 ? 1 : now_month_1nt + 1;

            for (; next_day - months[ii] > 0; ii = (ii + 1) > 12 ? 1 : (ii + 1))
            {
                ++month_num;
                next_day -= months[ii];
            }

            /*  if(now_month_1nt + month_num > 12)
              {
                  ++i_year;
                  now_month_1nt = (now_month_1nt + month_num - 12);
              }
              else
              {
                  now_month_1nt += month_num;
              }*/

            now_month_1nt += month_num;

            ++now_month_1nt;

            if (now_month_1nt > 12) ++i_year;

            now_month_1nt = now_month_1nt > 12 ? now_month_1nt - 12 : now_month_1nt;

            i_month = now_month_1nt;

            i_day = next_day;

            s_year = i_year.ToString();
            s_month = i_month.ToString();
            s_day = i_day.ToString();

            string[] s = new string[41];

            s[1] = "怀孕第一周是从末次月经的第一天算起，因此本周你处在月经期内.";
            s[2] = "现在，你的月经期已经结束，根据基础体温你会发现已经进入排卵期。";
            s[3] = "此时胎儿长约 0.1cm 长，体重非常轻。";
            s[4] = "受精卵刚完成着床，羊膜腔才形成。现在的胎儿很不起眼，胎长约 0.2cm，很小又很柔软。";
            s[5] = "此时，胎儿长到0.4cm，看起来更像一只小海马。本周胎儿正式进入胚胎期。";
            s[6] = "在本周开始，胎儿的头部、脑泡、额面器官、呼吸、消化、神经等器官开始分化。";
            s[7] = "怀孕 7 周，胎儿在这周的发育情况迅猛喜人。此时胎儿长到约 1cm，胎重约 4g，已具有人的雏形，体节已全部分化，可以区分出头、身、手脚的形态。";
            s[8] = "胎儿现在约为 1.2cm，胎重约 6g。此时胎形已定，可以分出胎头、体及四肢，胎头大于躯干。";
            s[9] = "本周，胎儿长度约2cm，差不多和一颗葡萄一样重，他的重量还很轻。";
            s[10] = "胎儿的身长大约有4cm，体重13g左右。身体所有的部分都已经初具规模，各器官均已形成。";
            s[11] = "本周，胎宝宝的生长速度加快，身长达到约 6cm，体重达到 19g，胎儿的骨骼细胞发育加快，肢体慢慢变长，逐渐出现钙盐的沉积，骨骼变硬。";
            s[12] = "本周，胎宝宝身长大约有 9cm，胎重 23g。胎儿维持生命的器官已经开始工作，如肝脏开始分泌胆汁，已形成完整的肺，甲状腺和胰岛线已完全形成，肝脏开始制造血细胞，肾脏分泌尿液到膀胱。";
            s[13] = "本周，胎儿胎长约 10cm，胎重达到了约 25g。双顶径的平均值为 2.52 士 0.25cm，腹围的平均值为 6.90 士 l.65cm，股骨长为 1.17 士 0.31cm。";
            s[14] = "本周，胎儿的胎长达到了约 12cm，胎重大约 28g。双顶径的平均值为 2.83 士 0.57cm，腹围的平均值为 7.77 士 1.82cm，股骨长为 1.38 士 0.48cm。";
            s[15] = "胎儿身高大概有14cm，胎重为68g。双顶径的平均值为3.23士0.51cm，腹围的平均值为9.13士1.56cm，股骨长为1.74士0.58cm。";
            s[16] = "胎儿从头到臀长约有 16cm 长，重约 110g。双顶径的平均值为 3.62 士 0.58 厘米，腹围的平均值为 10.32 士 1.92 厘米，股骨长为 2.10 士 0.51 厘米。";
            s[17] = "胎儿从头到臀长约有 18cm，重约 150-200 克。双顶径的平均值为 3.97 士 0.44cm，腹围的平均值为 11.49 士 1.62cm，股骨长为 2.52 士 0.44cm。";
            s[18] = "本周，胎儿胎长约有 20 cm，重 200 克。双顶径的平均值为 4.25 士 0.53cm，腹围的平均值为 12.41 士 l.89cm，股骨长为 2.71 士 0.46cm。";
            s[19] = "本周，胎儿从头到脚不大概有 22cm，重约 250g，的平均值为 4.52 士 0.53cm, 腹围的平均值为 13.59 士 2.30cm，股骨长为 3.03 士 0.5cm。";
            s[20] = "胎儿从头到脚长约有 25cm，重约 320g，双顶径的平均值为 4.88 士 0.58cm，腹围的平均值为 14.80 士 l.89cm，股骨长为 3.35 士 O.47cm。";
            s[21] = "胎儿从头到脚长约有 26cm，胎重约 360g。双顶径的平均值为 5.22 士 0.42cm，腹围的平均值为 15.62 士 1.84cm，股骨长为 3.64 士 0.40cm。";
            s[22] = "胎宝宝从头到脚长约有 27cm，体重约 450g。双顶径的平均值为 5.45 士 0.57cm，腹围的平均值为 16.70 士 2.23cm，股骨长为 3.82 士 0.47cm。";
            s[23] = "胎儿从头到脚长约有 28cm，重约 520g，双顶径的平均值为 5.80 士 0.44cm，腹围的平均值为 17.90 士 1.85cm，股骨长为 4.21 士 0.41cm。";
            s[24] = "胎儿身长约有 30cm，重约 630g。双顶径的平均值为 6.05 士 0.50cm，腹围的平均值为 18.74 士 2.23cm，股骨长为 4.36 士 0.51cm。";
            s[25] = "胎宝宝胎长约有约 31cm，重约 750g。双顶径的平均值为 6.39 士 0.70cm，腹围的平均值为 19.64 士 2.20cm，股骨长为 4.65 士 0.42cm";
            s[26] = "胎宝宝胎长约约 950g，胎重约 32.5cm。双顶径的平均值为 6.68 士 0.61cm，腹围的平均值为 21.62 士 2.30cm，股骨长为 4.87 士 O.41cm。";
            s[27] = "胎宝宝胎长约 34cm，胎重约 1000g。双顶径的平均值为 6.98 士 0.57cm，腹围的平均值为 21.81 士 2.12cm，股骨长为 5.10 士 0.41cm。";
            s[28] = "胎宝宝胎长约 35cm，胎重约 1150g。双顶径的平均值为 7.24 士 O.65cm，腹围的平均值为 22.86 士 2.41cm，股骨长为 5.35 士 0.55cm。";
            s[29] = "胎儿胎长约 36cm，胎重约 1300g。双顶径的平均值为 7.50 士 0.65cm，腹围的平均值为 23.71 士 1.50cm，股骨长为 5.61 士 0.44cm。";
            s[30] = "胎宝宝胎长约 37cm，胎重约 1500g。双顶径的平均值为 7.83 士 0.62cm，腹围的平均值为 24.88 士 2.03cm，股骨长为 5.77 士 0.47cm。";
            s[31] = "胎宝宝从头部到臀部长约 38.5cm，胎重约 1600g，双顶径的平均值为 8.06 士 0.60cm，腹围的平均值为 25.78 士 2.32cm，股骨长为 6.03 士 0.38cm。";
            s[32] = "胎宝宝的胎长约 40cm，胎重约 1800g。双顶径的平均值为 8.17 士 0.65cm，腹围的平均值为 26.20 士 2.33cm，股骨长为 6.43 士 0.49cm";
            s[33] = "胎儿胎长约 41.5cm，胎重 2000g。双顶径的平均值为 8.50 士 0.47cm，腹围的平均值为 27.78: 士 2.30cm，股骨长为 6.42 士 0.46cm。";
            s[34] = "胎宝宝的胎长约 43cm，胎重 2300g，双顶径的平均值为 8.61 士 0.63cm，腹围的平均值为 27.99 士 2.55cm，股骨长为 6.62 士 0.43cm。";
            s[35] = "胎宝宝一般已接近 2500g 重了，身长达到了 44cm 左右。双顶径的平均值为 8.70±0.55；腹围为 27.99±2.55，股骨长 6.62±0.43。";
            s[36] = "胎宝宝胎长约 45cm，胎重 2700g。双顶径的平均值为 8.81 士 0.57cm，腹围的平均值为 29.44 士 2.83cm，股骨长为 6.95 士 0.47cm。";
            s[37] = "胎儿胎长约 46cm，胎重 3000g。双顶径的平均值为 9.00 士 0.63cm，腹围的平均值为 30.14 士 2.17cm，股骨长为 7.10 士 0.52cm。";
            s[38] = "胎儿胎长约 47.5cm，胎重 3100g。双顶径的平均值为 9.08 士 0.59cm，腹围的平均值为 30.63 士 2.83cm，股骨长为 7.20 士 0.43cm。";
            s[39] = "胎宝宝胎长约 49cm，胎重 3300g。双顶径的平均值为 9.21 士 0.59cm，腹围的平均值为 31.34 士 3.12cm，股骨长为 7.34 士 0.53cm。";
            s[40] = "本周胎宝宝胎长约 50cm，胎重约 3500g。双顶径的平均值为 9.28 士 0.50cm，腹围的平均值为 31.49 士 2.79cm，股骨长为 7.4 士 0.53cm。";
            int temp_week;
            temp_week = (have_week + 1) > 40 ? 1 : have_week;
            label1.Text = s[temp_week + 1];
        }
    }
}
