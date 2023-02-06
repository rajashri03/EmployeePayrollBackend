using BusinessLayer.Interfaces;
using CommonLayer.Models;
using RepositoryLayer.Entities;
using RepositoryLayer.Interfaces;
using RepositoryLayer.Services;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Services
{
    public class UserBL : IUserBL
    {
        IUserRL iuserrl;
        /// <summary>
        /// Inititalizing the instanse of UserBL class
        /// </summary>
        /// <param name="iuserrl"></param>
        public UserBL(IUserRL iuserrl)
        {
            this.iuserrl = iuserrl;
        }
        public string Login(EmpLogin userlogin)
        {
            try
            {
                return iuserrl.Login(userlogin);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public UserEntity Registration(EmpRegistration user)
        {
            try
            {
                return iuserrl.Registration(user);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<UserEntity> GetAllEmployee()
        {
            try
            {
                return iuserrl.GetAllEmployee();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
