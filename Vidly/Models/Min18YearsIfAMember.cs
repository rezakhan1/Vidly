using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MemberShipTypeId == MemberShipType.Unknown  || customer.MemberShipTypeId ==MemberShipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }
            if (customer.DateOfBirth == null)
            {
                return new ValidationResult("Birthdate is required");
            }
            var age = DateTime.Today.Year - Convert.ToInt32((customer.DateOfBirth).Split('/')[2]);//2019- 12/12/1996
            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Min 18 Year To get MemberShip");
        }
    }
}