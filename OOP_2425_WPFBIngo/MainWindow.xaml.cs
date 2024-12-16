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

namespace OOP_2425_WPFBIngo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[,] numbers = new Button[5, 5];
        int resetCount = 0;

        public MainWindow()
        {
            InitializeComponent();

            numbers[0, 0] = btnB1;
            numbers[1, 0] = btnB2;
            numbers[2, 0] = btnB3;
            numbers[3, 0] = btnB4;
            numbers[4, 0] = btnB5;

            numbers[0, 1] = btnI1;
            numbers[1, 1] = btnI2;
            numbers[2, 1] = btnI3;
            numbers[3, 1] = btnI4;
            numbers[4, 1] = btnI5;

            numbers[0, 2] = btnN1;
            numbers[1, 2] = btnN2;
            numbers[2, 2] = btnN3;
            numbers[3, 2] = btnN4;
            numbers[4, 2] = btnN5;

            numbers[0, 3] = btnG1;
            numbers[1, 3] = btnG2;
            numbers[2, 3] = btnG3;
            numbers[3, 3] = btnG4;
            numbers[4, 3] = btnG5;

            numbers[0, 4] = btnO1;
            numbers[1, 4] = btnO2;
            numbers[2, 4] = btnO3;
            numbers[3, 4] = btnO4;
            numbers[4, 4] = btnO5;

            Initialize();
        }

        private void Initialize()
        {
            for(int x = 0; x < numbers.GetLength(0); x++)
            {
                for(int y = 0; y < numbers.GetLength(1); y++)
                {
                    numbers[x,y].Content = "o";
                    numbers[x,y].IsEnabled = false;
                }
            }

            btnGenerate.IsEnabled = true;
            btnPlay.IsEnabled = false;
            btnReset.IsEnabled = false;

            resetCount = 1;
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            List<int> nums = new List<int>();
            Random rnd = new Random();
            int temp = 0;
            btnPlay.IsEnabled = true;

            //resetCount = 0;

            for (int x = 0; x < numbers.GetLength(0); x++)
            {
                nums.Clear();
                for (int y = 1; y <= 15; y++)
                    nums.Add(y);

                for (int y = 0; y < numbers.GetLength(1); y++)
                {
                    temp = rnd.Next(nums.Count);
                    numbers[y,x].Content = nums[temp] + (15 * x);
                    nums.RemoveAt(temp);
                }
            }

            numbers[2, 2].Content = "FRE";
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            btnGenerate.IsEnabled = false;
            btnPlay.IsEnabled = false;

            for (int x = 0; x < numbers.GetLength(0); x++)
                for (int y = 0; y < numbers.GetLength(1); y++)
                    numbers[x, y].IsEnabled = true;

            numbers[2,2].IsEnabled = false;
            btnReset.IsEnabled = true;

            //resetCount = 1;
        }

        #region Button Events
        private void btnB1_Click(object sender, RoutedEventArgs e)
        {
            resetCount = 0;
            btnB1.IsEnabled = false;
        }

        private void btnB2_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnB2.IsEnabled = false;
        }

        private void btnB3_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnB3.IsEnabled = false;
        }

        private void btnB4_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnB4.IsEnabled = false;
        }

        private void btnB5_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnB5.IsEnabled = false;
        }

        private void btnI1_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnI1.IsEnabled = false;
        }

        private void btnI2_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnI2.IsEnabled = false;
        }

        private void btnI3_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnI3.IsEnabled = false;
        }

        private void btnI4_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnI4.IsEnabled = false;
        }

        private void btnI5_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnI5.IsEnabled = false;
        }

        private void btnN1_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnN1.IsEnabled = false;
        }

        private void btnN2_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnN2.IsEnabled = false;
        }

        private void btnN3_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnN3.IsEnabled = false;
        }

        private void btnN4_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnN4.IsEnabled = false;
        }

        private void btnN5_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnN5.IsEnabled = false;
        }

        private void btnG1_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnG1.IsEnabled = false;
        }

        private void btnG2_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnG2.IsEnabled = false;
        }

        private void btnG3_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnG3.IsEnabled = false;
        }

        private void btnG4_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnG4.IsEnabled = false;
        }

        private void btnG5_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnG5.IsEnabled = false;
        }

        private void btnO1_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnO1.IsEnabled = false;
        }

        private void btnO2_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnO2.IsEnabled = false;
        }

        private void btnO3_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnO3.IsEnabled = false;
        }

        private void btnO4_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnO4.IsEnabled = false;
        }

        private void btnO5_Click(object sender, RoutedEventArgs e)
        {

            resetCount = 0;
            btnO5.IsEnabled = false;
        }

        #endregion

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            //resetCount++;

            switch(resetCount)
            {
                case 0:
                    for (int x = 0; x < numbers.GetLength(0); x++)
                        for (int y = 0; y < numbers.GetLength(1); y++)
                            numbers[x, y].IsEnabled = true;

                    numbers[2, 2].IsEnabled = false;

                    resetCount = 1;
                    break;
                case 1:
                    Initialize();
                    break;
            }
        }
    }
}
