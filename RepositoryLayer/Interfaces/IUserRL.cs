using CommonLayer.Models;
using RepositoryLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interfaces
{
    public interface IUserRL
    {
        public UserEntity Registration(EmpRegistration user);
        public string Login(EmpLogin userlogin);
        public IEnumerable<UserEntity> GetAllEmployee();
        public bool DeleteNote(long empid);

    }
}
