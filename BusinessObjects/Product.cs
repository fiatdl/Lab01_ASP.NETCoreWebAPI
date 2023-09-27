﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects_
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        [StringLength(40)]

        public string ProductName { get; set; }
        [Required]

        public int CategoryId { get; set; }
        [Required]

        public int UnitsInStock { get; set; }
        [Required]

        public decimal UnitPrice { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
