using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace BatPrismTutorials.Services
{
    public interface ISQLiteConnectionProvider
    {
        SQLiteConnection GetConnection();
    }
}
