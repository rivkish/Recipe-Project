using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;

namespace BLL
{
    public class UserBL
    {
        private projectDb db;

        public UserBL(projectDb db)
        {
            this.db = db;
        }

        public List<UserDTO> GetUsers()
        {
            List<UserDTO> usersDTO = new List<UserDTO>();
            List<User> users = db.Users.ToList();
            foreach (User item in users)
            {
                usersDTO.Add(cast.UserCast.GetUserDTO(item));
            }
            return usersDTO;
           
        }
        public UserDTO GetUser(int id)
        {
            return cast.UserCast.GetUserDTO(db.Users.Find(id));
        }

        public bool CheckUser(User user)
        {
            //User t = db.Users.FirstOrDefault(r => r.Name == u.Name && r.Password == u.Password);
            //if (t == null)
            //    return false;
            //return true;
            User t = db.Users.Find(user.Id);
            if (t == null||t.Name!=user.Name&&t.Password!=user.Password)
                return false;
            return true;
        }
    }

    internal class List<T>
    {
    }
}
