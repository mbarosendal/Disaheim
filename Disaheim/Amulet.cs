using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet
    {
        private string _itemId;
        private string _design;
        private Level _quality;

        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        public string Design
        {
            get { return _design; }
            set { _design = value; }
        }

        public Level Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }

        // Default constructor with one parameter.
        public Amulet(string itemId)
        {
            ItemId = itemId;
        }

        // Constructor overload with two parameters.
        public Amulet(string itemId, Level quality)
        {
            ItemId = itemId;
            Quality = quality;
        }

        // Constructor overload number two with three parameters.
        public Amulet(string itemId, Level quality, string design)
        {
            ItemId= itemId;
            Quality = quality;
            Design = design;  
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }




    }
}
