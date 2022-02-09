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

namespace wpfAppWeek4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MessageBox.Show("Hello World");

        }

        private void calcButtonClicker(object sender, RoutedEventArgs e)
        {




    
        }

        private void Button_Clicked(object sender, RoutedEventArgs e)
        {

            // Only runs when debugging
            System.Diagnostics.Trace.WriteLine("Okay");

            Console.WriteLine("Grade 1");
            double gradeOne = Convert.ToDouble(TextBox1.Text);
            grade1Show.Content = gradeOne;

            Console.WriteLine("Grade 2");
            double gradeTwo = Convert.ToDouble(TextBox2.Text);
            grade2Show.Content = gradeTwo;


            Console.WriteLine("Grade 3");
            double gradeThree = Convert.ToDouble(TextBox3.Text);
            grade3Show.Content = gradeThree;
            double gradeTotal = (gradeOne + gradeTwo + gradeThree) /3;

            Letter_Grade.Content = ((gradeTotal.ToString("F2"))).ToString();



            char letterGrade = 'F';
            if (gradeTotal > 90)
            {
                letterGrade = 'A';
            }
            else if (gradeTotal > 80)
            {
                letterGrade = 'B';
            }
            else if (gradeTotal > 70)
            {
                letterGrade = 'C';
            }
            else
            {
                letterGrade = 'F';
            }

            // chat alphabetical grade
            Alph_Grade.Content = letterGrade.ToString();




            MessageBox.Show(gradeTotal.ToString("F2"));
            System.Diagnostics.Trace.WriteLine("OK");
        }


    }
}
