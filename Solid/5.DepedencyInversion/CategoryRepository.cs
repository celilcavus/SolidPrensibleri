namespace Solid.DependencyInversion
{

    public interface ICategoryRepository{
            void getInstance();
    }
 
    public class Container
    {
        public ICategoryRepository getInstance(){
            // return new CategoryRepositroyEF();
            return new CategoryRepositroyDp();
        }
    }

    internal class CategoryRepositroyEF : ICategoryRepository
    {
        public void getInstance()
        {
            System.Console.WriteLine("EF");
        }
    }

     internal class CategoryRepositroyDp : ICategoryRepository
    {
        public void getInstance()
        {
            System.Console.WriteLine("Dp");
        }
    }
}