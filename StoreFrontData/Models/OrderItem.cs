﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace StoreFront.Data.EF.Models;

public partial class OrderItem
{
    public int IOrderId { get; set; }

    public int UnderwearId { get; set; }

    public int OrderId { get; set; }

    public short? Quantity { get; set; }

    public decimal? ItemPrice { get; set; }

    public virtual Shipping Order { get; set; }

    public virtual Underwear Underwear { get; set; }
}