using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourierCRM.Windows;


namespace CourierCRM
{
    static class Program
    {
        /// <summary>
        /// Customer Relation Management program custom made for K-Town Express. Designed by Jesse Watson
        /// </summary>
        /// 


        public static MainWindow main;
        public static MainWindow shippers;
        public static MainWindow recievers;
        public static Invoices invoices;

        [STAThread]
        static void Main()
        {



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            main = new MainWindow("customers");
            shippers = new MainWindow("shippers");
            recievers = new MainWindow("recievers");
            invoices = new Invoices();

            ExcelExporter.create();

            Application.Run(main);
        }


    }
}
