using BusinessUnits.Data_Access.DatabaseContext;
using BusinessUnits.Data_Access.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Application
{
    public class Add_Physical_Address

    {
        public int CityId { get; private set; }
        public object PhysicalAddress { get; private set; }
        public int PhysicalAddressId { get; private set; }
        public int ProvinceId { get; private set; }
        public int RegisterUser_UserId { get; private set; }
        public string StreetName { get; private set; }
        public int SuburbId { get; private set; }
        //public int Suburb_SuburId { get; private set; }
        public int Unit { get; private set; }

        //private object regionId;

        public int UserId { get; private set; }

        public void AddressAdd(int UserId, int ProvinceId, int CityId, int SurburbId, int RegionId, string StreetName, int Unit)

        {

            using (var _ObjDBContext = new BusinessUnitsDBContext())
            {
                //var _user = _ObjDBContext.RegisterUser.Find(UserId);
                var _ObjAddressAdd = new PhysicalAddress
                {

                    UserId = UserId, 
                    ProvinceId = ProvinceId, 
                    CityId = CityId,
                    SuburbId = SurburbId,
                    RegionId = RegionId,
                    StreetName = StreetName,
                    Unit = Unit 
                };

                _ObjDBContext.PhysicalAddress.Add(_ObjAddressAdd); 
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