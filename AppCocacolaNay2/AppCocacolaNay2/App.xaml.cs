﻿using AppCocacolaNay2.ViewModels.Base;
using AppCocacolaNay2.Views.Inventarios;
using Xamarin.Forms;

namespace AppCocacolaNay2
{
	public partial class App : Application
	{

        private static ViewModelLocator _locator;

        public static ViewModelLocator Locator
        {
            get { return _locator = _locator ?? new ViewModelLocator(); }
        }

        public App ()
		{
			InitializeComponent();


            MainPage = new NavigationPage(new Zt_inventarioListView(null));
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
