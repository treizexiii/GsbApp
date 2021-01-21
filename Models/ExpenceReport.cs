using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GsbApp.Models;

namespace GsbApp.Models
{
    public class ExpenceReport
    {
        [Key]
        public int IdExpenceReport { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int Document { get; set; }
        public decimal AmountCheck { get; set; }
        [DataType(DataType.Date)]
        public DateTime CheckDate { get; set; }
        public int IdStatus { get; set; }
        public Status Status { get; set; }
        public int IdCommercial { get; set; }
        public Commercial Commercial { get; set; }
        public int IdFlateRateCategory { get; set; }
        public FlateRateCategory FlateRateCategory { get; set; }
    }
}
