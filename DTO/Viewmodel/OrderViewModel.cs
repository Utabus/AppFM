using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Viewmodel
{
    public class OrderViewModel
    {
        public string? Email { get; set; }

        public string? FullName { get; set; }

        public string? Phone { get; set; }
        public decimal? Total { get; set; }

        public DateTime? CreateDay { get; set; }

        public string? Address { get; set; }
        public string? StatusDescription { get; set; }

    }
}
