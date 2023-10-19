using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_hosene
{
    public partial class showTable : System.Web.UI.Page
    {
        public string st = "";
        public string msg = "";
        public string sqlSelect = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"].ToString() == "no")
            {
                msg += "<div style='text-align: center; color: red;'>";
                msg += "<h3>you are not an admin</h3>";
                msg += "<a href='main.aspx'>[   continue  ]</a>";
                msg += "</div>";
            }
            else
            {
                string fileName = "Database1.mdf";
                string tableName = "userTb1";

                sqlSelect = "SELECT * FROM " + tableName;

                DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);

                int length = table.Rows.Count;
                if (length == 0) msg = "no guests";
                else
                {
                    st += "<tr>";
                    st += "<th style = 'text-align: center; border: 1px solid black; width: 100px;'>username</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; width: 80px;'>name</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; width: 60px;'>family name</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; width: 140px;'>email</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black;'>birthday</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; width: 60px;'>gender</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; width: 100px;'>cellphone</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; width: 100px;'>living area</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black;'>FootBall</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black;'>Tennis</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black;'>compGame</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black;'>dancing</th>";
                    st += "<th style = 'text-align: center; border: 1px solid black; width: 100px;'>password</th>";


                    st += "</tr>";
                }

                for (int i = 0; i < length; i++)
                {
                    st += "<tr>";
                    st += "<td style = 'text-align: center; border: 1px solid black;'>" + table.Rows[i]["uName"] + "</td>";
                    st += "<td style = 'border: 1px solid black;'>" + table.Rows[i]["fName"] + "</td>";
                    st += "<td style = 'border: 1px solid black;'>" + table.Rows[i]["IName"] + "</td>";
                    st += "<td style = 'border: 1px solid black; width: 60; text-align:left;'>" + table.Rows[i]["email"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black;'>" + table.Rows[i]["yearBorn"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black;'>" + table.Rows[i]["gender"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black;'>" + table.Rows[i]["perfix"] + table.Rows[i]["phone"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black;'>" + table.Rows[i]["city"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black;'>" + table.Rows[i]["ch1"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black;'>" + table.Rows[i]["ch2"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black;'>" + table.Rows[i]["ch3"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black;'>" + table.Rows[i]["ch4"] + "</td>";
                    st += "<td style = 'text-align: center; border: 1px solid black;'>" + table.Rows[i]["pass"] + "</td>";
                    st += "</tr>";
                }
                msg = "logged in:" + length + "people";
            }
        }
    }
}