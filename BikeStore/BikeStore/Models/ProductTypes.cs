﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BikeStore.Models
{
    public class ProductTypes
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


    }
}
