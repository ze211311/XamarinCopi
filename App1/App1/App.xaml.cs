using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //NavigationPage
            var page1 = new NavPage1();
            //var page2 = new NavPage2();
            //var page3 = new NavPage3();
            var np1 = new NavigationPage(page1);
            //var np2 = new NavigationPage(page2);
            //var np3 = new NavigationPage(page3); 

            //FlyoutPage
            var fp = new FlyoutPage();
            fp.Flyout = new MenuPage();
            fp.Detail = new NavigationPage(new MainPage());


            var TP = new TabbedPage();
            TP.Children.Add(new TabPage1());
            TP.Children.Add(new TabPage2());
            TP.Children.Add(new TabPage3());


            MainPage = fp;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
