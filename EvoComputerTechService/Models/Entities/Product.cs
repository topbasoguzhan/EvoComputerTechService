using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvoComputerTechService.Models.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; } = false;
        public virtual List<IssueProducts> IssueProducts { get; set; }
    }
}
