using BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HOMEHORK_CRUD2_.AdminManager
{
    public partial class ProductAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Pid = Request["Pid"] + "";
                if (string.IsNullOrEmpty(Pid))
                {
                    Pid = "-1";
                }
                else
                {
                    int pid = int.Parse(Pid);
                    Product Tmp = Product.GetByid(pid);
                    if (Tmp != null)
                    {
                        TxtPname.Text = Tmp.Pname;
                        TxtPrice.Text = Tmp.Price + "";
                        TxtPdesc.Text = Tmp.Pdesc;
                        TxtPicname.Text = Tmp.Picname;
                        TxtCid.Text = Tmp.Cid + "";
                        HidPid.Value = Pid;
                    }
                    else
                    {
                        Pid = "-1";
                    }
                }
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
           /* string Sql = "";
            if (HidPid.Value == "-1")
            {
            }
            else
            {
                Sql = "Update T_Product set ";
                Sql += $" Pname=N'{TxtPname.Text}',";
                Sql += $" Price={TxtPrice.Text},";
                Sql += $" Pdesc=N'{TxtPdesc.Text}',";
                Sql += $" Picname=N'{TxtPicname.Text}',";
                Sql += $" Cid={TxtCid.Text} ";
                Sql += $" Where Pid={HidPid.Value}";
            }
            string ConnStr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            SqlConnection Conn = new SqlConnection(ConnStr);
            Conn.Open();
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            Cmd.ExecuteNonQuery();
            List<Product> ProductList = new List<Product>();
            Sql = "select * from T_Product";
            Cmd.CommandText = Sql;
            SqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {
                Product Tmp = new Product()
                {
                    Pid = int.Parse(Dr["Pid"] + ""),
                    Pname = Dr["Pname"] + "",
                    Price = float.Parse(Dr["Price"] + ""),
                    Pdesc = Dr["Pdesc"] + "",
                    Picname = Dr["Picname"] + "",
                    Cid = int.Parse(Dr["Cid"] + "")
                };
                ProductList.Add(Tmp);
            }
            Conn.Close();
            Application["Products"] = ProductList;
            Response.Redirect("ProductList.aspx");*/


            Product product = new Product();
            if(HidPid.Value == "-1")
            {
                product.Pid = -1;
            }
            else
            {
                product.Pid = int.Parse(HidPid.Value);
            }
            product.Pname = TxtPname.Text;
            product.Price = float.Parse(TxtPrice.Text);
            product.Pdesc = TxtPdesc.Text;
            product.Picname = TxtPicname.Text;
            product.Cid = int.Parse(TxtCid.Text);

            product.Save(product);
            Application["Products"] = Product.GetAll();

            Response.Redirect("ProductList.aspx");
        }
    }
}