using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstEFCore.Entities
{
    [Keyless]
    public class OrderItem
    {
        [ForeignKey("Item")]
        public int ItemId { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }
}
