using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    internal class ProductLabelInfo
    {
        public Label NameLabel { get; set; }
        public Label PriceLabel { get; set; }
        public Label QuantityLabel { get; set; }
        public int Quantity { get; set; } = 1;
    }
}
