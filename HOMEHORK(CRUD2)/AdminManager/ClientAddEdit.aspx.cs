using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace HOMEHORK_CRUD2_.AdminManager
{
    public partial class ClientAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Uid = Request["Uid"] + "";
                if (string.IsNullOrEmpty(Uid))
                {
                    Uid = "-1";
                }
                else
                {
                    int uid = int.Parse(Uid);
                    List<Client> ClientList = (List<Client>)Application["Clients"];
                    for(int i = 0; i < ClientList.Count; i++)
                    {
                        if (ClientList[i].Uid == uid)
                        {
                            TxtFirstName.Text = ClientList[i].FirstName;
                            TxtLastName.Text = ClientList[i].LastName;
                            TxtCity.Text = ClientList[i].City;
                            TxtCityCode.Text = ClientList[i].CityCode + "";
                            TxtPhone.Text = ClientList[i].Phone;
                            TxtEmail.Text = ClientList[i].Email;
                            HidUid.Value = Uid;
                        }
                    }
                }
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            if(HidUid.Value == "-1")
            {
                client.Uid = -1;
            }
            else
            {
                client.Uid = int.Parse(HidUid.Value);
            }
            client.FirstName = TxtFirstName.Text;
            client.LastName = TxtLastName.Text;
            client.City = TxtCity.Text;
            client.CityCode = int.Parse(TxtCityCode.Text);
            client.Phone = TxtPhone.Text;
            client.Email = TxtEmail.Text;

            client.Save(client);
            Application["Clients"] = Client.GetAll();

            Response.Redirect("ClientList.aspx");
        }
    }
}