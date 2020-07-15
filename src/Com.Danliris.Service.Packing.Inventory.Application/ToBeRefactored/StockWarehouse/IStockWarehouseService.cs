﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Com.Danliris.Service.Packing.Inventory.Application.ToBeRefactored.StockWarehouse
{
    public interface IStockWarehouseService
    {
        List<ReportStockWarehouseViewModel> GetReportData(DateTimeOffset dateFrom, DateTimeOffset dateTo, string zona, int offset);
        MemoryStream GenerateExcel(DateTimeOffset dateFrom, DateTimeOffset dateTo, string zona, int offset);

    }
}
