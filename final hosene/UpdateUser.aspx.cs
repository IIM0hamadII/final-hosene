using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_hosene
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string st = "";
        public string msg = "";
        public string sqlMsg = "";
        public string sqlSelect = "";
        public string sqlUpdate = "";
        public string yearList = "";
        public string cityStr = "";

        public string yearBorn = "";
        public string uName, fName, lName, yearB, email, prefix, phone, gender, pw;
        public string cities, city, hob1, hob2, hob3, hob4, hob5;

        protected string GetSt()
        {
            return st;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileName = "Database1.mdf";
            uName = Session["uName"].ToString();

            if (uName == "guest")
            {
                msg = "You are not a registered user in the system";
                msg += "<a href = 'signup.aspx'>[ continue ]</a>";
            }
            else
            {

                //--- שליפת פרטי המשתמש מטבלת הנתונים ---
                sqlSelect = " SELECT * FROM userTb1 WHERE uName= '" + uName + "'";
                DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);
                sqlMsg = sqlSelect;

                //------ ?בדיקה: האם המשתמש קיים במערכת  ---
                int length = table.Rows.Count;
                if (length == 0)
                {
                    msg = "You are not a registered user in the system";
                    msg += "<a href = 'signup.aspx'>[ continue ]</a>";
                }
                else
                {
                    //--- שליפת הנתונים מהרשומה ---
                    fName = table.Rows[0]["fName"].ToString().Trim(); // ללא תווי רווח
                    lName = table.Rows[0]["IName"].ToString().Trim();
                    yearB = table.Rows[0]["yearborn"].ToString().Trim();
                    prefix = table.Rows[0]["perfix"].ToString().Trim();
                    phone = table.Rows[0]["phone"].ToString().Trim();
                    gender = table.Rows[0]["gender"].ToString();
                    city = table.Rows[0]["city"].ToString().Trim();
                    hob1 = table.Rows[0]["ch1"].ToString().Trim();
                    hob2 = table.Rows[0]["ch2"].ToString().Trim();
                    hob3 = table.Rows[0]["ch3"].ToString().Trim();
                    hob4 = table.Rows[0]["ch4"].ToString().Trim();
                    hob5 = table.Rows[0]["ch5"].ToString().Trim();

                    int yBorn = Convert.ToInt16(table.Rows[0]["yearBorn"].ToString().Trim());

                    pw = table.Rows[0]["pass"].ToString().Trim();

                    //----- יצירת מחרוזת לשנת לידה ----
                    int year = DateTime.Now.Year; //---השנה הנוכחית 
                    int from = year - 50;
                    int to = year - 7;

                    //--- שנת לידה כרשימה נגללת - הצגת כל השנים בתחום---
                    //   int yearBorn = Convert.ToInt16(table.Rows[0]["yearBorn"]);
                    for (int i = from; i < to; i++)
                    {
                        if (i == yBorn) // ברירת מחדל - הצג את שנת הלידה של בני 16
                            yearBorn += $"<option value = '{i}' selected> {i} </option>";
                        else
                            yearBorn += "<option value = '" + i + "'>" + i + "</option>";
                    }





                    //--- יישוב מגורים כמערך ---
                    string[] cities = { "נצרת", "יפיע", "חיפה", "תל-אביב", "ירושלים", "נתניה", "ריינה" };
                    for (int i = 0; i < cities.Length; i++)
                    {
                        if (cities[i] == city)
                            cityStr += $"<option value ='{cities[i]}' selected>{cities[i]}</option>";
                        else
                            cityStr += $"<option value ='{cities[i]}'>{cities[i]}</option>";
                    }

                    //--- אחזור הפרטים המעודכנים מהטופס--
                    if (this.IsPostBack)
                    {
                        fName = Request.Form["fName"];
                        lName = Request.Form["lName"];
                        email = Request.Form["email"];
                        yearB = Request.Form["yearborn"];
                        city = Request.Form["city"];
                        prefix = Request.Form["perfix"];
                        phone = Request.Form["phoneNum"];
                        gender = Request.Form["gender"];
                        int yearBrn = int.Parse(Request.Form["yearBorn"]);
                        pw = Request.Form["pass"];

                        //--- טיפול בתחביבים ----
                        //אוסף החוגים שסומנו
                        string hobby = Request.Form["hobby"].ToString();

                        hob1 = "F";
                        hob2 = "F";
                        hob3 = "F";
                        hob4 = "F";
                        hob5 = "F";

                        //--- בדיקה: האם מחרוזת התחביבים מכילה את הערכים 1 - 5 ---
                        if (hobby.Contains("football")) hob1 = "T";
                        if (hobby.Contains("tennis")) hob2 = "T";
                        if (hobby.Contains("video gaming")) hob3 = "T";
                        if (hobby.Contains("run")) hob4 = "T";
                        if (hobby.Contains("sing")) hob5 = "T";

                        //---   בניית שאילתת העדכון ----
                        sqlUpdate = "UPDATE userTb1 ";
                        sqlUpdate += "SET fName = N'" + fName + "', ";
                        sqlUpdate += "IName = N'" + lName + "', ";
                        sqlUpdate += "email = '" + email + "', ";
                        sqlUpdate += "city = N'" + city + "', ";
                        sqlUpdate += "perfix = '" + prefix + "', ";
                        sqlUpdate += "phone = '" + phone + "', ";
                        sqlUpdate += "gender = '" + gender + "', ";
                        sqlUpdate += "yearBorn = " + yearBrn.ToString() + ", ";
                        sqlUpdate += "ch1 = '" + hob1 + "', ";
                        sqlUpdate += "ch2 = '" + hob2 + "', ";
                        sqlUpdate += "ch3 = '" + hob3 + "', ";
                        sqlUpdate += "ch4 = '" + hob4 + "', ";

                        sqlUpdate += "pass = '" + pw + "' ";
                        sqlUpdate += "WHERE uName = '" + uName + "'";

                        //---- הפעלתת שאילתת העדכון ---
                        Helper.DoQuery(fileName, sqlUpdate);

                        msg = "Succses";
                    }
                }
            }
        }
    }
}