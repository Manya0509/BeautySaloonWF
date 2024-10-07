using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WindowsFormsApp3;

namespace Beauty.modals
{
    public class DataStorage
    {
        private readonly string _pathToStorage;
        private readonly string _usersFileName = "Users.txt";

        private readonly string _finalPath;

        public DataStorage(string pathToStorage)
        { 
            _pathToStorage = pathToStorage;
            _finalPath = Path.Combine(_pathToStorage, _usersFileName);

            if (!Directory.Exists(pathToStorage))
            { 
                Directory.CreateDirectory(pathToStorage);
            }

            if(!File.Exists(_finalPath))
            {
                File.Create(_finalPath);
            }
        }

        public void Save(List<User> users)
        {
            using (StreamWriter sw = new StreamWriter(_finalPath))
            {
                sw.WriteLine(JsonConvert.SerializeObject(users));
            }
        }

        public List<User> Load()
        {
            List<User> users;

            using (StreamReader sr = new StreamReader(_finalPath))
            {
                users = JsonConvert.DeserializeObject<List<User>>(sr.ReadToEnd());

                if(users == null)
                    users = new List<User>();
            }

            return users;
        }

    }
}
