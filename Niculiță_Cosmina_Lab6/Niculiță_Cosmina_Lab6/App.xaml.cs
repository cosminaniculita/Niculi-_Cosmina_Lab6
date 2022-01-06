using System;
using Niculiță_Cosmina_Lab6.Models;
using Niculiță_Cosmina_Lab6.Data;
using System.IO;
using Xamarin.Forms;

namespace Niculiță_Cosmina_Lab6
{
    public partial class App : Application
    {
        static ShoppingListDatabase database;
        public static ShoppingListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "ShoppingList.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListEntryPage());
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
