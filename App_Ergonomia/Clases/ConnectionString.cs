using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Ergonomia.Clases
{
    static class DbConnection
    {
        private static string connectionText { get; set; }

        public static string GetConnection()
        {
            //Azure DB
            connectionText = "Data Source = siqueiros.database.windows.net ; Initial Catalog = SECETMA ; User id= msiqueiros;Password = QAZblitz1894?;";
            return connectionText;
        }
        
    }
}
