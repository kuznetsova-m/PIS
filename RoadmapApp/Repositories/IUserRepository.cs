using System.Collections.Generic;
using RoadmapApp.Models;

namespace RoadmapApp.Repositories
{
    public interface IUserRepository
    {
        void Add(User user);
        User GetByPhoneAndPassword(string phone, string password);
        User GetByPhone(string phone);
        void Save();
        List<User> GetAll();
    }
}
