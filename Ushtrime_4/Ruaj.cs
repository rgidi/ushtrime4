using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Ushtrime_4
{
    class Ruaj
    {
        public String adresa { get; set; }
        public String subjekti { get; set; }
        public String trupi { get; set; }

        public int ShtoNeTabele(String adresa, String subjekti, String trupi)
        {
            string strConnString = "Data Source=localhost; Initial Catalog=Ushtrime4_DB; Integrated Security=True";
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand();
                
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [Emails] VALUES(@adresa, @subjekti, @trupi)";
                    cmd.Parameters.AddWithValue("@adresa", adresa);
                    cmd.Parameters.AddWithValue("@subjekti", subjekti);
                    cmd.Parameters.AddWithValue("@trupi", trupi);
                    con.Open();
                    int r = cmd.ExecuteNonQuery();
                    con.Close();

                    if (r > 0) return r;
                    else return 0;
        }
    }
}
