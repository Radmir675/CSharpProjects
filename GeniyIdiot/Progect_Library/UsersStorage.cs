using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Progect_Library
{
    public class UsersStorage
    {
        private static string filePathToSaveData = "person.json";
        //List<User> saves = new List<User>() { };
        DataStorageJson<User> DataStorageUsers = new DataStorageJson<User>(filePathToSaveData);
        public List<User> GetUsers()
        {
            return DataStorageUsers.ReadAllFromStorage();
        }

        public void ToSave(User user)
        {
            DataStorageUsers.SaveItemToStorage(user);
        }


       

    }
}
