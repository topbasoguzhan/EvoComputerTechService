﻿using EvoComputerTechService.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvoComputerTechService.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;

        [InverseProperty("User")]
        public virtual List<Issue> Issues { get; set; }
        
        [InverseProperty("Technician")]
        public virtual List<Issue> Technician { get; set; }
    }
}
