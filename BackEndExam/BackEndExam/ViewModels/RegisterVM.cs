﻿using System.ComponentModel.DataAnnotations;

namespace BackEndExam.ViewModels
{
    public class RegisterVM
    {

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
