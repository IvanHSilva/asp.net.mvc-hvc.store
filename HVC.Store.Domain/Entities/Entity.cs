using System;

namespace HVC.Store.Domain.Entities {
    public class Entity {
        public int Id { get; set; }
        public DateTime DateEntry { get; set; } = DateTime.Now;
    }
}
