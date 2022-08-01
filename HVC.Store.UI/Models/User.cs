using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HVC.Store.UI.Models {
    [Table("Users")]
    public class User: Entity{
        [Column(TypeName = "varchar"), Required, StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "varchar"), Required, StringLength(100)]
        public string EMail { get; set; }
        [Column(TypeName = "varchar"), Required, StringLength(150)]
        public string Password { get; set; }
    }
}
