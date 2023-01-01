using System;

namespace DTO

{
    public class UserDTO
    {
        private static int idForAll;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}