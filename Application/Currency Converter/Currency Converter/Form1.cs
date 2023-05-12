using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Currency_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ConvertCurrency()
        {      
        }

        private void Conv_Bttn_Click(object sender, EventArgs e)
        {
            String a = textBox1.Text; 
            int i = Convert.ToInt32(a);
           //int i = int.Parse(textBox1.Text);-
            //UK - GBP £ (British Pound Sterling)
            //US - USD $ (Dollar)
            //Europe - EUR € (Euro)-
            // Conversion from GBP £ - Pound Sterling...
           
            if (comboBox1.SelectedItem == "UK - GBP £ (British Pound Sterling)" && comboBox2.SelectedItem == "UK - GBP £ (British Pound Sterling)")
            {
                double conver = i * 1;
                label2.Text = "" + i + " GBP £ - Pound Sterling = \n\t" + conver + " GBP";
            }
            if (comboBox1.SelectedItem == "UK - GBP £ (British Pound Sterling)" && comboBox2.SelectedItem == "US - USD $ (Dollar)")
            { 
                double conver = i * 1.4;
                label2.Text = ""+i+ " GBP £ - Pound Sterling = \n\t" + conver+" USD";
            }
            if (comboBox1.SelectedItem == "UK - GBP £ (British Pound Sterling)" && comboBox2.SelectedItem == "Europe - EUR € (Euro)")
            {
                double conver = i * 1.16;
                label2.Text = "" + i + " GBP £ - Pound Sterling = \n\t" + conver + " EUR";
            }

            //Conversion from NGN ₦ - Nigerian Naira...
            if (comboBox1.SelectedItem == "Nigeria - NGN ₦ (Naira)" && comboBox2.SelectedItem == "UK - GBP £ (British Pound Sterling)")
            {
                double conver = i * 0.0019;
                label2.Text = "" + i + " NGN ₦ - Nigerian Naira = \n\t" + conver + " GBP";
            }
            if (comboBox1.SelectedItem == "Nigeria - NGN ₦ (Naira)" && comboBox2.SelectedItem == "US - USD $ (Dollar)")
            {
                double conver = i * 0.0024;
                label2.Text = "" + i + " NGN ₦ - Nigerian Naira = \n\t" + conver + " USD";
            }
            if (comboBox1.SelectedItem == "Nigeria - NGN ₦ (Naira)" && comboBox2.SelectedItem == "Europe - EUR € (Euro)")
            {
                double conver = i * 0.0020;
                label2.Text = "" + i + " NGN ₦ - Nigerian Naira = \n\t" + conver + " EUR";
            }

            //Conversion from EUR € (Euro)...
            if (comboBox1.SelectedItem == "Europe - EUR € (Euro)" && comboBox2.SelectedItem == "UK - GBP £ (British Pound Sterling)")
            {
                double conver = i * 0.86;
                label2.Text = "" + i + " EUR € - Euro = \n\t" + conver + " GBP";
            }
            if (comboBox1.SelectedItem == "Europe - EUR € (Euro)" && comboBox2.SelectedItem == "US - USD $ (Dollar)")
            {
                double conver = i * 1.20;
                label2.Text = "" + i + " EUR € - Euro = \n\t" + conver + " USD";
            }
            if (comboBox1.SelectedItem == "Europe - EUR € (Euro)" && comboBox2.SelectedItem == "Europe - EUR € (Euro)")
            {
                double conver = i * 1;
                label2.Text = "" + i + " EUR € - Euro = \n\t" + conver + " EUR";
            }

            //Conversion from INR ₹ - Indian Rupee...
            if (comboBox1.SelectedItem == "India - INR ₹ (Rupee)" && comboBox2.SelectedItem == "UK - GBP £ (British Pound Sterling)")
            {
                double conver = i / 102.37;
                label2.Text = "" + i + " INR ₹ - Indian Rupee = \n\t" + conver + " GBP";
            }
            if (comboBox1.SelectedItem == "India - INR ₹ (Rupee)" && comboBox2.SelectedItem == "US - USD $ (Dollar)")
            {
                double conver = i * 0.014;
                label2.Text = "" + i + " INR ₹ - Indian Rupee = \n\t" + conver + " USD";
            }
            if (comboBox1.SelectedItem == "India - INR ₹ (Rupee)" && comboBox2.SelectedItem == "Europe - EUR € (Euro)")
            {
                double conver = i * 0.011;
                label2.Text = "" + i + " INR ₹ - Indian Rupee = \n\t" + conver + " EUR";
            }


            //Conversion from USD $ (Dollar)...
            if (comboBox1.SelectedItem == "US - USD $ (Dollar)" && comboBox2.SelectedItem == "UK - GBP £ (British Pound Sterling)")
            {
                double conver = i * 0.72;
                label2.Text = "" + i + " US - USD $ - Dollar = \n\t" + conver + " GBP";
            }
            if (comboBox1.SelectedItem == "US - USD $ (Dollar)" && comboBox2.SelectedItem == "US - USD $ (Dollar)")
            {
                double conver = i * 1;
                label2.Text = "" + i + " US - USD $ - Dollar = \n\t" + conver + " USD";
            }
            if (comboBox1.SelectedItem == "US - USD $ (Dollar)" && comboBox2.SelectedItem == "Europe - EUR € (Euro)")
            {
                double conver = i * 0.84;
                label2.Text = "" + i + " US - USD $ - Dollar = \n\t" + conver + " EUR";
            }


            //Conversion from Ghana - GHS ₵ (Cedi)...
            if (comboBox1.SelectedItem == "Ghana - GHS ₵ (Cedi)" && comboBox2.SelectedItem == "UK - GBP £ (British Pound Sterling)")
            {
                double conver = i * 0.13;
                label2.Text = "" + i + " GHS ₵ - Cedi = \n\t" + conver + " GBP";
            }
            if (comboBox1.SelectedItem == "Ghana - GHS ₵ (Cedi)" && comboBox2.SelectedItem == "US - USD $ (Dollar)")
            {
                double conver = i * 0.17;
                label2.Text = "" + i + " GHS ₵ - Cedi = \n\t" + conver + " USD";
            }
            if (comboBox1.SelectedItem == "Ghana - GHS ₵ (Cedi)" && comboBox2.SelectedItem == "Europe - EUR € (Euro)")
            {
                double conver = i * 0.15;
                label2.Text = "" + i + " GHS ₵ - Cedi = \n\t" + conver + " EUR";
            }


            //Conversion from Ghana - China - CNY ¥ (Yuan)...
            if (comboBox1.SelectedItem == "China - CNY ¥ (Yuan)" && comboBox2.SelectedItem == "UK - GBP £ (British Pound Sterling)")
            {
                double conver = i * 0.11;
                label2.Text = "" + i + " CNY ¥ - Yuan = \n\t" + conver + " GBP";
            }
            if (comboBox1.SelectedItem == "China - CNY ¥ (Yuan)" && comboBox2.SelectedItem == "US - USD $ (Dollar)")
            {
                double conver = i * 0.15;
                label2.Text = "" + i + " CNY ¥ - Yuan = \n\t" + conver + " USD";
            }
            if (comboBox1.SelectedItem == "China - CNY ¥ (Yuan)" && comboBox2.SelectedItem == "Europe - EUR € (Euro)")
            {
                double conver = i * 0.13;
                label2.Text = "" + i + " CNY ¥ - Yuan = \n\t" + conver + " EUR";
            }

            //Conversion from Iran IRR - ﷼(Rial)....
            if (comboBox1.SelectedItem == "Iran IRR - ﷼(Rial)" && comboBox2.SelectedItem == "UK - GBP £ (British Pound Sterling)")
            {
                double conver = i * 0.000017;
                label2.Text = "" + i + " IRR  ﷼ - Rial = \n\t" + conver + " GBP";
            }
            if (comboBox1.SelectedItem == "Iran IRR - ﷼(Rial)" && comboBox2.SelectedItem == "US - USD $ (Dollar)")
            {
                double conver = i * 0.000024;
                label2.Text = "" + i + " IRR  ﷼ - Rial = \n\t" + conver + " USD";
            }
            if (comboBox1.SelectedItem == "Iran IRR - ﷼(Rial)" && comboBox2.SelectedItem == "Europe - EUR € (Euro)")
            {
                double conver = i * 0.000020;
                label2.Text = "" + i + " IRR  ﷼ - Rial = \n\t" + conver + " EUR";
            }


            //Conversion from South Africa -ZAR R(Rand)....
            if (comboBox1.SelectedItem == "South Africa - ZAR R (Rand)" && comboBox2.SelectedItem == "UK - GBP £ (British Pound Sterling)")
            {
                double conver = i * 0.047;
                label2.Text = "" + i + " ZAR R - Rand = \n\t" + conver + " GBP";
            }
            if (comboBox1.SelectedItem == "South Africa - ZAR R (Rand)" && comboBox2.SelectedItem == "US - USD $ (Dollar)")
            {
                double conver = i * 0.065;
                label2.Text = "" + i + " ZAR R - Rand = \n\t" + conver + " USD";
            }
            if (comboBox1.SelectedItem == "South Africa - ZAR R (Rand)" && comboBox2.SelectedItem == "Europe - EUR € (Euro)")
            {
                double conver = i * 0.055;
                label2.Text = "" + i + " ZAR R - Rand = \n\t" + conver + " EUR";
            }


            //Conversion from KRW ẅ -South Korean Won....
            if (comboBox1.SelectedItem == "KRW ẅ -South Korean Won" && comboBox2.SelectedItem == "UK - GBP £ (British Pound Sterling)")
            {
                double conver = i * 0.00064;
                label2.Text = "" + i + " KRW ẅ - Won = \n\t" + conver + " GBP";
            }
            if (comboBox1.SelectedItem == "KRW ẅ -South Korean Won" && comboBox2.SelectedItem == "US - USD $ (Dollar)")
            {
                double conver = i * 0.00088;
                label2.Text = "" + i + " KRW ẅ - Won = \n\t" + conver + " USD";
            }
            if (comboBox1.SelectedItem == "KRW ẅ -South Korean Won" && comboBox2.SelectedItem == "Europe - EUR € (Euro)")
            {
                double conver = i * 0.00074;
                label2.Text = "" + i + " KRW ẅ - Won = \n\t" + conver + " EUR";
            }


            //Conversion from Brazil - BRL R$ (Real)....
            if (comboBox1.SelectedItem == "Brazil - BRL R$ (Real)" && comboBox2.SelectedItem == "UK - GBP £ (British Pound Sterling)")
            {
                double conver = i * 0.13;
                label2.Text = "" + i + " BRL R$ - Real = \n\t" + conver + " GBP";
            }
            if (comboBox1.SelectedItem == "Brazil - BRL R$ (Real)" && comboBox2.SelectedItem == "US - USD $ (Dollar)")
            {
                double conver = i * 0.18;
                label2.Text = "" + i + " BRL R$ - Real = \n\t" + conver + " USD";
            }
            if (comboBox1.SelectedItem == "Brazil - BRL R$ (Real)" && comboBox2.SelectedItem == "Europe - EUR € (Euro)")
            {
                double conver = i * 0.15;
                label2.Text = "" + i + " BRL R$ - Real = \n\t" + conver + " EUR";
            }

             
            //Conversion from Russia - RUB ₽ (Ruble)....
            if (comboBox1.SelectedItem == "Russia - RUB ₽ (Ruble)" && comboBox2.SelectedItem == "UK - GBP £ (British Pound Sterling)")
            {
                double conver = i * 0.0096;
                label2.Text = "" + i + " RUB ₽ - Ruble = \n\t" + conver + " GBP";
            }
            if (comboBox1.SelectedItem == "Russia - RUB ₽ (Ruble)" && comboBox2.SelectedItem == "US - USD $ (Dollar)")
            {
                double conver = i * 0.013;
                label2.Text = "" + i + " RUB ₽ - Ruble = \n\t" + conver + " USD";
            }
            if (comboBox1.SelectedItem == "Russia - RUB ₽ (Ruble)" && comboBox2.SelectedItem == "Europe - EUR € (Euro)")
            {
                double conver = i * 0.011;
                label2.Text = "" + i + " RUB ₽ - Ruble = \n\t" + conver + " EUR";
            }


            //Conversion from Philippine - PHP Ᵽ(Peso)....
            if (comboBox1.SelectedItem == "Philippine - PHP Ᵽ (Peso)" && comboBox2.SelectedItem == "UK - GBP £ (British Pound Sterling)")
            {
                double conver = i * 0.015;
                label2.Text = "" + i + " PHP Ᵽ - Peso = \n\t" + conver + " GBP";
            }
            if (comboBox1.SelectedItem == "Philippine - PHP Ᵽ (Peso)" && comboBox2.SelectedItem == "US - USD $ (Dollar)")
            {
                double conver = i * 0.021;
                label2.Text = "" + i + " PHP Ᵽ - Peso = \n\t" + conver + " USD";
            }
            if (comboBox1.SelectedItem == "Philippine - PHP Ᵽ (Peso)" && comboBox2.SelectedItem == "Europe - EUR € (Euro)")
            {
                double conver = i * 0.017;
                label2.Text = "" + i + " PHP Ᵽ - Peso = \n\t" + conver + " EUR";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Result";
            comboBox1.Text = "Select Currency";
            comboBox2.Text = "Select Currency";
            textBox1.Text = "0";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
