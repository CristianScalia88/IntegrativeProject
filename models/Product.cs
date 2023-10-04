public class Product
{

    public int Id { get; private set; }
    public string Description { get; private set; }
    public double Price { get; private set; }
    public string UrlImage{ get; private set; }

    public Product(int id, string description, double price, string urlImage)
    {
        Id = id;
        Description = description;
        Price = price;
        UrlImage = urlImage;
    }
}
