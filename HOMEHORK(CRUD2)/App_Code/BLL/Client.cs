using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Client
    {
        public int Uid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int CityCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public DateTime AddDate { get; set; }

        public static List<Client> GetAll()
        {
            return ClientDAL.GetAll();
        }
        public static Client GetById(int id)
        {
            return ClientDAL.GetById(id);
        }
        public Client Save(Client client)
        {
            return ClientDAL.Save(client);
        }
    }
}