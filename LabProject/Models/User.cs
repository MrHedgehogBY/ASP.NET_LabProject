﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabProject.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
        public Cart Cart { get; set; }
    }
}
