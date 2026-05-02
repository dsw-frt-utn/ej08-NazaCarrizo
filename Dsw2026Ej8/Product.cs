using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Product
    {
        private long _code;
        private string _name;
        private string _description;
        private int _stock;

        public Product() { 
        }
        public Product(long code, string name, string description, int stock)
        {
            _code = code;
            _name = name;
            _description = description;
            _stock = stock;
        }

        public void ModificarDescripcion(string description)
        {
            _description= description;
        }
        public String GetDescription()
        {
            return _description;
        }
    }
}
