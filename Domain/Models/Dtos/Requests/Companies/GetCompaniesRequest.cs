﻿using Domain.Models.Dtos.Fundamentals.Requests;
using System;

namespace Domain.Models.Dtos.Requests.Companies
{
    public class GetCompaniesRequest : GetsRequest
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public string RegisterCode { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}