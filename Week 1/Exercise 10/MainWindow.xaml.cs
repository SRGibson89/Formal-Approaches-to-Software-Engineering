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

namespace Exercise_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
            int a=1, b=1, c=1, d=1;

            int a3, b3, c3, d3;
            bool loop = true;
            while (loop)
            {
                while (a > b)
                {
                    b++;
                }

                while (c > d)
                {
                    d++;
                }

                a3 = a * a * a;
                b3 = b * b * b;
                c3 = c * c * c;
                d3 = d * d * d;


                if ((a3 + b3) != (c3 + d3))
                {
                    lblAnswer.Content = (a3 + b3);
                    loop = false;
                }
                else
                {
                    a++;
                    b++;
                    c++;
                    d++;
                }
               if (a == 100)
                {
                    
                    lblAnswer.Content = ("FAILED!!!");
                    loop = false;
                }
            }
            */

            //lblAnswer.Content = Math.Pow(3, 2); //this is will square a number (Number to be rasied to the power of,power of) therefore rhis displays 9

            int N = 5;
            printTaxicab2(N,lblAnswer);
        }

        

        public static void printTaxicab2(int N, Label lblAnswer)
        {
            // Starting from 1, check every number if 
            // it is Taxicab until count reaches N. 
            int i = 1, count = 0;
            while (count < 1)
            {
                int int_count = 0;

                // Try all possible pairs (x, k) whose  
                // cube sums can be i. 
                for(int x = 1; x<=Math.Pow(i,1.0/3);x++)
                {
                    Console.WriteLine(Math.Pow(i, 1.0 / 3));
                    for (int k = x + 1; k <= Math.Pow(i, 1.0 / 3); k++)
                    {
                        if (x * x * x + k * k * k == i)
                        {
                            
                           // Console.WriteLine(count + " " + k);
                            int_count++;
                        }
                    }
                }
               
                // Taxicab(2) found 
                if (int_count == 2)
                {
                    count++;

                    //Console.WriteLine(count + " " + i);
                    lblAnswer.Content = "Done! " + i;
                }

                i++;
            }
        }
    }
}
