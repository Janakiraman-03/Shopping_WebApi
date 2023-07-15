namespace Shopping_hands_on.Models
{
    public class Product
    {
        public int pId { get; set; }

        public string pName { get; set; }

        public string pCategory { get; set; }

        public double pOriginalPrice { get; set; }

        public double pDiscountPrice { get; set; }

        public string pDescription { get; set; }

        public bool pInstock { get; set; }





        private static List<Product> pList = new List<Product>
            {new Product()
              { pId=1,pName="Apple",pCategory="Fruits",pOriginalPrice=130,pDiscountPrice=90,pDescription="Organically grown apples",pInstock=true},
              new Product() { pId=2,pName="Body Wash",pCategory="Hygiene Products",pOriginalPrice=600,pDiscountPrice=550,pDescription="It provides deep moisture and nourishment to your skin",pInstock=false},
               new Product(){ pId=3,pName="Samsung 4K TV",pCategory="Electronics",pOriginalPrice=60000,pDiscountPrice=59980,pDescription="Immerse yourself in stunning visuals with this 4k tv",pInstock=true},
               new Product(){ pId=4,pName="Tooth Paste",pCategory="Hygiene Products",pOriginalPrice=50,pDiscountPrice=48,pDescription="Achieve a brighter smile ",pInstock=true},
               new Product(){pId=5,pName="Anti-Aging Moisturizer",pCategory="Cosmetics",pOriginalPrice=700,pDiscountPrice=650,pDescription="It Will diminish your wrinkles and fine lines",pInstock=false},
               new Product(){ pId=6,pName="Paper Towels",pCategory="Hygiene Products",pOriginalPrice=40,pDiscountPrice=35,pDescription="Clean up the messes quickly",pInstock=true},
               new Product(){ pId=7,pName="Diapers",pCategory="Hygiene Products",pOriginalPrice=150,pDiscountPrice=120,pDescription="Keep your baby dry and comfortable",pInstock=true},
               new Product(){ pId=8,pName="Air Purifier",pCategory="Electronics",pOriginalPrice=2000,pDiscountPrice=1780,pDescription="Freshens and purify the air that you breath",pInstock=false},
               new Product(){ pId=9,pName="Bluetooth Speaker",pCategory="Electronics",pOriginalPrice=1200,pDiscountPrice=1100,pDescription="Bring party vibes where ever you want",pInstock=false},
              new Product(){ pId=10,pName="Pillow",pCategory="Household Products",pOriginalPrice=500,pDiscountPrice=480,pDescription="Wakeup refreshed and rejuvenated",pInstock=false}
            };


        private static List<Product> Cart = new List<Product> { };



        public List<Product> GetAllProduct()
        {
            return pList;
        }
        public Product GetproductbyId(int id)
        {
            var prod = pList.Find(e => e.pId == id);
            if (prod != null)
            {
                return prod;
            }
            throw new Exception("Product Not Found");
        }

        public Product Getproductbyname(string name)
        {
            var prod = pList.Find(e => e.pName == name);
            if (prod != null)
            {
                return prod;
            }
            throw new Exception("Product Not Found");
        }

        public List<Product> GetProductbyCategory(string cate)
        {
            var prod = pList.FindAll(e => e.pCategory == cate);
            return prod;
        }

        public List<Product> GetProductInstock(bool stock)
        {
            var prod = pList.FindAll(e => e.pInstock == stock);
            return prod;
        }


        public string AddProduct(Product newProduct)
        {
            pList.Add(newProduct);
            return "Product is Added to our shop";
        }

        public string UpdateProduct(int id, Product prodObj)
        {
            var prod = pList.Find(e => e.pId == id);

            if (prod != null)
            {
                prod.pName = prodObj.pName;
                prod.pCategory = prodObj.pCategory;
                prod.pOriginalPrice = prodObj.pOriginalPrice;
                prod.pDiscountPrice = prodObj.pDiscountPrice;
                prod.pDescription = prodObj.pDescription;
                prod.pInstock = prodObj.pInstock;

                return "Product Updated";
            }
            return "Product not Found, update failed Enter a valid ID";
        }
        public string DeleteProductbyID(int id)
        {
            var prod = pList.Find(e => e.pId == id);
            if (prod != null)
            {
                pList.Remove(prod);
                return "Product Deleted";
            }
            throw new Exception("Product Not Found");

        }


        public string AddToCartbyID(int id)
        {

            var prod = pList.Find(e => e.pId == id);

            if (prod != null)
            {
                Cart.Add(prod);

                return "Product added to cart";


            }

            return "Please Enter a valid Product ID";

        }

        public List<Product>   ShowCart(){

            return Cart;
        }

    }
}
