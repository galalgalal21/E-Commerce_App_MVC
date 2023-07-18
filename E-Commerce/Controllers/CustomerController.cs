using AutoMapper;
using E_Commerce.BLL.Interface;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IMapper mapper;
        private readonly IProductRep productRep;

        public CustomerController(IMapper mapper, IProductRep productRep)
        {
            this.mapper = mapper;
            this.productRep = productRep;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
