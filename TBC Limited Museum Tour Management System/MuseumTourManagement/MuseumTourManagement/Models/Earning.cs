using System;

namespace MuseumTourManagement.Models
{
    public class Earning
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Date:MMM dd} - £{Amount:F2}";
        }
    }
}
