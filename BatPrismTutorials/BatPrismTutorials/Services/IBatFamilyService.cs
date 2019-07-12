using System;
using System.Collections.Generic;
using System.Text;

using BatPrismTutorials.Model;

namespace BatPrismTutorials.Services
{
    
    public interface IBatFamilyService
    {
        IEnumerable<BatFamily> GetFamilies();
        BatFamily GetById(int id);
        void Update(BatFamily BatParent);
        void Insert(BatFamily BatParent);
        void Delete(int id);
    }
}
