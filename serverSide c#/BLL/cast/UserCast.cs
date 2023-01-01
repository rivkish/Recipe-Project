using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;

namespace BLL.cast
{
    public class UserCast
    {
       public UserDTO GetUserDTO(User user)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Name=user.Name;
            userDTO.Address=user.Address;
            userDTO.Mail=user.Mail;
            userDTO.Password=user.Password;
            return userDTO;
        }

        public User GetUser(UserDTO userDTO)
        {
            User user = new User();
            user.Name = userDTO.Name;
            user.Address = userDTO.Address;
            user.Mail = userDTO.Mail;
            user.Password = userDTO.Password;
            return user;
        }
    }
}
