using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HOMEHORK_CRUD2_.AdminManager
{
    public partial class City : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Cities> CityList = (List<Cities>)Application["Cities"];
            RptCity.DataSource = CityList;
            RptCity.DataBind();
        }
    }
}
