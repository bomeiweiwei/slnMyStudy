using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace slnMyStudy.Dao
{
    public class BulkDao
    {
        /// <summary>
        /// 大量資料新增，外層可嘗試TransactionScope
        /// </summary>
        /// <param name="keyValuePairs"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public bool BulkInsert_0(Dictionary<string, DataTable> keyValuePairs, string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection.ConnectionString, SqlBulkCopyOptions.CheckConstraints | SqlBulkCopyOptions.Default | SqlBulkCopyOptions.UseInternalTransaction))
                    {
                        bulkCopy.BatchSize = 100000;
                        bulkCopy.BulkCopyTimeout = 3600;

                        foreach (KeyValuePair<string, DataTable> key in keyValuePairs)
                        {
                            DataTable dt = key.Value;
                            bulkCopy.DestinationTableName = key.Key;
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                bulkCopy.ColumnMappings.Add(dt.Columns[i].ColumnName, dt.Columns[i].ColumnName);
                            }
                            bulkCopy.WriteToServer(dt);
                        }
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 大量資料新增 with Transaction
        /// </summary>
        /// <param name="keyValuePairs"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public bool BulkInsert_1(Dictionary<string, DataTable> keyValuePairs, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction sqlTrans = connection.BeginTransaction();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection, SqlBulkCopyOptions.Default, sqlTrans))
                {
                    bulkCopy.BatchSize = 100000;
                    bulkCopy.BulkCopyTimeout = 3600;
                    try
                    {
                        foreach (KeyValuePair<string, DataTable> key in keyValuePairs)
                        {
                            DataTable dt = key.Value;
                            bulkCopy.DestinationTableName = key.Key;
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                bulkCopy.ColumnMappings.Add(dt.Columns[i].ColumnName, dt.Columns[i].ColumnName);
                            }
                            bulkCopy.WriteToServer(dt);
                        }
                    }
                    catch (Exception)
                    {
                        sqlTrans.Rollback();
                        return false;
                    }
                    sqlTrans.Commit();
                    return true;
                }
            }
        }
    }
}
