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
           HinhVuong[] hinhhocs = new HinhVuong[5];
            float[] canh = { 2, 5, 6, 3, 7 };
            for (int i = 0; i < hinhhocs.Length; i++)
                hinhhocs[i] = new HinhVuong(canh[i]);

            for (int i = 0; i < hinhhocs.Length; i++)
                listBox.Items.Add((i + 1).ToString() + "\t\t" + hinhhocs[i].Canh.ToString() + "\t\t" + hinhhocs[i].chuVi().ToString() + "\t\t" +
                    hinhhocs[i].dienTich().ToString());


            HinhTron[] hinhTrons = new HinhTron[5];
            float[] BK = { 2, 5, 6, 3, 7 };
            for (int i = 0; i < hinhTrons.Length; i++)
                hinhTrons[i] = new HinhTron(BK[i]);

            for (int i = 0; i < hinhTrons.Length; i++)
                listBox1.Items.Add((i + 1).ToString() + "\t\t" + hinhTrons[i].R.ToString() + "\t\t" + hinhTrons[i].chuVi().ToString() + "\t\t" +
                    hinhTrons[i].dienTich().ToString());

            label.Content = "STT" + "\t\t" + "Ban Kinh" + "\t\t" + "Chu Vi" + "\t\t" + "Dien Tich";
            label_Copy.Content = "STT" + "\t\t" + "Canh" + "\t\t" + "Chu Vi" + "\t\t" + "Dien Tich";
        }

        private void Hinh_Tron_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    
}
