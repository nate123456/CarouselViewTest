using System;
using CarouselViewTest.ViewModels;
using CarouselViewTest.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var peoplePage = new PeoplePage
            {
                BindingContext = new PeopleViewModel()
            };

            MainPage = peoplePage;
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
