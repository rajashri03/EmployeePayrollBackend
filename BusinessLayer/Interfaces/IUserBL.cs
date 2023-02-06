using CommonLayer.Models;
using RepositoryLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IUserBL
    {
        public UserEntity Registration(EmpRegistration user);
        public string Login(EmpLogin userlogin);
        public IEnumerable<UserEntity> GetAllEmployee();
    }
}
