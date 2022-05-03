using Doctor_assistant.Forms;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_assistant
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Forms.Login());

            MongoClient m_Client;
            IMongoDatabase m_Database;
            IMongoCollection<DoctorInfo> m_Collection;

            m_Client = new MongoClient("mongodb+srv://antonvo:0nCdIz2V538QvyD1@cluster0.frcvr.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            m_Database = m_Client.GetDatabase("Doctor");
            m_Collection = m_Database.GetCollection<DoctorInfo>("Account");

            var filter = Builders<DoctorInfo>.Filter;

            var userfilter = filter.Eq(x => x.UserName, "test01");

            var Passwordfilter = filter.Eq(x => x.Password, "test001!");

            var finalfilter = filter.And(userfilter, Passwordfilter);

            var enteruser = m_Collection.Find<DoctorInfo>(finalfilter).FirstOrDefault();
            Application.Run(new Forms.Patients(enteruser));
        }
    }
}
