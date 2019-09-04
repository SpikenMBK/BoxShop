using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoxShop.Models
{
    public interface IGlovesRepository
    {
        IEnumerable<Gloves> GetAllGloves();
        Gloves GetGlovesById(int glovesId);
    
    }
}
