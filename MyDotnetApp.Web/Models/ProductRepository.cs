using System;

namespace MyDotnetApp.Web.Models
{
    public class ProductRepository
    {
        private static List<ProductModel> _products;

        public List<ProductModel> GetAll() => _products;

        public void Add(ProductModel newProduct) => _products.Add(newProduct);

        public void Remove(int id)
        {
            var hasProduct = _products.FirstOrDefault(x => x.Id == id);
            if (hasProduct == null)
            {
                throw new Exception($"Bu id'ye ({id}) sahip ürün bulunmamaktadır!");
            }
            else _products.Remove(hasProduct);
        }

        public void Update(ProductModel upProduct)
        {
            var hasProduct = _products.FirstOrDefault(x => x.Id == upProduct.Id);
            if (hasProduct == null)
            {
                throw new Exception($"Bu id'ye ({upProduct.Id}) sahip ürün bulunmamaktadır!");
            }
            else
            {
                hasProduct.Name = upProduct.Name;
                hasProduct.Price = upProduct.Price;
                hasProduct.Stock = upProduct.Stock;
                var index = _products.FindIndex(x => x.Id == upProduct.Id);
                _products[index] = hasProduct;
            }
        }

        public ProductRepository()
        {
        }
    }
}

