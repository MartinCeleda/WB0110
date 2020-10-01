﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WB0110.Data
{
    public class Tag
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public Category Category { get; set; }

        public ICollection<TagQuote> Quotes { get; set; }
    }
}