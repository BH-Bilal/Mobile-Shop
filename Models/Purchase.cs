using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Remoting.Services;

namespace Mobile_Shop.Models
{
    public partial class Purchase
    {
        public Purchase_Master PM { get; set; }

        public Purchase_Detail PD { get; set; }

        public List <Product> products { get; set; }
        public List <Supplier> suppliers { get; set; }
    }
}