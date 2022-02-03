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

namespace Lab4_1WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar; //вычисляем результат
            resSum.Text = resDouble.ToString();//выводим результат 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double measureInch = Convert.ToDouble(measure.Text);
            double resDouble = measureInch * 2.54 / 100;
            result.Text = resDouble.ToString();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double lengthInch = Convert.ToDouble(length.Text);
            double resDouble = lengthInch / 3.28084;
            result1.Text = resDouble.ToString();


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double milesInch = Convert.ToDouble(miles.Text);
            double resDouble = milesInch * 1609.34;
            result2.Text = resDouble.ToString();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double verstsInch = Convert.ToDouble(versts.Text);
            double resDouble = verstsInch * 1066.8;
            result3.Text = resDouble.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rate1Evro = Convert.ToDouble(rate1.Text);
            double sum1Evro = Convert.ToDouble(sum1.Text);
            double resDouble = rate1Evro * sum1Evro;
            resSum1.Text = resDouble.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rate2Hryvnias = Convert.ToDouble(rate2.Text);
            double sum2Hryvnias = Convert.ToDouble(sum2.Text);
            double resDouble = rate2Hryvnias * sum2Hryvnias;
            resSum2.Text = resDouble.ToString();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rate3Drum = Convert.ToDouble(rate3.Text);
            double sum3Drum = Convert.ToDouble(sum3.Text);
            double resDouble = rate3Drum * sum3Drum;
            resSum3.Text = resDouble.ToString();
        }
    }
}
