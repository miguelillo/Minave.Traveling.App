using Minave.Traveling.App.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Minave.Traveling.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Minave.Traveling.App.MainPage();

        }

        protected override void OnStart()
        {
            BuildMainMenu buildMainMenu = new BuildMainMenu();
            buildMainMenu.StackLayoutCode();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
