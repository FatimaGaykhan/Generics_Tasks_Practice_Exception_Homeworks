using System;
using Exception_Homework.Models;
using Exception_Homework.Services.Interfaces;

namespace Exception_Homework.Services
{
	public class UserService:IUserService
	{
		public UserService()
		{
		}

        public User[] GetAll() 
        {
            return new User[]
            {
               new User
               {
                   Id=1,
                   FullName="Fatima Gaykhanova",
                   Email="fatima@code.edu.az",
                   Password="Fatima123"
               },
                new User
               {
                   Id=2,
                   FullName="Sadigkhan Gaykhanov",
                   Email="sadigkhan@code.edu.az",
                   Password="Sadigkhan123"
               },
                 new User
               {
                   Id=3,
                   FullName="Inji Gaykhanova",
                   Email="inji@code.edu.az",
                   Password="Inji123"
               }
            };
          
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

