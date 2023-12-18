using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            YouBT.Clicked += YouBT_Clicked;
            GridBT.Clicked += GridBT_Clicked;
            StackBT.Clicked += StackBT_Clicked;
            TabBT.Clicked += TabBT_Clicked;
            ProjBT.Clicked += ProjBT_Clicked;
        }

        private void ProjBT_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(new Proj());
            mp.IsPresented = false;
        }

        private void TabBT_Clicked(object sender, EventArgs e)
        {
            var TP = new TabbedPage();
            TP.Children.Add(new TabPage1());
            TP.Children.Add(new TabPage2());
            TP.Children.Add(new TabPage3());

            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(TP);
            mp.IsPresented = false;
        }

        private void StackBT_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(new YoutubePage());
            mp.IsPresented = false;
        }

        private void GridBT_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(new NavPage1());
            mp.IsPresented = false;
        }

        private void YouBT_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as FlyoutPage;
            mp.Detail = new NavigationPage(new YoutubePage());
            mp.IsPresented = false;
        }
    }
}