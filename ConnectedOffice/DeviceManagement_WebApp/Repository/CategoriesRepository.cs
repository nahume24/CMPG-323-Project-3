using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoriesRepository : GenericRepository<Category>, ICategoriesRepository
    {
        public CategoriesRepository(ConnectedOfficeContext context) : base(context)
        {

        }
        //TIER 1-  contain all methods used to interact with data as is currently done here the controller
       // private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();
        //GET: Categories
     
       public Category GetMostRecentCategory()
       {
            return _context.Category.OrderByDescending(category => category.DateCreated).FirstOrDefault();
       }
    }
}
