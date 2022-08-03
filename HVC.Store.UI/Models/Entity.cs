using System;
using System.ComponentModel.DataAnnotations;

namespace HVC.Store.UI.Models {
    public class Entity {
        public Entity() {
            DateEntry = DateTime.Now;
            //DateEntry.ToString("dd/MM/yyyy");
        }
        [Key]
        public int Id { get; set; }
        public DateTime DateEntry { get; set; } = DateTime.Now;
    }
}
