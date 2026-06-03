using System;

namespace Core
{
    public class ShoppingCart
    {
        public int CartId { get; set; }
        public double TotalValue { get; set; }
        public DateTime CreatedAt { get; set; }

        public ShoppingCart(int cartId, double totalValue, DateTime createdAt)
        {
            CartId = cartId;
            TotalValue = totalValue;
            CreatedAt = createdAt;
        }

        public string GetInfo()
        {
            return $"[Кошик] №{CartId}, Загальна сума: {TotalValue} грн., Створено: {CreatedAt}";
        }
    }
}