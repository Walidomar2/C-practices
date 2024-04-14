
namespace ASP_Core_Middlewares.Repository
{
    public class ProductRepo : IProduct
    {
        private readonly ApplicationDbContext _context;

        public ProductRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Product?> Create(Product product)
        {
            await _context.Products.AddAsync(product);  
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product?> Delete(int id)
        {
           var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return null;
            }

            _context.Products.Remove(product);  
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<List<Product>> GetAll()
        {
           return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetById(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return null;
            }

            return product;
        }

        public async Task<Product?> Update(int id, Product product)
        {
            var productModel = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (productModel == null)
            {
                return null;
            }

            productModel.Name = product.Name;
            productModel.Description = product.Description; 

            await _context.SaveChangesAsync();
            return productModel;
        }
    }
}
