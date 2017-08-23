using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportStore.Domain.Abstract;

namespace SportStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;

        public ProductController(IProductsRepository repository)
        {
            this.repository = repository;
        }

        // GET: Product
        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}