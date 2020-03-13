using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ds_project;

namespace Ds_project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Variables.loaddata.Loaduserdata(ref Variables.userarr);
            Variables.loaddata.loadsectiondata(ref Variables.sectionlist);
            Variables.loaddata.loadbranddata(ref Variables.brandlist);
            Variables.loaddata.loaditems(ref Variables.brandlist,ref Variables.maxitem_id);
            Variables.loaddata.loadrequestdata(ref Variables.requestlist);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
