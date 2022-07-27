using System;
using System.ComponentModel.DataAnnotations;

namespace HVC.Store.UI.Models {
    public class Entity {
        [Key]
        public int Id { get; set; }
        public DateTime DateEntry { get; set; } = DateTime.Now;
    }
}
