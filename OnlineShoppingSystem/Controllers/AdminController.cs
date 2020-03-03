using System.Web.Mvc;
using OnlineShoppingSystem.Models;
using OnlineShoppingSystem_Entity;
using OnlineShoppingSystem_BL;
using System.Collections.Generic;

namespace OnlineShoppingSystem.Controllers
{
    public class AdminController : Controller
    {
        ProductDetails product = new ProductDetails();
        // GET: Admin
        public ActionResult AdminIndex()
        {
            IEnumerable<ProductDetails> productDetails = ProductBL.ProductDetails(); 
            return View(productDetails);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(ProductModel productModel)
        {
            if (ModelState.IsValid)
            {
                product.productName = productModel.productName;
                product.productCategoryId = productModel.productCategoryId;
                product.productPrice = productModel.productPrice;
                product.productStock = productModel.productStock;
                ProductBL.AddProduct(product);
                return RedirectToAction("AdminIndex");
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EditProduct(ProductModel productModel)
        {
            return View();
        }
        [HttpGet]
        public ActionResult DeleteProduct(int id)
        {
            ProductBL productBL = new ProductBL();
            product = productBL.GetProductDetails(id);
            ProductModel productModel = new ProductModel();
            if (ModelState.IsValid)
            {
                productModel.productId = product.productId;
                productModel.productName = product.productName;
                productModel.productPrice = product.productPrice;
                productModel.productStock = product.productStock;
                productModel.productCategoryId = product.productCategoryId;
                return View(productModel);
            }
            return View(productModel);
        }
        [HttpPost]
        public ActionResult DeleteProduct(ProductModel productModel)
        {
            if (ModelState.IsValid)
            {
                product.productId = productModel.productId;
                product.productName = productModel.productName;
                product.productPrice = productModel.productPrice;
                product.productStock = productModel.productStock;
                product.productCategoryId = productModel.productCategoryId;
                ProductBL.ProductDelete(product);
                return RedirectToAction("AdminIndex");
            }
            return View();
        }
    }
}