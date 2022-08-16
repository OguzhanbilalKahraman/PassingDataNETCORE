using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingData.Models.ViewModel
{
    public class CustomerAndProductVM
    {
        public List<Customer> customers { get; set; }

        public Product product { get; set; }

        public string date { get; set; }

    }
}
