using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace Ushtrime_4
{
    class Skedar
    {
        public String EmerSkedari { get; set; }

        public DataTable Lexo(String es)
        {
            StreamReader sr = new StreamReader(es);
            string[] headers = sr.ReadLine().Split(',');
            DataTable dt = new DataTable();
            foreach (string header in headers)
            {
                dt.Columns.Add(header);
            }
            while (!sr.EndOfStream)
            {
                string[] rows = sr.ReadLine().Split(',');
                DataRow dr = dt.NewRow();
                for (int i = 0; i < headers.Length; i++)
                {
                    dr[i] = rows[i];
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
