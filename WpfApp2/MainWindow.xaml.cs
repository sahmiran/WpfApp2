using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string inputString = "";
        Boolean op = true;
        double tempvalue;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_click(object sender, RoutedEventArgs e)
        {
            inputString += btn1.Content;
            ciktiEkrani.Text = inputString;
            op = false;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            inputString += btn2.Content;
            ciktiEkrani.Text = inputString;
            op = false;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            inputString += btn3.Content;
            ciktiEkrani.Text = inputString;
            op = false;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            inputString += btn4.Content;
            ciktiEkrani.Text = inputString;
            op = false;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            inputString += btn5.Content;
            ciktiEkrani.Text = inputString;
            op = false;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            inputString += btn6.Content;
            ciktiEkrani.Text = inputString;
            op = false;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            inputString += btn7.Content;
            ciktiEkrani.Text = inputString;
            op = false;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            inputString += btn8.Content;
            ciktiEkrani.Text = inputString;
            op = false;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            inputString += btn9.Content;
            ciktiEkrani.Text = inputString;
            op = false;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            inputString += btn0.Content;
            ciktiEkrani.Text = inputString;
            op = false;
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (op == false)
            {
                inputString = inputString + " " + btnPlus.Content + " ";
                ciktiEkrani.Text = inputString;
                op = true;
            }
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (op == false)
            {
                inputString = inputString + " " + btnMinus.Content + " ";
                ciktiEkrani.Text = inputString;
                op = true;
            }
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (op == false)
            {
                inputString = inputString + " " + btnMultiply.Content + " ";
                ciktiEkrani.Text = inputString;
                op = true;
            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            if(op == false)
            {
                inputString = inputString + " " + btnDivide.Content + " ";
                ciktiEkrani.Text = inputString;
                op = true;
            }
            
        }

        private void btnEquel_Click(object sender, RoutedEventArgs e)
        {

            string[] bolunmusDizi = ciktiEkrani.Text.Split(" ");
            List<string> bolunmusList = bolunmusDizi.ToList();

            foreach (string value in bolunmusDizi)
            {
                if (value == "*")
                {

                    tempvalue = Convert.ToDouble(bolunmusList[bolunmusList.IndexOf("*") - 1]) * Convert.ToDouble(bolunmusList[bolunmusList.IndexOf("*") + 1]);

                    int cx = bolunmusList.IndexOf("*");

                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.Insert(cx - 1, tempvalue.ToString());


                    bolunmusDizi = bolunmusList.ToArray();

                }
            }
            foreach (string value in bolunmusDizi)
            {
                if (value == "/")
                {
                    tempvalue = Convert.ToDouble(bolunmusList[bolunmusList.IndexOf("/") - 1]) / Convert.ToDouble(bolunmusList[bolunmusList.IndexOf("/") + 1]);

                    int cx = bolunmusList.IndexOf("/");

                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.Insert(cx - 1, tempvalue.ToString());

                    bolunmusDizi = bolunmusList.ToArray();
                }
            }
            foreach (string value in bolunmusDizi)
            {
                if (value == "+")
                {
                    tempvalue = Convert.ToDouble(bolunmusList[bolunmusList.IndexOf("+") - 1]) + Convert.ToDouble(bolunmusList[bolunmusList.IndexOf("+") + 1]);

                    int cx = bolunmusList.IndexOf("+");

                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.Insert(cx - 1, tempvalue.ToString());

                    bolunmusDizi = bolunmusList.ToArray();
                }
            }
            foreach (string value in bolunmusDizi)
            {
                if (value == "-")
                {
                    tempvalue = Convert.ToDouble(bolunmusList[bolunmusList.IndexOf("-") - 1]) - Convert.ToDouble(bolunmusList[bolunmusList.IndexOf("-") + 1]);

                    int cx = bolunmusList.IndexOf("-");

                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.RemoveAt(cx - 1);
                    bolunmusList.Insert(cx - 1, tempvalue.ToString());

                    bolunmusDizi = bolunmusList.ToArray();
                }

                if (bolunmusDizi.Length == 1) break;
            }

            ciktiEkrani.Text = ciktiEkrani.Text + "=" + bolunmusDizi[0];

        }




    }

}
  
