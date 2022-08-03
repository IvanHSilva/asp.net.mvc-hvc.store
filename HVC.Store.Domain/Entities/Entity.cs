using System;

namespace HVC.Store.Domain.Entities {
    public class Entity {
        public Entity() {
            DateEntry = DateTime.Now;
            //DateEntry.ToString("dd/MM/yyyy");
        }
        public int Id { get; set; }
        public DateTime DateEntry { get; set; } 
    }
}
