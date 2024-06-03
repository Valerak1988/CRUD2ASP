using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using BLL;
using DATA;

namespace DAL
{
    public class ProductDAL
    {
        public static List<Product> GetAll()
        {
            DbContext Db = new DbContext();
            string Sql = "Select * from T_product";
            DataTable Dt = Db.Execute(Sql);
            List<Product> ProductList = new List<Product>();
            for (int i = 0;i < Dt.Rows.Count; i++)
            {
                Product t = new Product() 
                {
                    Pid = int.Parse(Dt.Rows[i]["Pid"]+""),
                    Pname = Dt.Rows[i]["Pname"] + "",
                    Price = float.Parse(Dt.Rows[i]["Price"] + ""),
                    Pdesc = Dt.Rows[i]["Pdesc"] + "",
                    Cid = int.Parse(Dt.Rows[i]["Cid"] + ""),
                    Picname = Dt.Rows[i]["Picname"] + "",
                    AddDate = DateTime.Parse(Dt.Rows[i]["AddDate"]+"")
                };
                ProductList.Add(t);
            }
            Db.Close();
            return ProductList;
        }
        public static Product GetById(int Id)
        {
            DbContext Db = new DbContext();
            string Sql = $"Select * from T_product where Pid={Id}";
            DataTable Dt = Db.Execute(Sql);
            Product Tmp = null;
            if (Dt.Rows.Count > 0)
            {
                Tmp = new Product()
                {
                    Pid = int.Parse(Dt.Rows[0]["Pid"] + ""),
                    Pname = Dt.Rows[0]["Pname"] + "",
                    Price = float.Parse(Dt.Rows[0]["Price"] + ""),
                    Pdesc = Dt.Rows[0]["Pdesc"] + "",
                    Cid = int.Parse(Dt.Rows[0]["Cid"] + ""),
                    Picname = Dt.Rows[0]["Picname"] + "",
                    AddDate = DateTime.Parse(Dt.Rows[0]["AddDate"] + "")
                };
            }
            Db.Close();
            return Tmp;
        }
        public static Product Save(Product Product)
        {
            string Sql = "";
            if(Product.Pid == -1)
            {
                Sql = "insert into T_Product (Pname,Price,Pdesc,Picname,Cid) values ";
                Sql += $" (N'{Product.Pname}',{Product.Price},N'{Product.Pdesc}',N'{Product.Pdesc}',{Product.Cid})";
            }
            else
            {
                Sql = "Update T_Product set ";
                Sql += $" Pname=N'{Product.Pname}',";
                Sql += $" Price={Product.Price},";
                Sql += $" Pdesc=N'{Product.Pdesc}',";
                Sql += $" Picname=N'{Product.Picname}',";
                Sql += $" Cid={Product.Cid} ";
                Sql += $" Where Pid={Product.Pid}";
            }
            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(Sql);
            GetAll();
            return Product;
        }
    }
}