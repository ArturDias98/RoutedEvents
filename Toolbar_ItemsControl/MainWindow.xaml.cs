using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Toolbar_ItemsControl
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Loaded += Main_Loaded;
        }

        private void Main_Loaded(object sender, RoutedEventArgs e)
        {
            LeftValue = 0;
            NotifyPropertyChanged(nameof(LeftValue));

            RigthValue = 0;
            NotifyPropertyChanged(nameof(RigthValue));

            LeftVisibility = true;
            NotifyPropertyChanged(nameof(LeftVisibility));

            RigthVisibility = true;
            NotifyPropertyChanged(nameof(RigthVisibility));
        }

        private void ToolBarControl_UpClick(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            var index = e.NewValue;
            if (index == 0)
            {
                LeftValue = LeftValue + 10;
                NotifyPropertyChanged(nameof(LeftValue));
            }
            else if (index == 1)//Para realmente saber se está interagindo
            {
                RigthValue = RigthValue + 10;
                NotifyPropertyChanged(nameof(RigthValue));
            }
        }
        private void ToolBarControl_DownClick(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            var index = e.NewValue;
            if (index == 0)
            {
                LeftValue = LeftValue - 10;
                NotifyPropertyChanged(nameof(LeftValue));
            }
            else if (index == 1)//Para realmente saber se está interagindo
            {
                RigthValue = RigthValue - 10;
                NotifyPropertyChanged(nameof(RigthValue));
            }
        }
        private void ToolBarControl_VisibilityChange(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            var index = e.NewValue;
            if (index == 0)
            {
                LeftVisibility = !LeftVisibility;
                NotifyPropertyChanged(nameof(LeftVisibility));
            }
            else if (index == 1)//Para realmente saber se está interagindo
            {
                RigthVisibility = !RigthVisibility;
                NotifyPropertyChanged(nameof(RigthVisibility));
            }
        }
        public int LeftValue { get; set; }
        public int RigthValue { get; set; }

        public bool LeftVisibility { get; set; }
        public bool RigthVisibility { get; set; }




        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }


    }
}
