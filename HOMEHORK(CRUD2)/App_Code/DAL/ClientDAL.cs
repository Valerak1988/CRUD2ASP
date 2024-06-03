using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Web;
using BLL;
using DATA;
using HOMEHORK_CRUD2_;
using HOMEHORK_CRUD2_.AdminManager;

namespace DAL
{
    public class ClientDAL
    {
        public static List<Client> GetAll()
        {
            DbContext db = new DbContext();
            string Sql = "Select * From T_Client";
            DataTable Dt = db.Execute(Sql);
            List<Client> ClientList = new List<Client>();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Client t = new Client()
                {
                    Uid = int.Parse(Dt.Rows[i]["Uid"] + ""),
                    FirstName = Dt.Rows[i]["FirstName"] + "",
                    LastName = Dt.Rows[i]["LastName"] + "",
                    City = Dt.Rows[i]["City"] + "",
                    CityCode = int.Parse(Dt.Rows[i]["CityCode"] + ""),
                    Phone = Dt.Rows[i]["Phone"] + "",
                    Email = Dt.Rows[i]["Email"]+"",
                    AddDate = DateTime.Parse(Dt.Rows[i]["AddDate"]+"")
                };
                ClientList.Add(t);
            }
            db.Close();
            return ClientList;
        }
        public static Client GetById(int id)
        {
            DbContext Db = new DbContext();
            string Sql = $"Select * from T_Client where Uid={id}";
            DataTable Dt = Db.Execute(Sql);
            Client Tmp = null;
            if(Dt.Rows.Count > 0)
            {
                Tmp = new Client()
                {
                    Uid = int.Parse(Dt.Rows[0]["Uid"]+""),
                    FirstName = Dt.Rows[0]["FirstName"]+"",
                    LastName = Dt.Rows[0]["LastName"] + "",
                    City = Dt.Rows[0]["City"] + "",
                    CityCode = int.Parse(Dt.Rows[0]["CityCode"] + ""),
                    Phone = Dt.Rows[0]["Phone"] + "",
                    Email = Dt.Rows[0]["Email"] + "",
                    AddDate = DateTime.Parse(Dt.Rows[0]["AddDate"] + "")
                };
            }
            Db.Close();
            return Tmp;
        }
        public static Client Save(Client client)
        {
            string sql = "";
            if(client.Uid == -1)
            {
                sql = "insert into T_Client (FirstName,LastName,City,CityCode,Phone,Email) values";
                sql += $"N'{client.FirstName}',N'{client.LastName}',N'{client.City}',{client.CityCode},N'{client.Phone}',N'{client.Email}')";
            }
            else
            {
                sql = "update T_Client set ";
                sql += $"FirstName=N'{client.FirstName}',";
                sql += $"LastName=N'{client.LastName}',";
                sql += $"City=N'{client.City}',";
                sql += $"CityCode={client.CityCode},";
                sql += $"Phone=N'{client.Phone}',";
                sql += $"Email=N'{client.Email}'";
                sql += $"where Uid={client.Uid}";
            }
            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(sql);
            GetAll();
            return client;
        }
    }
}