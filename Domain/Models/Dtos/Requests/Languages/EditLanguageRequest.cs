﻿using Domain.Models.Dtos.Fundamentals.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Dtos.Requests.Languages
{
    public class EditLanguageRequest : EditRequest<int>
    {
        [Required]
        public string LanguageName { get; set; }
        [Required]
        public byte Direction { get; set; }
        [Required]
        public string AcceptLanguage { get; set; }
        [Required]
        public bool Active { get; set; }
    }
}
