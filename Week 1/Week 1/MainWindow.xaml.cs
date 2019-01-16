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

namespace Week_1
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

        private void btngo_Click(object sender, RoutedEventArgs e)
        {
            long n = 1;
            long n2 = 0;
            int i = 1;
            bool prime = true;
            while(prime)
            {
                n2 = n * n; // makes n2 the squared of n
                n2 = n2 - n + 41; //makes n2 = the equation
                lstprimes.Items.Add(n + "² - "+ n +" +41 = " + n2);
                prime = IsPrime(n2,n, prime);
                n++;
                
               
            }
        }

        private bool IsPrime(long n2, long n, bool prime)
        {

            long x, i, m = 0, flag = 0;
            // Console.Write("Enter the Number to check Prime: ");
            x = n2;
            m = x / 2;
            for (i = 2; i <= m; i++)
            {
                if (x % i == 0)
                {
                    lblPrime.Content = "The counter example is " + n;
                    flag = 1;
                    prime = false;
                    return prime;

                }
            }
            if (flag == 0) { }
            lblPrime.Content = n + " Number is Prime.";
            prime = true;

            return prime;

        }

    }  
           
        

}

