﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Merchandise
    {
        public string ItemId;

        public Merchandise(string itemId) 
        {
            this.ItemId = itemId;
        }

        public override string ToString()
        {
            return $"{ItemId}";
        }
    }
}
