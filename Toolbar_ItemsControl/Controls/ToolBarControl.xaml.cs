using System;
using System.Collections;
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

namespace Toolbar_ItemsControl.Controls
{
    /// <summary>
    /// Interação lógica para ToolBarControl.xam
    /// </summary>
    public partial class ToolBarControl : UserControl, INotifyPropertyChanged
    {
        public partial class ToolBarModel
        {
            private int Index { get; set; }
        }
        public ToolBarControl()
        {
            InitializeComponent();
        }




        public IEnumerable<ToolBarModel> SourceList
        {
            get { return (IEnumerable<ToolBarModel>)GetValue(SourceListProperty); }
            set { SetValue(SourceListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceListProperty =
    DependencyProperty.Register("SourceList", typeof(IEnumerable<ToolBarModel>), typeof(UserControl), new PropertyMetadata(null));



        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
