using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageManager
{
    public class Manager
    {
        private MessageDbEntities dbEntities = new MessageDbEntities();
        private string defaultMesssage;
        public string DefaultMessage { get => defaultMesssage; set => defaultMesssage = value; }

        public Manager()
        {
            DefaultMessage = "Hello World";

        }
        public string GetMetssage()
        {
            return DefaultMessage;
        }
        //data aware (future) state:
        public void DbConnection(string dbConnectionString)
        {
            dbEntities.Database.Connection.ConnectionString = dbConnectionString;
        }
        public string GetMetssage(int id)
        {
            dbEntities.Database.Connection.Open();
            string returnMessage = dbEntities.Messages.Find(id).Message1;
            dbEntities.Database.Connection.Close();
            return returnMessage;
        }
        //add a message and return it's ID...
        public int AddMessage(string newMessage)
        {
            dbEntities.Database.Connection.Open();
            Message m = new Message();
            m.Message1 = newMessage;
            dbEntities.Messages.Add(m);
            dbEntities.SaveChanges();
            dbEntities.Database.Connection.Close();
            return m.MessageID;

        }
    }
}
