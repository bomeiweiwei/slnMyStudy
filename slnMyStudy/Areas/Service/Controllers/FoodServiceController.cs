using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using slnMyStudy.Models;
using slnMyStudy.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Http;

namespace slnMyStudy.Areas.Service.Controllers
{
    public class FoodServiceController : BaseApiController
    {
        readonly List<TravelFood> travelFoods = new List<TravelFood>();
        public FoodServiceController()
        {
            using (StreamReader r = new StreamReader(HttpContext.Current.Server.MapPath("/MyJson/ODwsvTravelFood.json")))
            {
                string json = r.ReadToEnd();
                travelFoods = JsonConvert.DeserializeObject<List<TravelFood>>(json);
            }
        }

        // GET: api/FoodService
        public IEnumerable<TravelFood> Get()
        {
            return travelFoods;
        }

        // GET: api/FoodService/5
        public IEnumerable<string> Get(string keyword)
        {
            if (keyword != null)
                return travelFoods.Where(m => m.Name.Contains(keyword)).Select(m => m.Name).DefaultIfEmpty("").ToList();
            else
                return new List<string>();
        }

        // POST: api/FoodService
        [HttpPost]
        public async System.Threading.Tasks.Task<APIResult> PostAsync([FromUri]TravelFood travelFood)
        {
            APIResult error = new APIResult() { Success = false, Message = "餐館不存在" };
            if (travelFood.ID == null)
            {
                return error;
            }
            else
            {
                if (travelFoods.Where(m => m.ID == travelFood.ID).Any())
                {
                    travelFood = travelFoods.Where(m => m.ID == travelFood.ID).Select(o => new TravelFood { ID = o.ID, Name = o.Name }).FirstOrDefault();

                    APIResult fooAPIResult;
                    using (HttpClientHandler handler = new HttpClientHandler())
                    {
                        using (HttpClient client = new HttpClient(handler))
                        {
                            try
                            {
                                #region 呼叫遠端 Web API
                                string FooUrl = $"https://localhost:44362//api/FavProcessService";
                                HttpResponseMessage response = null;

                                #region  設定相關網址內容
                                var fooFullUrl = $"{FooUrl}";

                                // Accept 用於宣告客戶端要求服務端回應的文件型態 (底下兩種方法皆可任選其一來使用)
                                //client.DefaultRequestHeaders.Accept.TryParseAdd("application/json");
                                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                                // Content-Type 用於宣告遞送給對方的文件型態
                                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

                                string userName = User.Identity.GetUserName();
                                string userPassword = UserManager.Users.ToList().Where(m => m.UserName == userName).Select(m => m.PasswordHash).DefaultIfEmpty("").First();

                                //另一端DB用自訂資料庫tMember0 .0，因為我懶得加驗證
                                string username = "admin";
                                string password = "1234";
                                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                                    Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes($"{username}:{password}")));

                                var fooJSON = JsonConvert.SerializeObject(travelFood);
                                // https://msdn.microsoft.com/zh-tw/library/system.net.http.stringcontent(v=vs.110).aspx
                                using (var fooContent = new StringContent(fooJSON, Encoding.UTF8, "application/json"))
                                {
                                    response = await client.PostAsync(fooFullUrl, fooContent);
                                }
                                #endregion
                                #endregion

                                #region 處理呼叫完成 Web API 之後的回報結果
                                if (response != null)
                                {
                                    if (response.IsSuccessStatusCode == true)
                                    {
                                        // 取得呼叫完成 API 後的回報內容
                                        String strResult = await response.Content.ReadAsStringAsync();
                                        fooAPIResult = JsonConvert.DeserializeObject<APIResult>(strResult, new JsonSerializerSettings { MetadataPropertyHandling = MetadataPropertyHandling.Ignore });
                                    }
                                    else
                                    {
                                        fooAPIResult = new APIResult
                                        {
                                            Success = false,
                                            Message = string.Format("Error Code:{0}, Error Message:{1}", response.StatusCode, response.RequestMessage)
                                        };
                                    }
                                }
                                else
                                {
                                    fooAPIResult = new APIResult
                                    {
                                        Success = false,
                                        Message = "應用程式呼叫 API 發生異常"
                                    };
                                }
                                #endregion
                            }
                            catch (Exception)
                            {
                                fooAPIResult = new APIResult
                                {
                                    Success = false,
                                    Message = "應用程式呼叫 API 發生異常"//ex.Message,
                                };
                            }
                        }
                    }

                    return fooAPIResult;
                }
                else
                    return error;
            }
        }
    }
}
