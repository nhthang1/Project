using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QLCT.Models;

namespace QLCT.Data
{
    public class PayChartManager: PayChart
    {
        IPayChartService restService;
        public PayChartManager(IPayChartService service)
        {
            restService = service;
        }

        public Task<List<PayChart>> GetTasksAsync()
        {
            return restService.getDuLieu();
        }
    }
}
