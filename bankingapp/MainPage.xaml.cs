using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace atm2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private async void b1_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog dialog1 = new MessageDialog("Password is not accurate!", "ATM Machine System");
            MessageDialog dialog2 = new MessageDialog("Login Successful!", "ATM Machine System");
            MessageDialog dialog3 = new MessageDialog("ID is not accurate!", "ATM Machine System");
            MessageDialog dialog4 = new MessageDialog("ID and Password is not accurate!", "ATM Machine System");
            string a = passwordBox.Password.ToString();
            string b = userid.Text;
            string pass = App.change;
            if (a == pass && b == "trong")
            {
                await dialog2.ShowAsync();

                Window.Current.Content = new atm2.Page1();
            }
            else if(a == pass && b != "trong")
            {
                await dialog3.ShowAsync();
            }
            else if (a != pass && b != "trong")
            {
                await dialog4.ShowAsync();
            }
            else if (a != pass && b == "trong")
            {
                await dialog1.ShowAsync();
            }

        }

    }
}
