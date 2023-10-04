public class Recipe
{
    public DateTime date { get; private set; }
    public Product Product { get; private set; }
    public int TotalQuantity { get; private set; }
    public double TotalPrice { get; private set; }
}