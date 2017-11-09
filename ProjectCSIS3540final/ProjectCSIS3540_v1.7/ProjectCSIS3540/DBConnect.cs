using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCSIS3540
{
    class DBConnect
    {
        private string HOST, DB, UID, PASSWD;

        public DBConnect()
        {
            HOST = "ec2-52-201-212-193.compute-1.amazonaws.com";
            DB = "s2016_user32";
            UID = "s2016_user32";
            PASSWD = "s2016_user32";
        }

        public override string ToString()
        {
            string connectionString;

            connectionString = "SERVER=" + HOST + ";DATABASE=" +
            DB + ";" + "UID=" + UID + ";" + "PASSWORD=" + PASSWD + ";" + "Convert Zero Datetime = True;";

            return connectionString;
        }
    }
}
