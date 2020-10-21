using System.Web.Mvc;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem_Entity;
using OnlineShoppingSystem_BL;
using System.Collections.Generic;

namespace OnlineShoppingSystem.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        ProductBL productBL = new ProductBL();
        CategoryBL categoryBL = new CategoryBL();
        Product product = new Product();
        // GET: Admin
        public ActionResult Index()
        {
            IEnumerable<Product> productDetails = productBL.ProductDetails();
            ViewBag.Product = productDetails;
            TempData["product"] = product;
            RedirectToAction("Index", "Home");
            return View(productDetails);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            ViewBag.Category = new SelectList(categoryBL.CategoryDetails(), "CategoryId", "CategoryName");
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult AddProduct(ProductViewModel productModel)
        {
            ViewBag.Category = new SelectList(categoryBL.CategoryDetails(), "CategoryId", "CategoryName");
            if (ModelState.IsValid)
            {
                product = AutoMapper.Mapper.Map<ProductViewModel, Product>(productModel);
                productBL.AddProduct(product);
                return RedirectToAction("Index");
            }
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult EditProduct(int id)
        {
            ProductBL productBL = new ProductBL();
            product = productBL.GetProductDetails(id);
            ProductViewModel productModel = new ProductViewModel();
            productModel = AutoMapper.Mapper.Map<Product, ProductViewModel>(product);
            return View(productModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProduct(ProductViewModel productModel)
        {
            Product productDetails = new Product();
            if (ModelState.IsValid)
            {
                productDetails = AutoMapper.Mapper.Map<ProductViewModel, Product>(productModel);
                productBL.ProductUpdate(productDetails);
                return RedirectToAction("Index","Product");
            }
            return View();
        }
        [HttpGet]
        public ActionResult DeleteProduct(int id)
        {
            ProductBL productBL = new ProductBL();
            product = productBL.GetProductDetails(id);
            ProductViewModel productModel = new ProductViewModel();
            productModel = AutoMapper.Mapper.Map<Product, ProductViewModel>(product);
            return View(productModel);
        }
        [HttpPost]
        public ActionResult DeleteProduct(ProductViewModel productModel)
        {
            product = AutoMapper.Mapper.Map<ProductViewModel, Product>(productModel);
            productBL.ProductDelete(product);
            return RedirectToAction("Index");
        }
        Category category = new Category();
        public ActionResult CategoryIndex()
        {
            IEnumerable<Category> categoryDetails = categoryBL.CategoryDetails();
            ViewBag.Category = categoryDetails;
            return View(categoryDetails);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult AddCategory(CategoryViewModel categoryModel)
        {
            if (ModelState.IsValid)
            {
                category = AutoMapper.Mapper.Map<CategoryViewModel, Category>(categoryModel);
                categoryBL.AddCategory(category);
                return RedirectToAction("CategoryIndex");
            }
            return View();
        }
        public ActionResult DeleteCategory(int id)
        {
            categoryBL.CategoryDelete(id);
            return RedirectToAction("CategoryIndex");
        }
    }
}