using System;
using System.ComponentModel.DataAnnotations;
using GsbApp.Models;

namespace GsbApp.Models
{
    public class FlateRate
    {
        public int ID { get; set; }
        public Commercial Commercial { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public FlateRateCategory FlateRateCategory { get; set; }
    }
}
