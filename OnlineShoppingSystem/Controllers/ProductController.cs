using System.Web.Mvc;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem_Entity;
using OnlineShoppingSystem_BL;
using System.Collections.Generic;

namespace OnlineShoppingSystem.Controllers
{
    public class ProductController : Controller
    {
        Product product = new Product();
        // GET: Admin
        public ActionResult Index()
        {
            IEnumerable<Product> productDetails = ProductBL.ProductDetails();
            ViewBag.Product = productDetails;
            return View(productDetails);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            ViewBag.Category = new SelectList(CategoryBL.CategoryDetails(), "CategoryId", "CategoryName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddProduct(ProductViewModel productModel)
        {
            ViewBag.Category = new SelectList(CategoryBL.CategoryDetails(), "CategoryId", "CategoryName");
            if (ModelState.IsValid)
            {
                product = AutoMapper.Mapper.Map<ProductViewModel, Product>(productModel);
                ProductBL.AddProduct(product);
                return RedirectToAction("Index");
            }
            return View();
        }
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
                ProductBL.ProductUpdate(productDetails);
                return RedirectToAction("Index");
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
            ProductBL.ProductDelete(product);
            return RedirectToAction("Index");
        }
        Category category = new Category();
        public ActionResult CategoryIndex()
        {
            IEnumerable<Category> categoryDetails = CategoryBL.CategoryDetails();
            ViewBag.Category = categoryDetails;
            return View(categoryDetails);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCategory(CategoryViewModel categoryModel)
        {
            if (ModelState.IsValid)
            {
                category = AutoMapper.Mapper.Map<CategoryViewModel, Category>(categoryModel);
                CategoryBL.AddCategory(category);
                return RedirectToAction("CategoryIndex");
            }
            return View();
        }
        public ActionResult DeleteCategory(int id)
        {
            CategoryBL.CategoryDelete(id);
            return RedirectToAction("CategoryIndex");
        }
    }
}