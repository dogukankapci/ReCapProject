using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Rental : IEntity  // araba kiralama bilgisi
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }  // kiralama tarihi
        public DateTime? ReturnDate { get; set; } // teslim tarihi // araba teslim edilmemişse değeri null'dır
        public Car Car { get; set; }
        public Customer Customer { get; set; }

        // ReturnDate nullable çünkü araç hiçbir zaman kiralanmamış da olabilir, bu durumda bir teslim tarihi de bulunamaz!
    }
}
