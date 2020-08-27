using slnMyStudy.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMyStudy.Service
{
    public class BulkService
    {
        BulkDao bulkDao;
        public BulkService()
        {
            bulkDao = new BulkDao();
        }
        public bool BulkInsert_0(Dictionary<string, DataTable> keyValuePairs, string connectionString)
        {
            return bulkDao.BulkInsert_0(keyValuePairs, connectionString);
        }
        public bool BulkInsert_1(Dictionary<string, DataTable> keyValuePairs, string connectionString)
        {
            return bulkDao.BulkInsert_1(keyValuePairs, connectionString);
        }
    }
}
