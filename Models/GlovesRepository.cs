using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoxShop.Models
{
    public class GlovesRepository: IGlovesRepository
    {
        private readonly AppDbContext _appDbContext;

          public GlovesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
                
        }

        public IEnumerable<Gloves> GetAllGloves()
        {
            return _appDbContext.Gloves;
        }

        public Gloves GetGlovesById(int glovesId)
        {
            return _appDbContext.Gloves.FirstOrDefault(p => p.Id == glovesId);
        }
    }
}
