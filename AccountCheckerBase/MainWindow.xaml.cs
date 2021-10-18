using System;
using System.Collections.Generic;
using System.IO;
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

namespace AccountCheckerBase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public static List<string> list0;
        public static int int0;

        public static List<string> list1;
        public static int int1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadComboButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog opencombo = new Microsoft.Win32.OpenFileDialog();
                opencombo.Title = "Open Combolist";
                opencombo.Filter = "Combolist (*.txt)|*.txt";
                Nullable<bool> result = opencombo.ShowDialog();
                if (result == true)
                {
                    HelpingClass.list0.Clear();
                    foreach (string line in File.ReadAllLines(opencombo.FileName))
                        HelpingClass.list0.Add(line);
                    this.LoadedComboValue.Content = HelpingClass.list0.Count.ToString();
                    int1 = HelpingClass.list0.Count;
                }
            }
            catch
            {

            }
        }

        private void LoadProxiesButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog openproxies = new Microsoft.Win32.OpenFileDialog();
                openproxies.Title = "Open Proxies";
                openproxies.Filter = "Proxy (*.txt)|*.txt";
                Nullable<bool> result = openproxies.ShowDialog();
                if (result == true)
                {
                    HelpingClass.list1.Clear();
                    HelpingClass.list1.AddRange(File.ReadAllLines(openproxies.FileName));
                    this.LoadedProxyValue.Content = HelpingClass.list1.Count.ToString();
                }
            }
            catch
            {

            }
        }
    }
}
