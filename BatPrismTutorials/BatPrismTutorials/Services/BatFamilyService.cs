using System;
using System.Collections.Generic;
using System.Text;

using BatPrismTutorials.Model;
using SQLite;

namespace BatPrismTutorials.Services
{
    public class BatFamilyService : IBatFamilyService
    {
        private ISQLiteConnectionProvider LiteconectionProvider { get; }
        private SQLiteConnection LiteConnection { get; }

        public BatFamilyService(ISQLiteConnectionProvider liteconectionProvider)
        {
            this.LiteconectionProvider = liteconectionProvider;
            this.LiteConnection = this.LiteconectionProvider.GetConnection();
            this.LiteConnection.CreateTable<BatFamily>();
        }
        public void Delete(int id)
        {
            this.LiteConnection.Delete<BatFamily>(id);
        }

        public IEnumerable<BatFamily> GetFamilies()
        {
            return this.LiteConnection.Table<BatFamily>().ToList();
        }

        public void Insert(BatFamily BatParent)
        {
            this.LiteConnection.Insert(BatParent);
        }

        public void Update(BatFamily BatParent)
        {
            this.LiteConnection.Update(BatParent);
        }

        public BatFamily GetById(int id)
        {
            return this.LiteConnection.Table<BatFamily>().FirstOrDefault(x => x.Id == id);
        }
    }
}
