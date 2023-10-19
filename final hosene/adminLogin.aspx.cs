using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_hosene
{
    public partial class adminLogin : System.Web.UI.Page
    {
        public string msg = "";
        public string sqlLogin = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["submit"] != null)
            {
                //---  שליפת הנתונים מהטופס ---  
                string mName = Request.Form["mName"];
                string mPw = Request.Form["mPw"];
                //---  קישור למסד הנתונים ---
                string fileName = "Database1.mdf";
                string tableName = "adminTB";

                //---  שאילתת האיחזור  ---
                sqlLogin = $"SELECT * FROM {tableName} WHERE name = '{mName}' AND password = '{mPw}'";
                DataTable table = Helper.ExecuteDataTable(fileName,sqlLogin);

                int length = table.Rows.Count;
                if (length == 0)
                {
                    msg += "<div style='text-align:center;'>";
                    msg += "<h3>you are not an admin! no premesion</h3>";
                    msg += "<a href='main.aspx'>[  continue  ]</a>";
                    msg += "</div>";
                }
                else
                {
                    //--- למשתמש Session יצירת אובייקט  ---
                    Session["admin"] = "yes";
                    Session["userFName"] = "admin";
                    Response.Redirect("main.aspx");
                }
            }

        }
    }
}