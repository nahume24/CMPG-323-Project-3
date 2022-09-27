using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository : GenericRepository<Zone> , IZoneRepository
    {

        public ZoneRepository(ConnectedOfficeContext context) : base(context)
        {

        }
        //GET: Device
        public Zone GetMostRecentDevice()
        {
            return _context.Zone.OrderByDescending(zone => zone.DateCreated).FirstOrDefault();
        }
    }
}
