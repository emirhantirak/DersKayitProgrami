using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection baglanti = new SqlConnection(@"Data Source=EMIRHANT\SQLEXPRESS;Initial Catalog=DbYazOkulu;Integrated Security=True");
    }
}
