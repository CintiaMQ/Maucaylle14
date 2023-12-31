﻿using Maucaylle14.DataContext;
using Maucaylle14.Interfaces;
using Maucaylle14.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Maucaylle14
{
    public partial class App : Application
    {
        public partial class App : Application
        {
            public App()
            {
                InitializeComponent();
                GetContext().Database.EnsureCreated();
                MainPage = new PeopleView();
            }


            public static AppDbContext GetContext()
            {
                string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

                return new AppDbContext(DbPath);
            }
            protected override void OnStart()
            {
            }

            protected override void OnSleep()
            {
            }

            protected override void OnResume()
            }
    }
}

        
    