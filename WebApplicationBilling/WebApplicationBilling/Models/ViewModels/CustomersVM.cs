﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationBilling.Models.ViewModels
{
    public class CustomersVM
    {
        public IEnumerable<SelectListItem> ListCustomers { get; set; }
        public CustomerDTO Customer { get; set; }

    }
}
