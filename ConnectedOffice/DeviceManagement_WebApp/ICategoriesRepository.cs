using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;

namespace DeviceManagement_WebApp
{
    public interface ICategoriesRepository: IGenericRepository<Category>
    {
        Category GetMostRecentCategory();
    }
}
