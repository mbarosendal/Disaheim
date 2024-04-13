using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {
        private string _itemId;
        private string _title;
        private double _price;

        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public virtual string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }

        public Book(string itemId)/* : base ()*/
        {
            ItemId = itemId;
        }

        public Book(string itemId, string title)/* : base ()*/
        {
            ItemId = itemId;
            Title = title;
        }

        public Book(string itemId, string title, double price)/* : base ()*/
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }
    }
}
