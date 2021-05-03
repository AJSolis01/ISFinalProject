using System;
using System.Text.Json;

namespace FinalProject.Models
{
    public class Appointment
    {
        public int id { get; set; }
        public string resourceId { get; set; }
        public string title { get; set; }

        public DateTime start { get; set; }

        public DateTime end { get; set; }

        public string description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Appointment>(this);




    }
}