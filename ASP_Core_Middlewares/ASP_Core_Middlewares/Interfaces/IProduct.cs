namespace ASP_Core_Middlewares.IRepository
{
    public interface IProduct
    {
        public Task<List<Product>> GetAll();
        public Task<Product?> GetById(int id);

        public Task<Product?> Create(Product product);
        public Task<Product?> Update(int id, Product product);
        public Task<Product?> Delete(int id);

    }
}
