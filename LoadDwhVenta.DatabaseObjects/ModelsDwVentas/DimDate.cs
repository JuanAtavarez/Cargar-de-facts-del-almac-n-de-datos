﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace LoadDwhVenta.DatabaseObjects.Entities;

public partial class DimDate
{
    public int DateKey { get; set; }

    public DateOnly? FullDate { get; set; }

    public int? DateOrder { get; set; }

    public DateOnly? Date { get; set; }

    public string DateName { get; set; }

    public int? Month { get; set; }

    public string MonthName { get; set; }

    public int? Year { get; set; }

    public string YearName { get; set; }
}