namespace BLL;
using BOL;
using DAL;
public class ProductManager
{
    public List<Product> GetAllProducts(){
        List<Product> allProducts = DBManager.GetAllProducts();
        return allProducts;
    }
}
