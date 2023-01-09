namespace BLL;
using BOL;
using DAL;
public class ProductManager
{
    private static Product product;

    public static List<Product> GetAllProducts(){
        List<Product> allProducts = DBManager.GetAllProducts();
        return allProducts;
    }

    public static Product GetProductById(int id){
        List<Product> allProducts = GetAllProducts();
        var prod = (from p in allProducts
                        where p.ProductId==id
                        select p).ToList().First();
        Console.WriteLine(product.ProductId);
        return (Product)product;
    }
}
