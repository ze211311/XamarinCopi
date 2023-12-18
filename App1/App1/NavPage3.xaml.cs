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
    public partial class NavPage3 : ContentPage
    {
        public NavPage3()
        {
            InitializeComponent();

            CloseButt.Clicked += CloseButt_Clicked;
        }

        async private void CloseButt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}