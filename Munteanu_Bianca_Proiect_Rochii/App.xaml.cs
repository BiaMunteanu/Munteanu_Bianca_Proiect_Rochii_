using System;
using Munteanu_Bianca_Proiect_Rochii.Data;
using System.IO;

namespace Munteanu_Bianca_Proiect_Rochii;

public partial class App : Application
{
    static ListaRochiiDatabase database;
    public static ListaRochiiDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new
               ListaRochiiDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "ListaRochii.db3"));
            }
            return database;
        }
    }
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
