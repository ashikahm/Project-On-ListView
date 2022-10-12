using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PersonInfo.ViewModel;

namespace PersonInfo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewInformation : ContentPage
    {
        methodCall obj = new methodCall();
        public ViewInformation()
        {
            InitializeComponent();
            MyListView.ItemsSource = obj.GetInfo;
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            var ib = sender as ImageButton;
            var url = ib.CommandParameter.ToString();
            await Browser.OpenAsync(url);
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

            MyListView.ItemsSource = obj.GetInfo.Where(a => a.Name.StartsWith(e.NewTextValue));

        }
    }
}