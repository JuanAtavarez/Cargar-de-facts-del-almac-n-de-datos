﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace LoadDwhVenta.Models.Models;

public partial class VWVenta
{
    public string CustomerId { get; set; }

    public string CustomerName { get; set; }

    public int? EmployeeId { get; set; }

    public string EmployeeName { get; set; }

    public int? ShipperId { get; set; }

    public string Shipper { get; set; }

    public string Country { get; set; }

    public int ProductId { get; set; }

    public string ProductName { get; set; }

    public string CategoryName { get; set; }

    public decimal? TotalVentas { get; set; }

    public int? Cantidad { get; set; }
}