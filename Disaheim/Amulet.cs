using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
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
        public Amulet(string itemId) : base (itemId)
        {
            ItemId = itemId;
        }

        // Constructor overload with two parameters.
        public Amulet(string itemId, Level quality) : base (itemId)
        {
            ItemId = itemId;
            Quality = quality;
        }

        // Constructor overload number two with three parameters.
        public Amulet(string itemId, Level quality, string design) : base (itemId)
        {
            ItemId= itemId;
            Quality = quality;
            Design = design;  
        }

        public virtual string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }




    }
}
