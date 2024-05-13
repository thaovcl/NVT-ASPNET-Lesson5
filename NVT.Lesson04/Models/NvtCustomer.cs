using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NVT.Lesson04.Models
{
    public class NvtCustomer
    {
        public int CustomerId { get; set; }
        public string Firtname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int YearOfBirth { get; set; }
    }
}