﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Dtos.Requests.Users
{
    public class VerifyEmail
    {
        public long UserId { get; set; }
        public string VerificationCode { get; set; }
    }
}
