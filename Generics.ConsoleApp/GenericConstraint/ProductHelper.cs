
// Class Constraints --> where T : Product
// Any class that uses this helper must be a Product or derived from Product
public static class ProductHelper
{
    public static decimal Discount<TProduct>(this TProduct product) where TProduct : Product
    {
        if (product.Price > 100)
        {
            return product.Price * 0.1m; // 10% discount
        }

        return 0; // No discount
    }
}