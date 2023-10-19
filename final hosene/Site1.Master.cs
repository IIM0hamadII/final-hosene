using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_hosene
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public string loginMsg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            loginMsg = "<h3> Hi ";
            loginMsg += Session["userFName"].ToString();
            loginMsg += "<h3>";

           
            if (Session["admin"].ToString() == "yes") 
            {
                loginMsg += "[<a href='adminPage.aspx'>admin page</a>]";
                loginMsg += "[<a href='Logout.aspx'>logout</a>]";
            }
            else if (Session["uName"].ToString() == "guest") 
            {
                loginMsg += "[<a href='signin.aspx'>sign up</a>] <br />";
                loginMsg += "[<a href ='login.aspx'>logIn</a>]";
            }
            else
            {
                loginMsg += "[<a href='UpdateUser.aspx'>update informations</a>]";
                loginMsg += "[<a href='Logout.aspx'>logOut</a>]";
            }
        }

    }
}
