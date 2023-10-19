using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_hosene
{
    public partial class login : System.Web.UI.Page
    {

        public string msg = "";
        public string sqlLogin = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Form["submit"] != null)
            {

                string mName = Request.Form["uName"];
                string mPw = Request.Form["Pass"];

                string fileName = "Database1.mdf";
                string tableName = "userTb1";

                sqlLogin = $"SELECT * FROM {tableName} WHERE uName =  '{mName}' AND pass = '{mPw}'";

                DataTable table = Helper.ExecuteDataTable(fileName, sqlLogin);

                int length = table.Rows.Count;
                if (length == 0)
                    msg = "username not found";
                else
                {
                    //--- עדכון מונה מבקרים  ---
                    Application.Lock();
                    Application["counter"] = (int)Application["counter"] + 1;
                    Application.UnLock();

                    //--- למשתמש Session יצירת אובייקט  ---
                    Session["uName"] = table.Rows[0]["uName"];
                    Session["userFName"] = table.Rows[0]["fName"];
                    Response.Redirect("main.aspx");
                }
            }
        }
    }
}
