using System;

namespace Core
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }

        public Category(int id, string title, bool isActive)
        {
            Id = id;
            Title = title;
            IsActive = isActive;
        }

        public string GetInfo()
        {
            return $"[Категорія] ID: {Id}, Назва: {Title}, Активна: {IsActive}";
        }
    }
}