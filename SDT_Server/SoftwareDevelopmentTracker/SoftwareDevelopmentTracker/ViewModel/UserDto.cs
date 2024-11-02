﻿using SoftwareDevelopmentTracker.Models;
using System;

namespace SoftwareDevelopmentTracker.ViewModel
{
    public class UserDto : EntityClass
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
    }
}
