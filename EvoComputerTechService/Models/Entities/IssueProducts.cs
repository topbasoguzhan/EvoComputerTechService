using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvoComputerTechService.Models.Entities
{
    public class IssueProducts
    {
        public Guid IssueId { get; set; } = Guid.NewGuid();
        public Guid ProductId { get; set; } = Guid.NewGuid();
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        [ForeignKey(nameof(IssueId))]
        public Issue Issue { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
    }
}
