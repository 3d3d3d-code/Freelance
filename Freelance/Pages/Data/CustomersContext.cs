using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance.Pages.Data
{
    public class CustomersContext
    {
        dbset<customer> Customers { get; set; }
    }

    internal class customer
    {
    }
}
