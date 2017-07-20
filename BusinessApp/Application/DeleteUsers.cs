using BusinessUnits.Data_Access.DatabaseContext;
using BusinessUnits.Data_Access.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Application
{
    public class DeleteUsers
    {
        public void DeleteUser(int UserId)

        {
            using (var _ObjDBContext = new BusinessUnitsDBContext())
            {
                //select record using UserID



                var _ObjRegisterusers = _ObjDBContext.RegisterUser.FirstOrDefault(user => user.UserId == UserId);

                //if != null then  delete
                if (_ObjRegisterusers != null)

                {
                    _ObjDBContext.RegisterUser.Remove(_ObjRegisterusers);
                }
                _ObjDBContext.SaveChanges();

                Console.WriteLine("User Deleted ");
                Console.ReadKey();


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



    }
}











