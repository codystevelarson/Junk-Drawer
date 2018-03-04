using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TipCalculator.Attributes;

namespace TipCalculator.Models
{
    public class TipCalc
    {
        [ValidBill(ErrorMessage = "Bill must be greater than $0 and less than $1000")]
        public decimal? Bill { get; set; }

        [ValidTip(ErrorMessage = "Tip must be greater than 0% and less than 50%")]
        public decimal? Tip { get; set; }

        public decimal TipTotal => ((Tip ?? 0) / 100) * (Bill ?? 0);
        public decimal? Total => (Bill ?? 0) + TipTotal;
    }
}

