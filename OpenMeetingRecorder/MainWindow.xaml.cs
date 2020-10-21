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
using MahApps.Metro.Controls;
using MahApps.Metro;
using MahApps.Metro.Controls;

namespace OpenMeetingRecorder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        //private void ChangeTheme(string newTheme)
        //{
        //    var theme = ThemeManager.DetectAppStyle(Application.Current);
        //    var accent = ThemeManager.GetAccent(newTheme);
        //    ThemeManager.ChangeAppStyle(Application.Current, accent, theme.Item1);
        //}
    }
}
