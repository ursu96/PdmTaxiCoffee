﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PdmProject
{
    public partial class App : Application
    {
        public const string NUME_DB = "pdm.db";

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
