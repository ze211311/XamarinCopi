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
    public partial class NavPage2 : ContentPage
    {
        public NavPage2()
        {
            InitializeComponent();

            navToPage3.Clicked += NavToPage3_Clicked;
            navToPage1.Clicked += NavToPage1_Clicked;
            toTabPage.Clicked += ToTabPage_Clicked;
        }

        async private void ToTabPage_Clicked(object sender, EventArgs e)
        {
            var TP = new TabbedPage();
            TP.Children.Add(new TabPage1());
            TP.Children.Add(new TabPage2());
            TP.Children.Add(new TabPage3());
            await Navigation.PushAsync(TP);
        }

        async private void NavToPage1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavPage1());
        }

        async private void NavToPage3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavPage3());
        }
    }
}