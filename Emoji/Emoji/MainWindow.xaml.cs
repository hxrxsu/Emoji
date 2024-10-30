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

namespace Emoji
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string imagePath = "sad.png"; //инициализируем переменную imagePath в ней определим путь sad.png
            string relativeImagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath); //инициализируем переменную relativeImagePath, в которой мы с помощью path combine получим относительный путь для картинке на фоне

            IMG_Levels.Source = new BitmapImage(new Uri(relativeImagePath)); // определяем источник для обьекта image переменную relativeImagePath
        }

        private void WinCheker() // метод, который проверяет пуст ли список, если же пусть, то выводит сообщение об этом
        {
            if(LB_Items.Items.IsEmpty == true)
            {
                MessageBox.Show("Победа!");
            }
        }
   
        /// <summary>
        /// При нажатии на верную кнопку скрывается нажатая и удаляется айтем из списка, а также меняется картинка и вызывается метод WinCheker
        /// </summary>
        private void BN_Sad_Click(object sender, RoutedEventArgs e)
        {
            LB_Items.Items.RemoveAt(LB_Items.Items.IndexOf(LI_Sad));
            BN_Sad.Visibility = Visibility.Hidden;
            BN_Spy.Visibility = Visibility.Visible;

            MessageBox.Show("Вы нашли верный эмодзи!");

            string imagePath = "guardian.png";
            string relativeImagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);
            IMG_Levels.Source = new BitmapImage(new Uri(relativeImagePath));
            WinCheker();
        }

        private void BN_Criminal_Click(object sender, RoutedEventArgs e)
        {
            LB_Items.Items.RemoveAt(LB_Items.Items.IndexOf(LI_Criminal));
            BN_Criminal.Visibility = Visibility.Hidden;

            MessageBox.Show("Вы нашли верный эмодзи!");

            string imagePath = "police.png";
            string relativeImagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);
            IMG_Levels.Source = new BitmapImage(new Uri(relativeImagePath));
            WinCheker();
        }

        private void BN_Spy_Click(object sender, RoutedEventArgs e)
        {
            LB_Items.Items.RemoveAt(LB_Items.Items.IndexOf(LI_Spy));
            BN_Spy.Visibility = Visibility.Hidden;
            BN_Criminal.Visibility = Visibility.Visible;

            MessageBox.Show("Вы нашли верный эмодзи!");

            string imagePath = "police.png";
            string relativeImagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);
            IMG_Levels.Source = new BitmapImage(new Uri(relativeImagePath));
            WinCheker();
        }
    }
}