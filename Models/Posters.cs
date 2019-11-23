using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class Posters
    {
        public string Band { get; set; }
        public string Venue { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Artist { get; set; }
        public DateTime? Date { get; set; }
        public bool? IsTour { get; set; }
        [Key]
        public int PosterId { get; set; }
    }
}
