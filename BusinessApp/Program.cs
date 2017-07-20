using System;
using BusinessApp.Application;
using BusinessUnit.Data_Access.Entities;

namespace BusinessApp
{
    class Program
    {
        private static object _ObjRegisterusers;
        private static object _ObjDBContext;

        public static string Firstname { get; private set; }
        public static string LastName { get; private set; }
        public static string EmailAddress { get; private set; }
        public static string FirstName { get; private set; }
        public static string PasswordHash { get; private set; }

        public static int GenderId { get; set; }
        public static int StatusId { get; set; }
        public static int UserTypeId { get; set; }
        public static int DepartmentId { get; set; }

        static void Main(string[] args)
        {
            //Add menu
            Console.WriteLine("Menu");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Exit");
            var menuOption = Console.ReadLine();

            //navigate menu options
            switch (menuOption)
            {
                case "1":
                    AddUser();
                    break;
                case "2":
                    UpdateUser();
                    break;
                case "3":
                    ReadUser();
                    break;
                case "4":
                    Exit();
                    break;
                default:
                    break;
            }




        }

        private static void ReadUser()
        {
            Console.WriteLine("Enter a User ID to see");
            int UserId = Convert.ToInt32(Console.ReadLine());
            var obj = new Update_Users();
            var user = obj.FindUserById(UserId);

            if (user != null)
            {
                Console.WriteLine(user.FirstName);
                Console.WriteLine(user.Lastname);
                Console.WriteLine(user.Passwordhash);
                Console.WriteLine(user.GenderId);
                Console.WriteLine(user.StatusId);
                Console.WriteLine(user.UserTypeId);
                Console.ReadKey();
            }
        }

        public static void Exit()
        {
            Environment.Exit(0);
        }

        public static void AddUser()
        {
            Console.WriteLine("Enter a First name");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Enter a Last name");
            string LastName = Console.ReadLine();

            Console.WriteLine("Enter a Email Address ");
            string EmailAddress = Console.ReadLine();

            Console.WriteLine("Enter Pass Word  ");
            string PasswordHash = Console.ReadLine();

            Console.WriteLine("Enter User Type  ");
            int UserType = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Gender ID  ");
            int GenderId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter DepId ");
            int DepartmentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Statusid  ");
            int StatusId = Convert.ToInt32(Console.ReadLine());



            var _Obj = new Add_User();
            _Obj.InsertUsers(FirstName, LastName, EmailAddress, PasswordHash, UserType, GenderId, DepartmentId, StatusId);
        }

        public static void UpdateUser()

        {

            Console.WriteLine("Enter a User ID");
            int UserId = Convert.ToInt32(Console.ReadLine());
            var obj = new Update_Users();
            var user = obj.FindUserById(UserId);

            if (user != null)

            {
                Console.WriteLine("Enter a User FirstName");
                user.FirstName = Console.ReadLine();
                FirstName = user.FirstName;


                Console.WriteLine("Enter a User Last Name ");
                user.Lastname = Console.ReadLine();
                LastName = user.FirstName;


                Console.WriteLine("Enter Email Address ");
                user.EmailAddress = Console.ReadLine();
                EmailAddress = user.EmailAddress;


                Console.WriteLine("Enter Password hash  ");
                user.Passwordhash = Console.ReadLine();
                PasswordHash = user.Passwordhash;

                Console.WriteLine("Enter gender Id");
                user.GenderId = Convert.ToInt32(Console.ReadLine());
                GenderId = user.GenderId;

                Console.WriteLine("Enter DepartmentID ");
                user.DepartmentId = Convert.ToInt32(Console.ReadLine());
                DepartmentId = user.DepartmentId;

                Console.WriteLine("Enter UserTypeID   ");
                user.UserTypeId = Convert.ToInt32(Console.ReadLine());
                UserTypeId = user.UserTypeId;

                Console.WriteLine("Enter User Status ");
                user.StatusId = Convert.ToInt32(Console.ReadLine());
                StatusId = user.StatusId;


            }



            //_ObjDBContext.RegisterUser.Attach(_ObjRegisterusers);
            // _ObjDBContext.SaveChanges()

            // var _ObjRegisterusers = _ObjDBContext.RegisterUser.FirstOrDefault(user => user.UserId == UserId);


            var _Obj = new Update_Users();
            _Obj.UpdateUser(user.UserId, FirstName, LastName, EmailAddress, PasswordHash, UserTypeId, GenderId, DepartmentId, StatusId);

            //_Obj.UpdateUserAlternative(user); 

            //  throw new NotImplementedException();
        }
    }
}
