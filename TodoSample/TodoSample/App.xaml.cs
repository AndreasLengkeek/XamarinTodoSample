using System;
using TodoSample.Data;
using TodoSample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoSample
{
    public partial class App : Application
    {
        static TodoItemDatabase database;

        public static TodoItemDatabase Database
        {
            get { return database ?? new TodoItemDatabase(); }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TodoListPage());
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
