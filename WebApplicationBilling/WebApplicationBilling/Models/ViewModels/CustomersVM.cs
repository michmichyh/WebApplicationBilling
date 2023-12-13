using Microsoft.AspNetCore.Mvc.Rendering;
<<<<<<< HEAD
using WebApplicationBilling.Models.DTO;
=======
>>>>>>> f791ba2e580ce9927f51a837dd2db9360e147054

namespace WebApplicationBilling.Models.ViewModels
{
    public class CustomersVM
    {
        public IEnumerable<SelectListItem> ListCustomers { get; set; }
        public CustomerDTO Customer { get; set; }

    }
}
