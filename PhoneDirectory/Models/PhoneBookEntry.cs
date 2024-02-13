using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Models
{
    public class PhoneBookEntry
    {
        [Key]
        public string Number { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Prefix { get; set; }
        public string PostCode { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} | Number {Number} | Address: {Address} | Prefix: {Prefix} | PostCode: {PostCode}";
        }
    }
}
