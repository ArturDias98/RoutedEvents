using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            /// <summary>
            /// Index que indica com qual item estou interagindo
            /// </summary>
            public int Index { get; set; }
        }
        public ToolBarControl()
        {
            InitializeComponent();
            ToolBar.Loaded += ToolBar_Loaded;

        }

        private void ToolBar_Loaded(object sender, RoutedEventArgs e)
        {
            InitList();
        }

        private void InitList()
        {
            ItemsSource = new ObservableCollection<ToolBarModel>();
            for (int i = 0; i < NumItems; i++)
            {
                ItemsSource.Add(new ToolBarModel
                {
                    Index = i
                });
            }
            NotifyPropertyChanged(nameof(ItemsSource));
        }
        private void Up_Click(object sender, RoutedEventArgs e)
        {
            var obj = sender as Button;
            var index = (int)obj.Tag;
            RaiseEvent(new RoutedPropertyChangedEventArgs<int>(0, index, ButtonUpEvent));
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            var obj = sender as Button;
            var index = (int)obj.Tag;
            RaiseEvent(new RoutedPropertyChangedEventArgs<int>(0, index, ButtonDownEvent));
        }

        private void IsVisivle_Checked(object sender, RoutedEventArgs e)
        {

        }

        public ObservableCollection<ToolBarModel> ItemsSource { get; set; }


        #region RoutedEvents
        public event RoutedPropertyChangedEventHandler<int>  UpClick
        {
            add
            {
                AddHandler(ButtonUpEvent, value);
            }
            remove
            {
                RemoveHandler(ButtonUpEvent, value);
            }
        }
        public static RoutedEvent ButtonUpEvent = EventManager.RegisterRoutedEvent(nameof(UpClick),
          RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<int>), typeof(ToolBarControl) );


        public event RoutedPropertyChangedEventHandler<int>  DownClick
        {
            add
            {
                AddHandler(ButtonDownEvent, value);
            }
            remove
            {
                RemoveHandler(ButtonDownEvent, value);
            }
        }
        public static RoutedEvent ButtonDownEvent = EventManager.RegisterRoutedEvent(nameof(DownClick),
          RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<int>), typeof(ToolBarControl) );
        #endregion


        #region DependencyProperty
        /// <summary>
        /// Quantidade de itens para serem mostrados
        /// </summary>
        public int NumItems
        {
            get { return (int)GetValue(NumItemsProperty); }
            set { SetValue(NumItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NumItems.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NumItemsProperty =
    DependencyProperty.Register("NumItems", typeof(int), typeof(ToolBarControl), new PropertyMetadata(1));
        #endregion

        #region NotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
        #endregion


    }
}
