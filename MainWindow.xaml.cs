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

namespace LeeMusic
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public playList pl = new LeeMusic.playList();

        public MainWindow()
        {
            InitializeComponent();
        }
        //播放音乐
        private void btnPlay(object sender, RoutedEventArgs e)
        {

        }
        //前一首
        private void btnBack(object sender, RoutedEventArgs e)
        {

        }
        //下一首
        private void btnFoward(object sender, RoutedEventArgs e)
        {

        }
        //播放列表的显示和隐藏
        private void readPlayList(object sender, RoutedEventArgs e)
        {
            if (pl.IsVisible)
            {
                pl.Hide();
            }
            else {
                pl.Show();
            }
        }

        private void closeWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
