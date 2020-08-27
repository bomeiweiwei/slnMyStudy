using Newtonsoft.Json;
using slnMyStudy.Common;
using slnMyStudy.Models;
using slnMyStudy.Models.ViewModel;
using slnMyStudy.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace slnMyStudy.Controllers
{
    public class KendoUITestController : BaseController
    {
        readonly testService service;
        public KendoUITestController()
        {
            service = new testService();
        }
        /// <summary>
        /// 首頁
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var qData = service.GetAll().ToList();
            List<test> data = qData.Select(m => new test { id = m.id, @class = m.@class, title = m.title, author = m.author, hit_no = m.hit_no }).ToList();

            //int len = 12;
            foreach (var item in data)
            {
                //int strlen = item.title.Length;
                //if (strlen < len)
                //    item.title = item.title.Substring(0, strlen);
                //else
                //    item.title = item.title.Substring(0, len);
                //JSON.parse error=>換行 結尾空白 去除?
                item.title = item.title.Replace("\r\n","").Trim();
            }

            TestViewModel model = new TestViewModel
            {
                JsonData = JsonConvert.SerializeObject(data)
            };
            return View(model);
        }

        //public JsonResult Get_testData()
        //{
        //    testService service = new testService();
        //    var data = service.GetAll().ToList();
        //    return Json(data);
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Query()
        {
            List<string> ddlItemStr = new List<string>();
            List<string> strList = service.GetAll().Select(m => m.@class).Distinct().ToList();
            foreach (var item in strList)
            {
                string[] itemArr = item.Trim().Split('，');
                foreach (var s in itemArr)
                {
                    if (!ddlItemStr.Contains(s))
                    {
                        ddlItemStr.Add(s);
                    }
                }
            }
            ViewBag.ClassDDL = new SelectList(ddlItemStr);
            return View(service.GetAll());
        }

        public ActionResult ModifyGrid()
        {
            TestViewModel testSaveModel = new TestViewModel();
            //testSaveModel.JsonData = JsonConvert.SerializeObject(new List<test>());
            return View(testSaveModel);
        }

        [HttpPost]
        public JsonResult GetClassParam(string pName)
        {
            switch (pName)
            {
                case "class":
                    pName = "";
                    break;
                default:
                    pName = "";
                    break;
            }

            List<string> ddlItemStr = new List<string>();
            List<string> strList = service.GetAll().Select(m => m.@class).Distinct().ToList();
            foreach (var item in strList)
            {
                string[] itemArr = item.Trim().Split('，');
                foreach (var s in itemArr)
                {
                    if (!ddlItemStr.Contains(s))
                    {
                        ddlItemStr.Add(s);
                    }
                }
            }
            List<DdlParam> ddlList = new List<DdlParam>();
            foreach (var item in ddlItemStr)
            {
                ddlList.Add(new DdlParam { Param_Value = item, Param_Note = item });
            }
            return Json(ddlList);
        }

        [HttpPost]
        public JsonResult FilesUpload(int totalRecords, HttpPostedFileBase targetFiles)
        {
            ExecuteResult result = new ExecuteResult();
            if (targetFiles != null && targetFiles.ContentLength > 0)
            {
                string fileName = Path.GetFileName(targetFiles.FileName);
                string extension = Path.GetExtension(targetFiles.FileName);

                if (extension == ".csv")
                {
                    List<TestViewModel> resultList = new List<TestViewModel>();
                    
                    DataTable dt = FilesTool.ReadCsv(targetFiles, 7);
                    string[] columnNames = dt.Columns.Cast<System.Data.DataColumn>()
                                 .Select(x => x.ColumnName)
                                 .ToArray();
                    foreach (System.Data.DataRow dr in dt.Rows)
                    {
                        //SN設定前端Grid總列數+1 * -1，前端更新列時對應此sn
                        int sn = (++totalRecords) * -1;
                        resultList.Add(
                            new TestViewModel()
                            {
                                id = sn,
                                //時間
                                test_timeStr = DateTime.Now.ToString("yyyy/MM/dd HH:mm"),

                                //類別
                                @class = dr[columnNames[0]].ToString(),                                
                                //標題
                                title = dr[columnNames[1]].ToString(),
                                //摘要
                                summary = dr[columnNames[2]].ToString(),
                                //文章
                                article = dr[columnNames[3]].ToString(),
                                //作者
                                author = dr[columnNames[4]].ToString(),
                            });
                    }

                    result.Success = true;
                    result.Data = JsonConvert.SerializeObject(resultList);
                }
            }
            return Json(result);
        }

        /// <summary>
        /// 下載範例檔案
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult DownloadExample()
        {
            try
            {
                DateTime dt = DateTime.Now;
                System.Text.Encoding utf8WithoutBom = new System.Text.UTF8Encoding(true);

                byte[] fileBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    TextWriter tw = new StreamWriter(ms, utf8WithoutBom);
                    tw.WriteLine("類別,標題,摘要,文章,作者");
                    tw.WriteLine(string.Format("科技,測試標題,測試摘要,測試文章,測試作者"));
                    tw.Flush();
                    fileBytes = ms.ToArray();
                }
                string fileName = "example.csv";
                return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
            }
            catch (Exception)
            {
                return Content("<script>alert('error');window.close();</script>");
            }
        }
    }
}