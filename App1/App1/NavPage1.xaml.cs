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
    public partial class NavPage1 : ContentPage
    {
        public NavPage1()
        {
            InitializeComponent();
            

            navToPage2.Clicked += NavToPage2_Clicked;
            navToPage3.Clicked += NavToPage3_Clicked;
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

        async private void NavToPage3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavPage3());
        }

        async private void NavToPage2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavPage2());
        }
    }
}