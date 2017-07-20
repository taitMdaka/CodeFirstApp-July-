using System;
using BusinessUnits.Data_Access.Entities;

namespace BusinessApp.Application
{
    public class AddPostalAddress

        {
       
        public int UserID { get;private set; }
        public int PostalAddressID { get;private set; }
        public int UserId { get;private set; }
        public string PostalAddress { get;private set; }
        public int PostalCode { get; private set; }
        public int AreaCode { get;private set; }
       public virtual RegisteredUser RegisterUser { get; private set; }
        

        

   //      public int UserId { get; private set; }

            public void PostalAddressAdd(int UserId, int PostalAddressID, int PostalAddress, int PostalCode, int AreaCode)

        {

            using (var _ObjDBContext = new BusinessUnits.Data_Access.DatabaseContext.BusinessUnitsDBContext())
            {
                    //var _user = _ObjDBContext.RegisterUser.Find(UserId);
                var _PostalAddress = new PostalAddress
                    {
                       
                       UserId = UserId,
                       PostalAddressID = PostalAddressID,
                        //PostalAddress = PostalAddress,
                        PostalCode = PostalCode.ToString(),
                        AreaCode= AreaCode.ToString(),

                      
                    };

                _ObjDBContext.PostalAddress.Add(_PostalAddress);
                    _ObjDBContext.SaveChanges();

                    Console.WriteLine("Sucessful");
                    Console.ReadKey();

                }
            }
            private void SaveChange()
            {
                throw new NotImplementedException();
            }

   
    }
    }
