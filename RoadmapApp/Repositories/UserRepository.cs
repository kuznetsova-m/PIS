using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using RoadmapApp.Models;

namespace RoadmapApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users = new List<User>();
        private readonly string _filePath;

        public UserRepository(string filePath)
        {
            _filePath = filePath;
        }

        public void Add(User user)
        {
            _users.Add(user);
            Save();
        }

        public User GetByPhoneAndPassword(string phone, string password)
        {
            return _users.FirstOrDefault(u => u.Phone == phone && u.Password == password);
        }

        public User GetByPhone(string phone)
        {
            return _users.FirstOrDefault(u => u.Phone == phone);
        }

        public List<User> GetAll()
        {
            return _users;
        }

        public void Save()
        {
            var json = JsonConvert.SerializeObject(_users, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        public void Load()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                _users = JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
            }
        }
    }
}
