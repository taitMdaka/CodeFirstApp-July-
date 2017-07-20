using BusinessUnits.Data_Access.DatabaseContext;
using BusinessUnits.Data_Access.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp
{
    class Add_User
    {
        public int UserId { get; private set; }

        public int InsertUsers(string Firstname, string LastName, string EmailAddress, string PasswordHash, int UserType, int Gender, int Department, int _StatusId)
            
        {
            using (var _ObjDBContext = new BusinessUnitsDBContext())
            {
                ///try
                // {
                var _ObjRegisterusers = new RegisteredUser

                {
                    //UserId = UserId,
                    FirstName = Firstname,
                    Lastname = LastName,
                    EmailAddress = EmailAddress,
                    Passwordhash = PasswordHash,
                    UserTypeId = UserType,
                    GenderId = Gender,
                    DepartmentId = Department,
                    StatusId = _StatusId

                };
                _ObjDBContext.RegisterUser.Add(_ObjRegisterusers);


                _ObjDBContext.SaveChanges();
                Console.WriteLine("Sucessful");
                Console.ReadKey();
                return _ObjRegisterusers.UserId;
            }


        }

        internal void TestMethod(string depName)
        {
            throw new NotImplementedException();
        }
    }
}
