using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QLCT.Models;
namespace QLCT.Data
{
    public interface IPayChartService
    {
        Task<List<PayChart>> getDuLieu();
    }
}
