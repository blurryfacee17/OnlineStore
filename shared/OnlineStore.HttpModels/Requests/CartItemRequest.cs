﻿using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models.Requests;

public class CartItemRequest
{
    [Required] public Guid ProductId { get; set; }
    [Required] public int Quantity { get; set; }
}