using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PersonInfo.View;

namespace PersonInfo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ViewInformation();
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
