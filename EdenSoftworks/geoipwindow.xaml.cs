using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MUXC = Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace EdenSoftworks
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class geoipwindow : Page
    {
        public geoipwindow()
        {
            this.InitializeComponent();
        }

        private void TabView_AddTabButtonClick(MUXC.TabView sender, object args)
        {
            var newTab = new MUXC.TabViewItem();
            newTab.IconSource = new MUXC.SymbolIconSource() { Symbol = Symbol.Document };
            newTab.Header = "New Document";

            // The Content of a TabViewItem is often a frame which hosts a page.

            sender.TabItems.Add(newTab);
        }


        private void TabView_TabCloseRequested(MUXC.TabView sender, MUXC.TabViewTabCloseRequestedEventArgs args)
        {
            sender.TabItems.Remove(args.Tab);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));

        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuFlyoutItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void MenuFlyoutItem_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void MenuFlyoutItem_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void TabView_Loaded(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
