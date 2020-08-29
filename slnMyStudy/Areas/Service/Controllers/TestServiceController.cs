using LinqKit;
using slnMyStudy.Models;
using slnMyStudy.Models.SaveModel;
using slnMyStudy.Models.ViewModel;
using slnMyStudy.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;

namespace slnMyStudy.Areas.Service.Controllers
{
    public class TestServiceController : BaseApiController
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
            ExecuteResult executeResult = new ExecuteResult();
            //System.Threading.Thread.Sleep(2000);
            testService service = new testService();
            //Grid資料一次新增
            if (data.Test_SaveList!=null && data.Test_SaveList.Any())
            {
                List<TestViewModel> addList = data.Test_SaveList.Where(m => m.id < 0).ToList();
                if (addList.Any())
                {
                    executeResult = service.AddListData(addList);
                    if (executeResult.Success)
                    {
                        executeResult.Message = "更新成功";
                    }
                    else
                        executeResult.Message = "更新失敗";
                }
                List<TestViewModel> updateList = data.Test_SaveList.Where(m => m.id > 0).ToList();
                if (updateList.Any())
                {
                    executeResult = service.UpdateListData(updateList);
                    if (executeResult.Success)
                    {
                        executeResult.Message = "更新成功";
                    }
                    else
                        executeResult.Message = "更新失敗";
                }
            }
            //單次新增
            else
            {
                executeResult = service.AddData(data);
                if (executeResult.Success)
                {
                    executeResult.Message = "新增成功";
                }
                else
                    executeResult.Message = "新增失敗";
            }
            return Ok(executeResult);
        }
    }
}
