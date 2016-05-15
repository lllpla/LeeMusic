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
using System.Windows.Shapes;
using System.IO;

namespace LeeMusic
{
    /// <summary>
    /// playList.xaml 的交互逻辑
    /// </summary>
    public partial class playList : Window
    {
        public playList()
        {
            InitializeComponent();
        }
        //扫描路径下的所有文件
        private void openDIR_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            //1.检查文件夹是否存在
            if (textBox.Text.Equals(String.Empty)) {
                return;
            }
            //2.得到所有文件名
            DirectoryInfo info = new DirectoryInfo(textBox.Text);
            //如果文件夹存在
            
            if (info.Exists) {
                FileInfo[] files = info.GetFiles();
                foreach (FileInfo file in files){
                    listBox.Items.Add(file.FullName);
                }

            }

        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Equals("在此输入文件夹路径")) {
                textBox.Text = "";
            }
        }

        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Equals(String.Empty)) {
                textBox.Text = "在此输入文件夹路径";
            }
        }
    }
}