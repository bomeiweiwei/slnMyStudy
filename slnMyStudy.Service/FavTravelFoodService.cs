using slnMyStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMyStudy.Service
{
    public class FavTravelFoodService : BaseService<FavTravelFood>
    {
        public FavTravelFoodService() : base("ApiRecordEntities")
        {
        }
    }
}
