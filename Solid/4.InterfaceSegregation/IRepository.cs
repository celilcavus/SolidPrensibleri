namespace Solid.InterfaceSegregation
{

    public interface IRepository
    {
        void Add();
    }
    public interface ICategoryRepository : IRepository
    {
        void getCategory();
    }
    public interface IProductRepository : IRepository

    {
        void getProduct();
    }


    public class CategoryRepository : ICategoryRepository
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void getCategory()
        {
            throw new NotImplementedException();
        }
    }
    public class ProductRepository : IProductRepository
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void getProduct()
        {
            throw new NotImplementedException();
        }
    }
}