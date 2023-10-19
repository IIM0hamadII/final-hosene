using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace final_hosene
{
    public partial class signin : System.Web.UI.Page
    {
        public string st = "";
        public string yrBorn = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["submit"] != null)
            {

                //--- שליפת המידע שהגיע מהטופס לתוך משתנים
                string uName = Request.Form["uName"];
                string fName = Request.Form["fName"];
                string lName = Request.Form["lName"];
                string email = Request.Form["email"];
                string yearBorn = Request.Form["yearBorn"];
                string gender = Request.Form["gender"];
                string prefix = Request.Form["perfix"];
                string phone = Request.Form["phoneNum"];
                string city = Request.Form["city"];
                string hobies = Request.Form["hobies"];
                string passW = Request.Form["pw"];
                //تحويل سنة الولادة كعدد
                int yearB = int.Parse(yearBorn);

                //فحص الهوايات وتحويلها لصدق او كذب
                char ch1 = 'F', ch2 = 'F', ch3 = 'F', ch4 = 'F', ch5 = 'F';
                if (hobies.Contains("football")) ch1 = 'T';
                if (hobies.Contains("tennis")) ch2 = 'T';
                if (hobies.Contains("video gaming")) ch3 = 'T';
                if (hobies.Contains("run")) ch4 = 'T';
                if (hobies.Contains("sing")) ch5 = 'T';

                //ربط لقاعدة البيانات
                string fileName = "Database1.mdf";
                string tableName = "userTb1";

                //فحص اذا كان اسم المستخدم مستعمل بقاعدة البيانات
                string sqlSelect = "SELECT * FROM " + tableName + " WHERE uName ='" + uName + "'";
                string sqlInsert;

                if (Helper.IsExist(fileName, sqlSelect))
                {
                    st = "user name has been taken";
                }
                else
                {
                    sqlInsert = "INSERT INTO userTb1";
                    sqlInsert += " VALUES ('" + uName + "','" + fName + "','" + lName + "','" + email + "','";
                    sqlInsert += gender + "','" + yearB +  "','" + prefix + "','" + phone + "','" + city + "','";
                    sqlInsert += ch1 + "','" + ch2 + "','" + ch3 + "','" + ch4 + "','" + ch5 + "','" + passW+ "')";
                Helper.DoQuery(fileName, sqlInsert);



                    st = "<table border='1' align = 'center' dir='ltr'>";

                    st += "<tr><th colspan='2'>הפרטים שהתקבלו מהשרת</th></tr>";
                    st += "<tr><td>user name:</td><td>" + uName + "</td></tr>";
                    st += $"<tr><td>first name:</td><td>{fName}</td></tr>";
                    st += $"<tr><td>last name:</td><td>{lName}</td></tr>";
                    st += $"<tr><td>email:</td><td>{email}</td></tr>";
                    st += $"<tr><td>yearBorn:</td><td>{yearBorn}</td></tr>";
                    st += $"<tr><td>gender:</td><td>{gender}</td></tr>";
                    st += $"<tr><td>phoneNum:</td><td>{prefix} - {phone}</td></tr>";
                    st += $"<tr><td>city:</td><td>{city}</td></tr>";

                    st += $"<tr><td>hobies:</td><td> {hobies}</td></tr>";

                    st += "</table>";
                }
            }


            int year = DateTime.Now.Year;
            int from = year - 30;
            int to = year - 10;
            for (int i = from; i < to; i++)
            {
                yrBorn += "<option value = '" + i + "'>" + i + "</option>";
            }



        }
    }
 }
