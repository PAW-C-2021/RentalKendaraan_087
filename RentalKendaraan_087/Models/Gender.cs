using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan_087.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Customers = new HashSet<Customer>();
        }

        [Required(ErrorMessage = "ID Jenis Kelamin tidak boleh kosong")]
        public int IdGender { get; set; }
        [Required(ErrorMessage = "Jenis Kelamin tidak boleh kosong")]
        public string NamaGender { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
