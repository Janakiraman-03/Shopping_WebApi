using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shopping_hands_on.Models;

namespace Shopping_hands_on.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Shopping_Products_Controller : ControllerBase
    {
        Product pObj = new Product();

        [HttpGet]
        [Route("/plist")]
        public IActionResult GetAllProduct()
        {
            return Ok(pObj.GetAllProduct());
        }

        [HttpGet]
        [Route("/plist/Product/{id}")]
        public IActionResult GetproductbyId(int id)
        {
            try
            {
                var result = pObj.GetproductbyId(id);
                return Ok(result);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }
        }

        [HttpGet]
        [Route("/plist/Product/name/{name}")]
        public IActionResult GetproductbyId(string name)
        {
            try
            {
                var result = pObj.Getproductbyname(name);
                return Ok(result);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }
        }

        [HttpGet]
        [Route("/plist/category/{cate}")]
        public IActionResult GetProductbyCategory(string cate)
        {
            return Ok(pObj.GetProductbyCategory(cate));
        }

        [HttpGet]
        [Route("/plist/instock/{stock}")]
        public IActionResult GetProductInstock(bool stock)
        {
            return Ok(pObj.GetProductInstock(stock));
        }

        [HttpPost]
        [Route("/plist/add/cart/{id}")]
        public IActionResult AddToCartbyID(int id)
        {
            var addresult = pObj.AddToCartbyID(id);
            return Created("", addresult);
        }

        [HttpGet]
        [Route("/plist/viewcart")]
        public IActionResult ViewCart()
        {
            return Ok(pObj.ShowCart());
        }

        [HttpPost]
        [Route("/plist/add")]
        public IActionResult AddProduct([FromBody] Product prodObj)
        {
            var addresult = pObj.AddProduct(prodObj);
            return Created("", addresult);
        }



        [HttpDelete]
        [Route("/plist/delete/{id}")]
        public IActionResult DeleteProductbyID(int id)
        {
            try
            {
                var deleteResult = pObj.DeleteProductbyID(id);
                return Accepted(deleteResult);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }
        }
        [HttpPut]
        [Route("/plist/edit/{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product prodObj)
        {
            try
            {
                var updateResult = pObj.UpdateProduct(id, prodObj);
                return Ok(updateResult);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);

            }
        }


    }
}
