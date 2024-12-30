using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstEFCore.Entities
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name {  get; set; }
        public string Email {  get; set; }
        public int Quantity {  get; set; }
        public int Price {  get; set; } 
    }
}
