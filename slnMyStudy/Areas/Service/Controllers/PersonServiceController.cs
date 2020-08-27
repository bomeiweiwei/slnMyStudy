using slnMyStudy.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace slnMyStudy.Areas.Service.Controllers
{
    public class PersonServiceController : ApiController
    {
        [HttpGet]
        public IHttpActionResult PeopleSearch([FromUri]string keyword)
        {
            PersonService service = new PersonService();
            List<string> list = service.PeopleSearch(keyword);
            return Ok(list);
        }
        [HttpPost]
        public IHttpActionResult KPeopleSearch()
        {
            PersonService service = new PersonService();
            List<string> list = service.GetPeople();//service.GetAll().Select(m => m.name).ToList();
            return Ok(list);
        }
       
    }
}
