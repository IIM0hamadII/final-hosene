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
    public partial class DeleteRecord : System.Web.UI.Page
    {
        public string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"].ToString() == "no")
            {
                msg += "<h3>";
                msg += "you are not admin, ";
                msg += "you dont have promession here";
                msg += "</h3>";
                msg += "<a href='signin.aspx'><img pics/back.png' /></a>";
            }
            else
            {
                string fileName = "Database1.mdf";
                string uName = Request.QueryString["uName"].ToString();

                string sqlDelete = "DELETE FROM userTb1 WHERE uName ='" + uName + "'";

                Helper.DoQuery(fileName, sqlDelete);
            }
            Response.Redirect("DeleteUser.aspx");

        }
    }
}