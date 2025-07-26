using AdcData.Interfaces;
using AdcData.Models;

namespace AdcData.Repositories
{
    public class DiagnosticRepository : Repository<Diagnostic>, IDiagnosticRepository
    {
        public DiagnosticRepository(AdcDbContext context) : base(context)
        {
        }
    }
}
