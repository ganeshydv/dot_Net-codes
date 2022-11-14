using Microsoft.AspNetCore.Mvc;
using ProductDAL;
using ProductDAL.EntityLayer;
using ProductMVC.ViewModels;
using System;
using System.Collections;

namespace ProductMVC.Controllers
{
    [Route("alldata")]
    public class AllDataController : Controller
    {
        IRepository<Product> _productsRepository;
        IRepository<Category> _categoriesRepository;
        public AllDataController(IRepository<Product> ref1,IRepository<Category> ref2)
        {
            _categoriesRepository = ref2;
            _productsRepository = ref1;
        }
        [Route("index")]
        [HttpGet]
        public IActionResult Index()
        {
            ProductVM productVM = new ProductVM();
            productVM.Category = _categoriesRepository.GetAll();
            return View(_productsRepository.GetAll());
        }

        [Route("index")]
        [HttpPost]
        public IActionResult Index( string s)
        {
            s = Request.Form["searchTxt"];
            return View(_productsRepository.FindByName(s));
        }

        [Route("searhbydate")]
        [HttpPost]
        public IActionResult SearchByDate(DateTime dt)
        {
            dt =DateTime.Parse( Request.Form["dateSearch"]);
            return View(_productsRepository.GetByDate(dt));
        }

        //--------------  ADD  ------------------
        [Route("add")]
        [HttpGet]
        public IActionResult Add()
        {

            ProductVM productVM = new ProductVM();

            productVM.Category = _categoriesRepository.GetAll();
            return View(productVM);
        }

        [Route("add")]
        [HttpPost]
        public IActionResult Add(ProductVM pd)
        {
            if (ModelState.IsValid)
            {
                _productsRepository.Add(new Product()
                {
                    Name = pd.ProductName,
                    //Id= pd.ProductId,
                    MfgDate=pd.purchaseDate,
                    Stock=pd.quantity,
                    Price=pd.price,
                    CategoryId=pd.CategoryId,

                }); ;
                return RedirectToAction("index");
            }
            ProductVM productVM = new ProductVM();
            return View(productVM);
        }

//---------------------------------------

        [Route("update")]
        [HttpGet]
        public IActionResult Update(int id=0)
        {
            var obj=_productsRepository.GetById(id);
            
            return View(obj);
        }

        [Route("update")]
        [HttpPost]
        public IActionResult Update(Product p)
        {
            var obj = _productsRepository.Update(p);

            return RedirectToAction("index");
        }

//-------------------------------------------------

        [Route("delete")]
        [HttpGet]
        public IActionResult Delete(int id = 0)
        {
            _productsRepository.DeleteById(id);
            return RedirectToAction("index");
        }




    }
}
