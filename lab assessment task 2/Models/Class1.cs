﻿using System.ComponentModel.DataAnnotations;
namespace FIT5032_Week6.Models
{
    public class SampleFormViewModels
    {
    }
    public class FormOneViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}