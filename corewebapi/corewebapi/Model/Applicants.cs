﻿using System;
using System.Collections.Generic;

namespace corewebapi.Model
{
    public partial class Applicants
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}
