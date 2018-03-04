using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TipCalculator.Attributes
{
    public class ValidBillAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value is decimal)
            {
                decimal billCheck = (decimal)value;
                if(billCheck < 0 || billCheck > 1000)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}