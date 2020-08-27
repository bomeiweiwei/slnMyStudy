using LinqKit;
using slnMyStudy.Models;
using slnMyStudy.Models.SaveModel;
using slnMyStudy.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace slnMyStudy.Areas.Service.Controllers
{
    public class TestServiceController : ApiController
    {
        [HttpPost]
        [Obsolete]
        public IHttpActionResult TestDataSearch([FromBody] ApiSearchModel args)
        {
            testService service = new testService();
            List<test> list = new List<test>();
            var predicate = PredicateBuilder.True<test>();
            var predicateClass = PredicateBuilder.False<test>();
            if (!string.IsNullOrWhiteSpace(args.searchStart_time))
            {
                DateTime dt = DateTime.Parse(args.searchStart_time);
                predicate = predicate.And(p => p.test_time.Value >= dt);
            }
            if (!string.IsNullOrWhiteSpace(args.searchEnd_time))
            {
                DateTime dt = DateTime.Parse(args.searchEnd_time);
                predicate = predicate.And(p => p.test_time.Value <= dt);
            }
            if (!string.IsNullOrWhiteSpace(args.searchTest_time))
            {
                DateTime dt = DateTime.Parse(args.searchTest_time);
                predicate = predicate.And(p => p.test_time.Value >= dt);
            }
            if (!string.IsNullOrWhiteSpace(args.searchTitle))
            {
                predicate = predicate.And(p => p.title.Contains(args.searchTitle));
            }
            bool flag = false;
            if (args.searchClassName.Length > 0)
            {
                //predicate = predicate.And(p => p.@class.Contains(args.searchClassName));
                foreach (var className in args.searchClassName)
                {
                    if (!string.IsNullOrEmpty(className))
                    {
                        predicateClass = predicateClass.Or(p => p.@class.Contains(className));
                        flag = true;
                    }
                }
            }
            if (!flag)
                list = service.Get(predicate).ToList();
            else
            {
                list = service.Get(predicate).Where(predicateClass).ToList();
            }
            var query = list.Select(m => new { m.id, m.test_time, m.@class, m.title, m.author, m.hit_no, m.article, m.summary }).ToList();
            return Ok(query);
        }

        [HttpPost]
        public IHttpActionResult Get_testData()
        {
            testService service = new testService();
            var data = service.GetAll().ToList();
            return Ok(data);
        }

        [HttpPost]
        public IHttpActionResult SaveData(TestSaveModel data)
        {
            testService service = new testService();
            return Ok("Service預設處理成功");
        }
    }
}
