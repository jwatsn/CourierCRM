using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Data;
using CourierCRM.Database;


namespace CourierCRM
{
    class ExcelExporter
    {

        static ExcelExporter exporter;
        FileStream stream;
        XmlReader xml_reader;


        

        public ExcelExporter()
        {

            //stream = File.Open("xls.xml",FileMode.Open);
            
            
           
        }

        public static void create()
        {
            if (exporter != null)
                exporter = null;

            exporter = new ExcelExporter();
        }

        public static void export_invoice(FileStream stream2, string id)
        {
            
            XmlDocument doc = new XmlDocument();
            doc.Load("xls.xml");
            XmlNode tableNode = doc.ChildNodes[2].ChildNodes[4].ChildNodes[0];


            int column_count = Int16.Parse(tableNode.Attributes["ss:ExpandedColumnCount"].Value);
            int row_count = Int16.Parse(tableNode.Attributes["ss:ExpandedRowCount"].Value);

            double subtotal = 0;

            DataRow[] rows = DB_MAIN.postgres.db_dataset.Tables["invoices"].Select("id = '" + id + "'");
            DataRow[] client_rows = DB_MAIN.postgres.db_dataset.Tables["customers"].Select("name = '" + rows[0]["customer"].ToString() + "'");
            DataRow[] order_rows = DB_MAIN.postgres.db_dataset.Tables["orders"].Select("invoice_id = '" + id + "'");
            
            for (int y = 0; y < row_count; y++)
            {

                if (tableNode.ChildNodes[y + column_count] == null)
                    break;

                XmlNodeList list = tableNode.ChildNodes[y + column_count].ChildNodes;



                for (int x = 0; x < list.Count; x++)
                {
                    XmlNode node = list[x];


                    if (node.InnerText == "#client_name")
                    {

                        


                        
                        foreach (DataRow r in rows)
                        {
                            //customer name
                            node.ChildNodes[0].InnerText = r["customer"].ToString();


                            XmlNode next = tableNode.ChildNodes[y + column_count].NextSibling;                  
                            next.ChildNodes[0].ChildNodes[0].InnerText = rows[0]["client_attn"].ToString();

                            next = next.NextSibling;
                            next.ChildNodes[0].ChildNodes[0].InnerText = client_rows[0]["street_address"].ToString();

                            next = next.NextSibling;
                            next.ChildNodes[0].ChildNodes[0].InnerText = client_rows[0]["city"].ToString();

                            next = next.NextSibling;
                            next.ChildNodes[0].ChildNodes[0].InnerText = client_rows[0]["postal_code"].ToString();

                        }
                    }

                    if (node.InnerText == "#orders")
                    {
                        XmlNode next = node;

                        foreach (DataRow row in order_rows)
                        {

                            subtotal += Double.Parse(row["price"].ToString());

                            next.InnerXml = "<Data ss:Type=\"String\">"+row["date"].ToString()+"</Data>";
                            next = next.NextSibling;

                            next.InnerXml = "<Data ss:Type=\"String\">"+row["num_items"].ToString()+"</Data>";
                            next = next.NextSibling;

                            next.InnerXml = "<Data ss:Type=\"String\">" + row["shipper"].ToString() + "</Data>";
                            next = next.NextSibling;

                            next.InnerXml = "<Data ss:Type=\"String\">" + row["reciever"].ToString() + "</Data>";
                            next = next.NextSibling;

                            next.InnerXml = "<Data ss:Type=\"String\">" + row["price"].ToString() + "</Data>";


                            next = next.ParentNode.NextSibling.ChildNodes[0];

                            DataRow shipper = DB_MAIN.postgres.db_dataset.Tables["shippers"].Select("name = '" + row["shipper"] + "'")[0];
                            DataRow reciever = DB_MAIN.postgres.db_dataset.Tables["recievers"].Select("name = '" + row["reciever"] + "'")[0];

                            next = next.NextSibling;
                            next = next.NextSibling;

                            next.InnerXml = "<Data ss:Type=\"String\">" + shipper["street_address"] + " " + shipper["city"] + "</Data>";
                            next = next.NextSibling;
                            next.InnerXml = "<Data ss:Type=\"String\">" + reciever["street_address"] + " " + reciever["city"] + "</Data>";

                            next = next.ParentNode.NextSibling.ChildNodes[0];
                            next = next.ParentNode.NextSibling.ChildNodes[0];
                           

                        }
                    }

                    if (node.InnerText == "#subtotal")
                    {
                        node.ChildNodes[0].InnerText = "" + subtotal;
                    }

                    if (node.InnerText == "#HST")
                    {
                        node.ChildNodes[0].InnerText = "" + Math.Round(subtotal*0.13,2);                       
                    }

                    if (node.InnerText == "#total")
                    {
                        node.ChildNodes[0].InnerText = "" + Math.Round(subtotal * 1.13,2);
                    }
                    if (node.InnerText == "#statement_id")
                    {
                        foreach(DataRow r in rows)
                        {
                            node.ChildNodes[0].InnerText = "" + r["statement_id"];
                        }
                    }
                    if (node.InnerText == "#bn_num")
                    {
                        foreach (DataRow r in rows)
                        {
                            node.ChildNodes[0].InnerText = "BN:" + r["bn_num"];
                        }
                    }
                    if (node.InnerText == "#due_date")
                    {
                        foreach (DataRow r in rows)
                        {
                            node.ChildNodes[0].InnerText = "" + r["due_date"];
                        }
                    }
                }
            }
             

            

            

            doc.Save(stream2);

            


            
            stream2.Close();
            //save.Save(path);
        }

    }
}
