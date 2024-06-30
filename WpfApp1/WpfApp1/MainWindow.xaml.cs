using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }

            // 새로운 TextBlock을 생성하여 스택패널에 추가
            TextBlock resultTextBlock = new TextBlock
            {
                Text = "1부터 10까지의 합: " + sum,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                FontSize = 24,
                Margin = new Thickness(0, 20, 0, 0)
            };
            MainStackPanel.Children.Insert(0, resultTextBlock); // 스택패널의 맨 위에 추가
        }
    }
}
