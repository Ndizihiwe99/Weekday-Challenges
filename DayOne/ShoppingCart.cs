//Shopping Cart Total

// **Requirements**

// 1. `AddItem` adds a product price to the cart.
// 2. A price must be greater than zero. Otherwise, throw an `ArgumentException`.
// 3. `GetTotal` returns the sum of all product prices.
// 4. `GetItemCount` returns the number of products in the cart.
// 5. An empty cart must have a total of `0` and an item count of `0`.

public class ShoppingCart
{
    private readonly List<decimal> _prices = new();

    public void AddItem(decimal price)
    {
        // if(price <= 0)
        // {
        //     throw new ArgumentException("Prixce must be greater than zero");
        // }

        // _prices.Add(price);
       
    }

    public decimal GetTotal()
    {
        // decimal total = 0;
        // foreach(var price in _prices)
        // {
        //     total += price;
        // }
        // return total;
    }

    public int GetItemCount()
    {
        // if(_prices.Count == 0 || _prices == null)
        // {
        //     return 0;
        // }
        // return _prices.Count;
    }
}