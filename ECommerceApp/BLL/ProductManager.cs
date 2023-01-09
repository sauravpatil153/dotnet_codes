namespace BLL;
using BOL;
using DAL;
public class ProductManager
{
    public static List<Product> GetAllProducts(){
        List<Product> allProducts = DBManager.GetAllProducts();
        return allProducts;
    }
}
