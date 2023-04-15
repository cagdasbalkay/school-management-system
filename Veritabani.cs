using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementProject
{
    public static class Veritabani
    {
        public static SqlConnection Baglan()
        {
            SqlConnection baglanti = new SqlConnection("Server=localhost;Database=SCHOOL;Trusted_Connection=True;\r\n");

            baglanti.Open();
            return baglanti;
        }
    }
}

        
    

