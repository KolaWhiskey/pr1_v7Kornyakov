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
using Lib_7;
namespace pr1_v7Kornyakov
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

        private void mItAboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вариант 7. Сгенерировать массив заполненный случайными целыми числами, распределенных в\r\nдиапазоне от count/2 до count*2, где count - количество чисел в массиве. Вычислить\r\nсумму чисел массива меньших - count. Вывести на экран сгенерированные числа, значение\r\nсуммы. В классе реализовать статический метод с именем Sum",
                "Разработчик: Корняков Дмитрий",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtBoxCount.Text, out int count))
            {
                int[] array = MathString.Array(count);
                txtBoxResult.Text = string.Join(" ", array);

                //использование метода для вычисления суммы
                txtBoxSum.Text = array.Sum().ToString(); ; //вывод результата
                txtBoxPr.Text = array.Pr().ToString();
            }
            else MessageBox.Show("Числа нужно вводить и только целые!", "Ошибка",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
        }


        private void txtBoxCount_TextChanged(object sender, TextChangedEventArgs e) //автоочищение при изменение количества (txtBoxCount)
        {
            txtBoxResult.Clear();
            txtBoxSum.Clear();
            txtBoxPr.Clear();
        }
    }
}
