﻿using EvoComputerTechService.Models.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvoComputerTechService.Models.Entities
{
    public class Issue : BaseEntity
    {
        public string IssueName { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string AddressDetail { get; set; }
        public IssueStates IssueStates { get; set; }
        [StringLength(450)]
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; }
    }
    public enum IssueStates
    {
        Beklemede,
        Atandi,
        Islemde,
        Tamamlandi
    }
}