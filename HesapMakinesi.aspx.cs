using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HesapMakinesii
{
    public partial class HesapMakinesi : System.Web.UI.Page
    {
        static double sayi1, sayi2;
        static string islem;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            { TextBox1.Text = "1"; }
            else
            { TextBox1.Text = TextBox1.Text + "1"; }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            { TextBox1.Text = "2"; }
            else
            { TextBox1.Text = TextBox1.Text + "2"; }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            { TextBox1.Text = "3"; }
            else
            { TextBox1.Text = TextBox1.Text + "3"; }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            { TextBox1.Text = "4"; }
            else
            { TextBox1.Text = TextBox1.Text + "4"; }
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            { TextBox1.Text = "5"; }
            else
            { TextBox1.Text = TextBox1.Text + "5"; }
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            { TextBox1.Text = "6"; }
            else
            { TextBox1.Text = TextBox1.Text + "6"; }
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            { TextBox1.Text = "7"; }
            else
            { TextBox1.Text = TextBox1.Text + "7"; }
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            { TextBox1.Text = "8"; }
            else
            { TextBox1.Text = TextBox1.Text + "8"; }
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            { TextBox1.Text = "9"; }
            else
            { TextBox1.Text = TextBox1.Text + "9"; }
        }
        protected void Button10_Click(object sender, EventArgs e)
        { // "/" Butonu
            islem = "/";
            sayi1 = Convert.ToInt16(TextBox1.Text);
            TextBox1.Text = "";
        }
        protected void Button11_Click(object sender, EventArgs e)
        { //  "*" Butonu
            islem = "*";
            sayi1 = Convert.ToInt16(TextBox1.Text);
            TextBox1.Text = "";
        }

        protected void Button12_Click(object sender, EventArgs e)
        {//     "-" butonu
            islem = "-";
            sayi1 = Convert.ToInt16(TextBox1.Text);
            TextBox1.Text = "";
        }
        protected void Button13_Click(object sender, EventArgs e)
        {//  "+" butonu
            islem = "+";
            sayi1 = Convert.ToInt16(TextBox1.Text);
            TextBox1.Text = "";
        }
        protected void Button14_Click(object sender, EventArgs e)
        { // "=" Butonu
            sayi2 = Convert.ToInt16(TextBox1.Text);

            if (islem == "+")
                TextBox1.Text = Convert.ToString(sayi1 + sayi2);
            if (islem == "-")
                TextBox1.Text = Convert.ToString((sbyte)(sayi1 - sayi2));
            if (islem == "*")
                TextBox1.Text = Convert.ToString(sayi1 * sayi2);
            if (islem == "/")
                TextBox1.Text = Convert.ToString(sayi1 / sayi2);
        }
        protected void Button15_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            { TextBox1.Text = "0"; }
            else
            { TextBox1.Text = TextBox1.Text + "0"; }
        }
        protected void Button16_Click(object sender, EventArgs e)
        { // "C" Temizle Butonu
            TextBox1.Text = "";
            sayi1 = 0;
            sayi2 = 0;
        }
    }
}