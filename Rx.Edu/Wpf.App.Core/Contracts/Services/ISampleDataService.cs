using System.Collections.Generic;
using System.Threading.Tasks;

using Wpf.App.Core.Models;

namespace Wpf.App.Core.Contracts.Services
{
    public interface ISampleDataService
    {
        Task<IEnumerable<SampleOrder>> GetMasterDetailDataAsync();
    }
}
