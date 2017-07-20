using BusinessUnits.Data_Access.DatabaseContext;
using BusinessUnits.Data_Access.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Application
{
    public class Update_Users
    {
        public void UpdateUser(int UserId, string Firstname, string LastName, string EmailAddress, string PasswordHash, int UserType, int Gender, int Department, int _StatusId)

        {
            using (var _ObjDBContext = new BusinessUnitsDBContext())
            {
                //select record using UserID



                var _ObjRegisterusers = _ObjDBContext.RegisterUser.FirstOrDefault(user => user.UserId == UserId);

                //if != null then  update
                if (_ObjRegisterusers != null)
                {
                    _ObjRegisterusers.FirstName = Firstname;
                    _ObjRegisterusers.Lastname = LastName;
                    _ObjRegisterusers.EmailAddress = EmailAddress;
                    _ObjRegisterusers.Passwordhash = PasswordHash;
                    _ObjRegisterusers.UserTypeId = UserType;
                    _ObjRegisterusers.GenderId = Gender;
                    _ObjRegisterusers.DepartmentId = Department;
                    _ObjRegisterusers.StatusId = _StatusId;
                }
                else
                {
                    //do soomething else
                }


                   _ObjDBContext.RegisterUser.Attach(_ObjRegisterusers);
                _ObjDBContext.SaveChanges();

                Console.WriteLine("Sucessful");
                Console.ReadKey();

                //   }

                //catch (Exception)
                //{

                //    Console.WriteLine("Could not insert Department");
                //    Console.ReadKey();
                //}
            }


        }

        public RegisteredUser FindUserById(int UserId)
        {

            using (var _ObjDBContext = new BusinessUnitsDBContext())
            {
                var _ObjRegisterusers = _ObjDBContext.RegisterUser.FirstOrDefault(user => user.UserId == UserId);

                return _ObjRegisterusers;
            }

        }

        internal void UpdateUserAlternative(RegisteredUser user)
        {
            using (var _ObjDBContext = new BusinessUnitsDBContext())
            {
                _ObjDBContext.RegisterUser.Attach(user);
                _ObjDBContext.SaveChanges();

            }
        }
    }
}











