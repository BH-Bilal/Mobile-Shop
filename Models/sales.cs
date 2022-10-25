using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Remoting.Services;

namespace Mobile_Shop.Models
{
    public partial class Sales
    {
        public Sales_Details SD { get; set; }
        public Sales_Master SM { get; set;} 
        public List<Customer> customers { get; set; }
        public List<Product> products { get; set; }
    }
}