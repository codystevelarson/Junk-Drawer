using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TipCalculator.Attributes
{
    public class ValidTipAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value is decimal)
            {
                decimal tipCheck = (decimal)value;

                if (tipCheck < 0 || tipCheck > 50)
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