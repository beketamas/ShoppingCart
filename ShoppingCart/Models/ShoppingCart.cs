namespace ShoppingCartProject.Models
{
    public class ShoppingCart
    {
        private readonly List<Product> _products;

        public ShoppingCart()
        {
            _products = new List<Product>();
        }

        public int ProductCount => _products.Count;

        public List<Product> Products => _products;


        //TODO Készítse el a ShoppingCart osztályban azokat a metódusokat, amelyekkel sikeresen lefutnak a tesztesetek!


        public void AddProduct(string name, double price) => Products.Add(new Product(name, price));
        public void RemoveProduct(string name) => Products.Remove(Products.Where(x => x.Name == name).First());
        public double GetTotalPrice() => Products.Sum(x => x.Price);
        public List<Product> GetProducts() => _products.Select(x => x).ToList();
        
    }
}
