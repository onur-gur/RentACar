using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int CarId { get; set; }
        public string CarDescription { get; set; }
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
