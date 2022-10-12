using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PersonInfo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewInformation : ContentPage
    {
        public ViewInformation()
        {
            InitializeComponent();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            var ib = sender as ImageButton;
            var url = ib.CommandParameter.ToString();
            await Browser.OpenAsync(url);
        }
    }
}