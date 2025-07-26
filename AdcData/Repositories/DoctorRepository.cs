using AdcData.Interfaces;
using AdcData.Models;

namespace AdcData.Repositories
{
    public class DoctorRepository : Repository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(AdcDbContext context) : base(context)
        {
        }
    }
}
