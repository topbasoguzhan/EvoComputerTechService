using EvoComputerTechService.Models.Entities;
using System.Collections.Generic;

namespace EvoComputerTechService.ViewModels
{
    public class IssueDetailViewModel
    {
        public List<IssueProducts> IssueProducts { get; set; }
        public List<Product> Products { get; set; }
    }
}
