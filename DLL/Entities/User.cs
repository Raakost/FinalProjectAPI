﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Entities
{
    public class User : AbstractId
    {
        public enum UserType
        {
            Student, Teacher, Company
        }

        public UserType Type { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public Company Company { get; set; }
    }
}
