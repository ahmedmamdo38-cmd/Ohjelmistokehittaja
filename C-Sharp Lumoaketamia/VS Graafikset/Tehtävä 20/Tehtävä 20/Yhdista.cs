using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using Org.BouncyCastle.Asn1.Cmp;

namespace Tehtävä_20
{
    internal class Yhdista
    {
        //public string yhteyslause()
        //{
        //    return "datasource=localhost; port=3306;username=root;passwors=;database=hotelli";
        //}

        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=opiskelijat");

        public MySqlConnection otaYhteys()
        {
            return yhteys; 
        }


        public void avaaYhteys()
        {
            if(yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        public void suljeYhteys()
        {
            if(yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }


       
    }


}
