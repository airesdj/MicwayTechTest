using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicwayTechTest.Models
{
    [Table("Drivers")]
    public class Driver
    {
        //id is the PK and auto
        public int Id { get; set; }

        [Required(ErrorMessage = "'First Name' field is required.")]
        [MaxLength(50, ErrorMessage = "The maximum length of the 'First Name' field is 50 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "'Last Name' field is required.")]
        [MaxLength(50, ErrorMessage = "The maximum length of the 'Last Name' field is 50 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "'Date Of Birthday' field is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd/MM/yyyy}")]
        public DateTime DateOfBirthday { get; set; }

        [Required(ErrorMessage = "'Email' field is required.")]
        [MaxLength(100, ErrorMessage = "The maximum length of the 'Email' field is 100 characters.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }

    }
}