using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_hosene
{
    public partial class adminPage : System.Web.UI.Page
    {
        public string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"].ToString() == "no")
            {
                msg += "<div style='text-align: center; color: red;'>";
                msg += "<h3>you are not an admin</h3>";
                msg += "<a href='main.aspx'>[   continue   ]</a>";
                msg += "</div>";
            }
            else
            {
                msg += "<h3><a href='DeleteUser.aspx'>delete user</a></h3>";
                msg += "<h3><a href='ShowTable.aspx'>guests table</a></h3>";

                msg += "<br /><br />";

                msg += "<h3><a href='SelectByLastName.aspx'>all last names that contain r </a></h3>";
                msg += "<h3><a href='SelectByFirstName.aspx'>all names that contain r </a></h3>";

                msg += "<h3><a href='SelectGmailAndCity.aspx'>all guest thst live in haifa or nazareth  and their mail is gmail  </a></h3>";
                msg += "<h3><a href='SelectByGenderAndYearB.aspx'>al guests that were born between 2005-2008 </a></h3>";
            }
        }
    }
}