using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class Page3 : Page
    {
        public Page3()
        {
            this.InitializeComponent();
            this.deposit.Click += Deposit_Click;
        }


        private async void Deposit_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog dialog1 = new MessageDialog("ERROR! Please enter the number!", "ATM Machine System");
            try
            {
                string a = deposit2.Text;
                double b = double.Parse(a);
                //double p = 1000000 + b;
                //App.deposit = p;
                App.deposit = App.deposit + b;
                Frame.Navigate(typeof(Page2));

            }
            catch(Exception ex)
            {
                await dialog1.ShowAsync();
            }
 
        }
    }
}
