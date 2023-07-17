using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace atm2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page1 : Page
    {
        public Page1()
        {
            this.InitializeComponent();
        }

        private void NavigationView_Loaded(object sender, RoutedEventArgs e)
        {
            atmframe.Navigate(typeof(Page2));
        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if(args.IsSettingsSelected)
            {

            }
            else
            {
                NavigationViewItem item = args.SelectedItem as NavigationViewItem;
                switch (item.Tag.ToString())
                {
                    case "Page2":
                        atmframe.Navigate(typeof(Page2));
                        break;
                    case "Page3":
                        atmframe.Navigate(typeof(Page3));
                        break;
                    case "Page4":
                        atmframe.Navigate(typeof(Page4));
                        break;
                    case "Page5":
                        atmframe.Navigate(typeof(Page5));
                        break;
                }
            }
        }

        private void back(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (atmframe.CanGoBack)
            {
                atmframe.GoBack();
            }
        }
    }
}
