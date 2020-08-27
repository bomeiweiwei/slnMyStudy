using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace slnMyStudy.Common
{
    public class FilesTool
    {
        public static System.Data.DataTable ReadCsv(HttpPostedFileBase files, int columnCount)
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
    }
}
