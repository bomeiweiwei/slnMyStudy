using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace slnMyStudy.Common
{
    public class FilesTool
    {
        public static DataTable ReadCsv(HttpPostedFileBase files, int columnCount)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            using (StreamReader sr = new StreamReader(files.InputStream))
            {
                string strLine = "";
                string[] aryLine = null;
                string[] tableHead = null;
                //int columnCount = 7;
                bool IsFirst = true;
                while ((strLine = sr.ReadLine()) != null)
                {
                    if (IsFirst)
                    {
                        tableHead = strLine.Split(',');
                        IsFirst = false;
                        columnCount = tableHead.Length;
                        for (int i = 0; i < columnCount; i++)
                        {
                            tableHead[i] = tableHead[i].Replace("\"", "");
                            System.Data.DataColumn dc = new System.Data.DataColumn(tableHead[i]);
                            dt.Columns.Add(dc);
                        }
                    }
                    else
                    {
                        aryLine = strLine.Split(',');
                        System.Data.DataRow dr = dt.NewRow();
                        for (int j = 0; j < columnCount; j++)
                        {
                            dr[j] = aryLine[j].Replace("\"", "");
                        }
                        dt.Rows.Add(dr);
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// List to DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(IList<T> Model)
        {
            try
            {
                PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
                DataTable table = new DataTable();
                for (int i = 0; i < props.Count; i++)
                {
                    PropertyDescriptor prop = props[i];
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                    //if ((prop.PropertyType) == typeof(Nullable<int>))
                    //{
                    //    DataColumn dc = table.Columns.Add(prop.Name, typeof(Int32));
                    //    dc.AllowDBNull = true;
                    //}
                    //else if ((prop.PropertyType) == typeof(Nullable<long>))
                    //{
                    //    DataColumn dc = table.Columns.Add(prop.Name, typeof(long));
                    //    dc.AllowDBNull = true;
                    //}
                    //else if ((prop.PropertyType) == typeof(Nullable<System.DateTime>))
                    //{
                    //    DataColumn dc = table.Columns.Add(prop.Name, typeof(System.DateTime));
                    //    dc.AllowDBNull = true;
                    //}
                    //else
                    //{
                    //    table.Columns.Add(prop.Name, prop.PropertyType);
                    //}
                }
                object[] values = new object[props.Count];
                foreach (T item in Model)
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        values[i] = props[i].GetValue(item);
                    }
                    table.Rows.Add(values);
                }

                return table;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
