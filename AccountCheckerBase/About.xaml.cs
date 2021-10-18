using System;
using System.Windows;
using System.Windows.Input;
using System.Diagnostics;

namespace AccountCheckerBase
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://cracked.to/Matt101");
        }
    }
}
