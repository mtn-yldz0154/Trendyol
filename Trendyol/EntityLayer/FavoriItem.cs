﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class FavoriItem
    {
        public int Id { get; set; }
        public Favori Favori { get; set; }
        public int FavoriId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }

    }
}
