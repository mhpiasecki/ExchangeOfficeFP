using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ExchangeOfficeFP.Models
{
    public class Currency
    {
        [Key]
        [Display(Name="Currency")]
        public string CurrencyName { get; set; }
        [Display(Name="Unit price")]
        public decimal Price { get; set; }
        public int Unit { get; set; }
        public int Amount { get ; set; }
        public decimal Value { get => Price * Amount / Unit; set => Value = value; }
    }
}
