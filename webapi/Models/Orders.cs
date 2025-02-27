﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace webapi.Models;

[Table("orders")]
[Index("ReservationId", Name = "IX_orders_reservation_id")]
public partial class Orders
{
    [Key]
    [Column("order_id")]
    [StringLength(10)]
    public string OrderId { get; set; }
    //public Guid OrderId { get; set; }

    [Required]
    [Column("reservation_id")]
    [StringLength(10)]
    public string ReservationId { get; set; }

    [Column("total")]
    public double Total { get; set; }

    [Column("discount")]
    public double Discount { get; set; }

    [Column("price")]
    public double Price { get; set; }

    [Required]
    [Column("order_status")]
    [StringLength(10)]
    public string OrderStatus { get; set; }

    [InverseProperty("Order")]
    public virtual Checkout Checkout { get; set; }

    // commented following to remove foreignkey
    // uncomment and fix later including
    // line 197 in models/maindatabasecontext.cs and models/orders.cs line 44

    //[ForeignKey("ReservationId")]
    //[InverseProperty("Orders")]
    //public virtual Reservation Reservation { get; set; }
}