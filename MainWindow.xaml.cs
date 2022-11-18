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

namespace projectA
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

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        /*
        Ellipse YourEllipseName = new Ellipse
        {
            Height = 50,
            Width = 50,
            StrokeThickness = 0,
            Fill = new ImageBrush
            {
                Stretch = Stretch.Uniform,
                ImageSource = new BitmapImage(new Uri("YOUR IMAGE SOURCE HERE"))
            }
        };
        */
    }
}
