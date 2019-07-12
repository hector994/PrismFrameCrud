using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace BatPrismTutorials.Model
{
    public class BatFamily
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public string Nombre { get; set; }

    }
}
