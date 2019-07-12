using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;


using BatPrismTutorials.Services;
using SQLite;
using System;
using System.IO;

namespace BatPrismTutorials.iOS.Services
{
    public class SQLiteConnectionProvider : ISQLiteConnectionProvider
    {
        private SQLiteConnection Connection { get; set; }
        public SQLiteConnection GetConnection()
        {
            if (this.Connection != null)
            {
                return this.Connection;
            }
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            path = Path.Combine(path, "..", "Library", "database.db3");
            return this.Connection = new SQLiteConnection(path);
        }
    }
}