using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HBC.ShopLib
{
    [Serializable]
    public class Goods
    {
        public string Code;
        public bool Grp;
        public string Title;
        public string Parent;
        public string GrandParent;
        public string MainImage; // в base64
        public string Description;
        public decimal Price;
        public decimal Quantity;

        public Goods()
        {
        }

        public Goods(string code, bool grp, string title, string parent, string grandParent, string mainImage, string description, decimal price, decimal quantity) : this(code, grp, title, parent, grandParent, mainImage) 
        {
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        public Goods(string code, bool grp, string title, string parent, string grandparent) : this()
        {
            Code = code;
            Grp = grp;
            Title = title;
            Parent = parent;
            GrandParent = grandparent;
        }

        public Goods(string code, bool grp, string title, string parent, string grandparent, string mainimage) : this(code, grp, title, parent, grandparent)
        {
            MainImage = mainimage;
        }
    }
}