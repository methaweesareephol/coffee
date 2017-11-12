using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        string k_s = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
        public void junior(string Menu, string Bath)
        {
            string[] name = { Menu, Bath };
            var junior = new ListViewItem(name);
            listView1.Items.Add(junior);
            me();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            junior("Esspresso(HOT)", "35");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            junior("Esspresso(ICE)", "45");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            junior("Esspresso(Frappe)", "50");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            junior("Americano(HOT)", "35");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            junior("Americano(ICE)", "45");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            junior("Latte(HOT)", "35");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            junior("Latte(ICE)", "45");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            junior("Latte(Frappe)", "50");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(Payment);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            junior("Mocha(HOT)", "35");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            junior("Mocha(ICE)", "45");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            junior("Mocha(Frappe)", "50");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            junior("Capuccino(HOT)", "35");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            junior("Capuccino(ICE)", "45");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            junior("Capuccino(Frappe)", "50");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            junior("Green Tea(HOT)", "20");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            junior("Green Tea(ICE)", "25");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            junior("Green Tea(Frappe)", "30");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            junior("Thai cha(HOT)", "20");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            junior("Thai cha(ICE)", "25");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            junior("Thai cha(Frappe)", "30");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            junior("CoCoa(HOT)", "20");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            junior("CoCoa(ICE)", "25");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            junior("CoCoa(Frappe)", "30");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            junior("Milk(HOT)", "20");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            junior("Milk(ICE)", "25");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            junior("Milk(Frappe)", "30");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            junior("Milk Tea(ICE)", "25");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            junior("Milk Tea(Frappe)", "30");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            junior("Lemon Tea(ICE)", "25");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            junior("Lemon Tea(Frappe)", "30");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            junior("Milo(HOT)", "20");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            junior("Milo(ICE)", "25");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            junior("Milo(Frappe)", "30");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            junior("Nescafe(HOT)", "20");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            junior("Nescafe(ICE)", "25");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            junior("Nescafe(Frappe)", "30");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            junior("Nestea Tea(HOT)", "20");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            junior("Nestea Tea(ICE)", "25");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            junior("Nestea Tea(Frappe)", "30");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            junior("Italian Soda(ICE)", "25");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            junior("Red lime Soda(ICE)", "25");
        }

        private void button51_Click(object sender, EventArgs e)
        {
            junior("Honey lime Soda(ICE)", "25");
        }
        double price;
        public string[] me()
        {
            price = 0;
            string[] Jr = new string[listView1.Items.Count];
            int item = listView1.Items.Count;
            for(int i = 0;i < item; i++)
            {
                price += double.Parse(listView1.Items[i].SubItems[1].Text);
                Jr[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            label28.Text = price.ToString();
            return Jr;
        }
        public void ja()
        {
            string[] o = me();
            string[] h = me();
            string methawee = "Coffee_Pos" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string sareephol = "Coffe_Pos";
            sareephol += "\r\n";
            for(int i = 0; i < listView1.Items.Count; i++)
            {
                sareephol += o[i] + new string(' ', 20) + h[i] + "Bath" + "\r\n";
                     
            }
            sareephol += "\r\n";
            sareephol += "Total Price :" + label28.Text;
            System.IO.File.WriteAllText(k_s +  @"\" + methawee + ".txt", sareephol);
            textBox1.Text += sareephol + "\r\n" + "\r\n" + "\r\n" + "Save File at " + o + @"\" + k_s + ".txt";
        }
       


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ok = false;
            tabControl1.Controls.Remove(Payment);
            label28.Text = "";
            textBox1.Text = "";
        }
        bool ok = false;
        private void button44_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (ok == false)
            {
                tabControl1.TabPages.Insert(1, Payment);
                ok = true;
                tabControl1.SelectedTab = Payment;

            }
            else tabControl1.SelectedTab = Payment;

            if (listView1.Items.Count > 0)
                ja();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
