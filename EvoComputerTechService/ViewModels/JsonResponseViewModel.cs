﻿using System;

namespace EvoComputerTechService.ViewModels
{
    public class JsonResponseViewModel
    {
        public bool IsSuccess { get; set; }
        public object Data { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime ResponseTime { get; set; } = DateTime.UtcNow;
    }
}