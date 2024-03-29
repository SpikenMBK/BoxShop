﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoxShop.Models
{
    public class Feedback
    {
        [BindNever]
        public int FeedbackId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage ="Your name is required")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage ="Your email is required")]
        [DataType(DataType.EmailAddress)]
        //[RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*",
        //ErrorMessage=" The email adress is not entered a correct format")]


        public string Email { get; set; }

        [Required]
        [StringLength(500, ErrorMessage ="Your message is required")]
        public string Message { get; set; }

        public bool ContactMe { get; set; }

    }
}
