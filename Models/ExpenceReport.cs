using System;
using System.ComponentModel.DataAnnotations;
using GsbApp.Models;

namespace GsbApp.Models
{
    public class ExpenceReport
    {
        public int ID { get; set; }
        public Commercial Commercial { get; set; }
        public FlateRate FlateRate { get; set; }
        public int Document { get; set; }
        public decimal AmountCheck { get; set; }
        [DataType(DataType.Date)]
        public DateTime CheckDate { get; set; }
        public Status Status { get; set; }
    }
}