using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_pos_603410221_6
{
    public partial class Form1 : Form
    {
        String wa = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }
        public void Siri(String Menu, String Baht)
        {
            String[] Suay = { Menu, Baht };
            var pun = new ListViewItem(Suay);
            listView1.Items.Add(pun);
            ListPrice();

        }
        double at;
        public String[] ListPrice()
        {
            at = 0;
            String[] g = new string[listView1.Items.Count];
            int fd = listView1.Items.Count;
            for (int i = 0; i < fd; i++)
            {
                at += double.Parse(listView1.Items[i].SubItems[1].Text);
                g[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            label28.Text = at.ToString();
            return g;
        }
        public String[] inListPrice()
        {
            String[] b = new string[listView1.Items.Count];
            int at = listView1.Items.Count;
            for (int i = 0; i < at; i++)
            {
                b[i] = listView1.Items[i].SubItems[1].Text.ToString();
            }
            return b;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Siri("Esspresso(Hot)", "35");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Siri("Esspresso(Ice)", "45");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Siri("GreenTea(Ice)", "25");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabPage1.Controls.Remove(pay_21);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Siri("Esspresso(Frappe)", "50");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Siri("Americano(Hot)", "35");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Siri("Americano(Ice)", "45");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Siri("Latte(hot)", "35");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Siri("Latte(Ice)", "45");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Siri("Latte(Frappe)", "50");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Siri("Mocha(hot)", "35");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Siri("Latte(Ice)", "45");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Siri("Latte(Frappe)", "50");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Siri("Cappuccino(hot)", "35");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Siri("Cappuccino(Ice)", "45");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Siri("Cappuccino(Frappe)", "50");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Siri("GreenTea(hot)", "20");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Siri("GreenTea(Frappe)", "30");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Siri("ThaiTea(hot)", "20");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Siri("ThaiTea(Ice)", "25");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Siri("ThaiTea(Frappe)", "30");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Siri("CoCoa(hot)", "20");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Siri("CoCoa(Ice)", "25");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Siri("CoCoa(Frappe)", "30");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Siri("Milk(hot)", "20");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Siri("Milk(Ice)", "25");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Siri("Milk(Frappe)", "30");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Siri("MilkTea(Ice)", "25");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Siri("MilkTea(Frappe)", "30");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Siri("LemonTea(Ice)", "25");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Siri("LemonTea(Frappe)", "30");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Siri("Milo(Hot)", "20");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Siri("Milo(Ice)", "25");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Siri("Milo(Frappe)", "30");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Siri("Nestcafe(Hot)", "20");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Siri("Nestcafe(Ice)", "25");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Siri("Nestcafe(Frappe)", "30");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Siri("NestcaTea(Hot)", "20");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Siri("NestcaTea(Ice)", "25");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Siri("NestcaTea(Frappe)", "30");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Siri("Italian Soda(Cantaloupe,Strawbery,Apple,BlueHawai)(Frappe)", "25");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Siri("Red lime Soda(Ice)", "25");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Siri("Honey lime Soda(Ice)", "25");
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //pay_21.Text = "";
            if (qa == false)
            {
                tabControl1.TabPages.Insert(1, tabPage2);
                qa = true;
                tabControl1.SelectedTab = tabPage2;
            }
            else tabControl1.SelectedTab = tabPage2;
            if (listView1.Items.Count > 0)
                Tong();
        }
        public void Tong()
        {
            String[] ds = ListPrice();
            String[] fg = inListPrice();
            String check = "Suayanyting Coffee" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            String checkbill = "Suayanyting Coffee";
            checkbill += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd//mm/yyyy") + "\r\n";
            checkbill += "Menu" + "\r\n";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                checkbill += ds[i] + new string(' ', 20) + fg[i] + "Baht" + "\r\n";
            }
            checkbill += "\r\n";
            checkbill += "Total Price :" + label28.Text;
            System.IO.File.WriteAllText(wa + @"\" + check + ".txt", checkbill);
            pay_21.Text += checkbill + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save check at" + wa + @"\" + check + ".txt";
        }
        bool qa = false;

        private void button12_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            qa = false;
            tabControl1.Controls.Remove(pay_21);
            tabPage2.Text = "";
        }
    }
}
