using AutoMapper;
using slnMyStudy.Models;
using slnMyStudy.Models.ViewModel;
using slnMyStudy.Service;
using slnMyStudy.WebAPI.Models;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace slnMyStudy.WebAPI.Controllers
{
    public class FavProcessServiceController : ApiController
    {
        // POST: api/FavProcessService
        [SwaggerOperation("GetAll")]
        [ApiBasicAuthenticationFilter]
        [HttpPost]
        public APIResult Post(TravelFood travelFood)
        {
            FavTravelFoodService favTravelFoodService = new FavTravelFoodService();
            APIResult success = new APIResult() { Success = true, Message = null };
            APIResult error = new APIResult() { Success = false, Message = "" };
            int num = 0;
            try
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<TravelFood, FavTravelFood>();
                });
                IMapper mapper = config.CreateMapper();
                var source = travelFood;
                var dest = mapper.Map<TravelFood, FavTravelFood>(source);

                if (!FavTravelFoodExists(dest.ID))
                {
                    num = favTravelFoodService.Create(dest);
                }
                else
                {
                    error.Message = "資料已存在";
                }
            }
            catch (Exception ex)
            {
                error.Message = ex.Message.ToString();
            }

            if (num == 1)
                return success;
            else
                return error;
        }

        private bool FavTravelFoodExists(string id)
        {
            FavTravelFoodService favTravelFoodService = new FavTravelFoodService();
            return favTravelFoodService.GetAll().Count(e => e.ID == id) > 0;
        }
    }
}
