using System;
using TaskApp.Views;
using TaskApp.Views.TaskCreators;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CreateTask();
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
