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
using Kiemtraketthucmon;
namespace Kiemtraketthucmon
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

        private void Btn_ok_Click(object sender, RoutedEventArgs e)
        {
            Cho cho = new Cho();
            cho.DongvatKeu = "Gâu gâu";
            cho.DongvatMauLong = "Đen";
            cho.Talk();
            Meo meo = new Meo();
            meo.DongvatKeu = "Meo meo";
            meo.DongvatMauLong = "Trắng";
            meo.Talk();
        }
    }
}
