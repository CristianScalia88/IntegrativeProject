internal class Order
{
    public int Id { get; private set; }
    public Product Product { get; private set; }
    public Client Client { get; private set; }
    public DateTime Date { get; private set; }
    public decimal Price { get; private set; }
}
