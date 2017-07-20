using System;
using BusinessApp.Application;
using BusinessUnits.Data_Access.Entities;
using System.Security.Cryptography;
using BusinessUnits.Joins;



namespace BusinessApp
{
    class Program
    {
        private static object _ObjRegisterusers;
        private static object _ObjDBContext;
        private static object _ObjPersonDBContext;

        public static string Firstname { get; private set; }
        public static string LastName { get; private set; }
        public static string EmailAddress { get; private set; }
        public static string FirstName { get; private set; }
        public static string PasswordHash { get; private set; }

        public static int GenderId { get; set; }
        public static int StatusId { get; set; }
        public static int UserTypeId { get; set; }
        public static int DepartmentId { get; set; }

        public static object ObjRegisterusers
        {
            get
            {
                return ObjRegisterusers1;
            }

            set
            {
                ObjRegisterusers1 = value;
            }
        }

        public static object ObjRegisterusers1
        {
            get
            {
                return _ObjRegisterusers;
            }

            set
            {
                _ObjRegisterusers = value;
            }
        }

        public static object ObjDBContext
        {
            get
            {
                return _ObjDBContext;
            }
            set
            {
                _ObjDBContext = value;
            }
        }
        public static object ObjPersonDBContext
        {
            get
            {
                return _ObjPersonDBContext;
            }

            set
            {
                _ObjPersonDBContext = value;
            }
        }

        static void Main(string[] args)
        {
            var menuOption = string.Empty;
            while (menuOption != "6")
            {  //Add menu
                Console.WriteLine("Menu");
                Console.WriteLine("1. Insert");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Read User");
                Console.WriteLine("4. Delete User");
                Console.WriteLine("5. Joins ");
                Console.WriteLine("6. Exit");
                menuOption = Console.ReadLine();
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
                        DeleteUser();
                        break;
                    case "5":
                        //Calling a method from Join Class
                        Joins j = new Joins();
                        j.Join();
                        break;
                    default:
                        break;
                }
            }
            Exit();
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
            string FirstName = Console.ReadLine().Trim(); ;

            Console.WriteLine("Enter a Last name");
            string LastName = Console.ReadLine().Trim(); ;

            Console.WriteLine("Enter a Email Address ");
            string EmailAddress = Console.ReadLine().Trim();

            Console.WriteLine("Enter Pass Word  ");
            string PasswordHash = Console.ReadLine().Trim();


            SHA256 hash = new SHA256Cng();
            byte[] hashvalue = hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(PasswordHash));
            PasswordHash = System.Text.Encoding.Default.GetString(hashvalue);

            Console.WriteLine("Enter User Type  ");
            int UserType = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Gender ID  ");
            int GenderId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter DepId ");
            int DepartmentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Statusid  ");
            int StatusId = Convert.ToInt32(Console.ReadLine());

            var _Obj = new Add_User();
            var userId = _Obj.InsertUsers(FirstName, LastName, EmailAddress, PasswordHash, UserType, GenderId, DepartmentId, StatusId);



            //write address
            Console.WriteLine("Province");
            int ProvinceId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Region");
            int RegionId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter CityId");
            int CityId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Surburb ID");
            int SurburbId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("StreetName");
            string Streetname = Console.ReadLine();

            Console.WriteLine("Enter Unit No ");
            int Unit = Convert.ToInt32(Console.ReadLine());



            var _ObjAdd = new Add_Physical_Address();


            _ObjAdd.AddressAdd(userId, ProvinceId, CityId, SurburbId, RegionId, Streetname, Unit);

            // Writing postal addfess


            //Console.WriteLine("Enter a PostalAddress");
            //int PostalAddressID = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Enter a PostalAddress");
            //int PostalAddress = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter a PostalAddress");
            //int PostalCode = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Enter a PostalAddress");
            //int AreaCode = Convert.ToInt32(Console.ReadLine());




            //  public void PostalAddressAdd(PostalAddress, PostalAddress, PostalAddressID, PostalAddress, PostalCode, AreaCode);


            




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

                Console.WriteLine("Enter User StatusID ");
                user.StatusId = Convert.ToInt32(Console.ReadLine());
                StatusId = user.StatusId;

            }

            var _Obj = new Update_Users();
            _Obj.UpdateUser(user.UserId, FirstName, LastName, EmailAddress, PasswordHash, UserTypeId, GenderId, DepartmentId, StatusId);
        }

        public static void DeleteUser()

        {

            Console.WriteLine("Enter a User ID");
            int UserId = Convert.ToInt32(Console.ReadLine());
            var obj = new DeleteUsers();
            var user = obj.FindUserById(UserId);

            if (user != null)
            {
                obj.DeleteUser(user.UserId);
            }
        }

    }
}

