using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HOMEHORK_CRUD2_
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Cities> CityList = (List<Cities>)Application["Cities"];
                for(int i = 0;i< CityList.Count; i++)
                {
                    DDLCity.Items.Add(new ListItem(CityList[i].CityName + ""));
                }
                for(int i = 0; i<CityList.Count; i++)
                {
                    DDLCityCode.Items.Add(new ListItem(CityList[i].CityCode + ""));
                }
            }
        }

        protected void button_Click(object sender, EventArgs e)
        {

            if (!check1.Checked)
            {
                label.Text = "You must accept the Terms of Use to continue.";
                return;
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}