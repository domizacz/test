using System;

namespace testpatern
{
    internal class Program
    {
        private UsernameFactory _factory;
        public Program()
        {
        _factory = new UsernameFactory();
        }
        static void Main()
        {
          

           
            
        }
        public class UserName
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public class FirstNameFirst : UserName
        {
            public FirstNameFirst(string username)
            {
                var index = username.Trim().IndexOf(" ", StringComparison.Ordinal);

                if (index <= 0) return;

                FirstName = username.Substring(0, index).Trim();
                LastName = username.Substring(index + 1).Trim();
            }
        }
        public class LastNameFirst : UserName
        {
            public LastNameFirst(string username)
            {
                var index = username.Trim().IndexOf(",", StringComparison.Ordinal);

                if (index <= 0) return;

                LastName = username.Substring(0, index).Trim();
                FirstName = username.Substring(index + 1).Trim();
            }
        }
        public class UsernameFactory
        {
            public UserName GetUserName(string name)
            {
                if (name.Contains(",")) return new LastNameFirst(name);

                return new FirstNameFirst(name);
            }
        }

    }
    
}
