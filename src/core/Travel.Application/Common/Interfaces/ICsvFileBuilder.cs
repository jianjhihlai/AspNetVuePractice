using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Application.TourLists.Queries.ExportTours;

namespace Travel.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTourPackagesFile(IEnumerable<TourPackageRecord> records);
    }
}
