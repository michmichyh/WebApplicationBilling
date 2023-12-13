using Microsoft.AspNetCore.Mvc;
using WebApplicationBilling.Models.DTO;
using WebApplicationBilling.Repository.Interfaces;
using WebApplicationBilling.Utilities;

namespace WebApplicationBilling.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerRepository _customerRepository;


        public CustomersController(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }

        [HttpGet]
        // GET: CustomersController 
        public ActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> GetAll()
        {
            try
            {
                //Llama al repositorio
                var data = await _customerRepository.GetAllAsync(UrlResources.UrlBase + UrlResources.UrlCustomers);
                return Json(new { data });
            }
            catch (Exception ex)
            {
                // Log the exception, handle it, or return an error message as needed
                return StatusCode(500, "Internal Server Error. Please try again later.");
            }
        }

        // GET: CustomersController/Details/5
        public ActionResult Details(int id) //Pendiente. Reto para el aprendiz
        {
            return View();
        }

        // GET: CustomersController/Create
        //Renderiza la vista
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomersController/Create
        //Captura los datos y los lleva hacia el endpointpasando por el repositorio --> Nube--> DB
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CustomerDTO customer)
        {
            try
            {
                await _customerRepository.PostAsync(UrlResources.UrlBase + UrlResources.UrlCustomers, customer);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}