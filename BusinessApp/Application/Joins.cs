using BusinessUnits.Data_Access.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessUnits.Joins
{
    public class Joins
    {
        public void Join()
        {
            BusinessUnitsDBContext Context = new BusinessUnitsDBContext();
            var query = from ReadUsers in Context.RegisterUser
                        join gender in Context.Gender
                        on ReadUsers.GenderId equals
                        gender.GenderId
                        join approvl_status in Context.ApprovalStatuses
                        on ReadUsers.StatusId equals
                        approvl_status.StatusId
                        where approvl_status.IsApproved == false
                        //from
                        select new { ReadUsers.FirstName, ReadUsers.Lastname, approvl_status.IsApproved, gender.Sex };
            //Displaying the resualts
            foreach (var unapproved in query)
            {
                Console.WriteLine("Details {0}, {1}, {2}, {3} ", unapproved.FirstName, unapproved.Lastname, unapproved.IsApproved, unapproved.Sex);
            }
        }
    }
}