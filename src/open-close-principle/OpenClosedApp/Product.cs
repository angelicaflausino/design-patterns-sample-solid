using System;

namespace OpenClosedApp
{
    public class Product
    {
        public Product(string name, Color color, Size size)
        {
            if(name == null)
                throw new ArgumentNullException(paramName: nameof(name));

            Name = name;
            Color = color;
            Size = size;
        }

        public string Name;
        public Color Color;
        public Size Size;
    }
}