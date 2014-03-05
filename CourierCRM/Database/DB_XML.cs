using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;

namespace CourierCRM.Database
{
    class DB_XML
    {

        public static DB_XML xml_db;
        public string path;

        public DB_XML()
        {
            if (xml_db != null)
                xml_db = null;


            xml_db = this;

            path = Settings.get_setting("db_path") + "\\" + Settings.get_setting("db_database") + ".xml";


            Load_XML();
            
        }


        public void Update()
        {


            DB_MAIN.postgres.db_dataset.WriteXml(path);
        }

        public static void Start_XML()
        {
            new DB_XML();
        }

        void Load_XML()
        {

            if (File.Exists(path))
            {

                DB_MAIN.postgres.db_dataset.ReadXml(path);
            }
        }
    }
}
