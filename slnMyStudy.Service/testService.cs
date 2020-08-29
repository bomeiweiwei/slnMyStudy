using AutoMapper;
using AutoMapper.EquivalencyExpression;
using slnMyStudy.Common;
using slnMyStudy.Dao;
using slnMyStudy.Models;
using slnMyStudy.Models.SaveModel;
using slnMyStudy.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace slnMyStudy.Service
{
    public class testService : BaseService<test>
    {
        readonly string connStr = "";
        public testService() : base(DBEntity.test)
        {
            connStr = ConfigTool.GetDBConnectionString("DataTransConn");           
        }

        public ExecuteResult AddData(TestSaveModel model)
        {
            ExecuteResult executeResult = new ExecuteResult();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TestSaveModel, test>()
                //.ForMember(dest => dest.test_time, opts => opts.MapFrom(s => DateTime.Now))
                .ForMember(dest => dest.test_time, opts => opts.MapFrom(s => s.test_time))
                .ForMember(dest => dest.@class, opts => opts.MapFrom(s => s.searchClassName))
                .ForMember(dest => dest.title, opts => opts.MapFrom(s => s.title))
                .ForMember(dest => dest.summary, opts => opts.MapFrom(s => s.summary))
                .ForMember(dest => dest.article, opts => opts.MapFrom(s => s.article))
                .ForMember(dest => dest.author, opts => opts.MapFrom(s => s.author))
                ;
            });
            IMapper mapper = config.CreateMapper();
            test saveModel = mapper.Map<TestSaveModel, test>(model);
            try
            {
                int count = Create(saveModel);
                if (count == 1)
                {
                    executeResult.Success = true;
                }
            }
            catch (Exception ex)
            {
                executeResult.Message = ex.Message;
            }
            return executeResult;
        }

        public ExecuteResult AddListData(List<TestViewModel> addList)
        {
            ExecuteResult executeResult = new ExecuteResult();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TestViewModel, test>()
                //.ForMember(dest => dest.test_time, opts => opts.MapFrom(s => DateTime.Now))
                .ForMember(dest => dest.test_time, opts => opts.MapFrom(s => s.test_time))
                .ForMember(dest => dest.@class, opts => opts.MapFrom(s => s.@class))
                .ForMember(dest => dest.title, opts => opts.MapFrom(s => s.title))
                .ForMember(dest => dest.summary, opts => opts.MapFrom(s => s.summary))
                .ForMember(dest => dest.article, opts => opts.MapFrom(s => s.article))
                .ForMember(dest => dest.author, opts => opts.MapFrom(s => s.author))
                ;
            });
            IMapper mapper = config.CreateMapper();
            List<test> saveList = mapper.Map<List<TestViewModel>, List<test>>(addList).ToList();

            BulkService bulkService = new BulkService();
            DataTable dt = FilesTool.ToDataTable(saveList);
            Dictionary<string, DataTable> keyValuePairs = new Dictionary<string, DataTable>
            {
                { "test", dt }
            };
            executeResult.Success= bulkService.BulkInsert_1(keyValuePairs, connStr);
            return executeResult;
        }

        public ExecuteResult UpdateListData(List<TestViewModel> updateList)
        {
            ExecuteResult executeResult = new ExecuteResult();
            TestDao dao = new TestDao();
            //entity接下來要帶入function，需一樣
            testEntities entity = (testEntities)base.GetCurrentContext();
            List<int> idList = updateList.Select(m => m.id).ToList();
            List<test> taregtList = entity.test.Where(m => idList.Contains(m.id)).ToList();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TestViewModel, test>().EqualityComparison((odto, o) => odto.id == o.id).ForMember(dest => dest.hit_no, opts => opts.MapFrom(s => 0))
                .ForMember(dest => dest.hit_no, opts => opts.Ignore())
                .ForMember(dest => dest.get_no, opts => opts.Ignore())
                .ForMember(dest => dest.email_no, opts => opts.Ignore())
                .ForMember(dest => dest.approved, opts => opts.Ignore());
            });
            IMapper mapper = config.CreateMapper();
            //不能重新對應
            /*taregtList =*/ mapper.Map(updateList, taregtList).ToList();
            try
            {
                foreach (var item in taregtList)
                {
                    //用Dao的Update會GG
                    //改用https://dev-felix72.blogspot.com/2017/12/be-caution-about-modified-entity-state-after-automapping-when-doing-ef-updating.html
                    int count = dao.UpdateData(item,  entity);
                    //資料有異動過為1，沒異動為0
                    //if (count != 1)
                    //    executeResult.Success = false;
                    //else
                    //    executeResult.Success = true;
                    //if (!executeResult.Success)
                    //{
                    //    break;
                    //}
                }
                executeResult.Success = true;
            }
            catch (Exception ex)
            {
                executeResult.Message = ex.Message;
                return executeResult;
            }
            return executeResult;
        }
    }
}
