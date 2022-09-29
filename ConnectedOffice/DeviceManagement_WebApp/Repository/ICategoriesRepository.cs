using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;


namespace DeviceManagement_WebApp.Repository
{
    public interface ICategoriesRepository: IGenericRepository<Category>
    {
        Category GetMostRecentCategory();
    }
}
