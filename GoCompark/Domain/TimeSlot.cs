using System;
using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Domain
{
    public class TimeSlot
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a date")]
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please select Morning or Afternoon")]
        public PartOfDay? PartOfDay { get; set; }
    }
}