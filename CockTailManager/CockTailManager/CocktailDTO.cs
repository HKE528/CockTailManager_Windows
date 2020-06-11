using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CockTailManager
{
    class CocktailDTO
    {
        private string _name;
        private int _alcohol;
        private string _baseLiquor;
        private string _material;
        private string _recipe;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int alcohol
        {
            get { return _alcohol; }
            set { _alcohol = value; }
        }
        public string baseLiquor
        {
            get { return _baseLiquor; }
            set { _baseLiquor = value; }
        }
        public string material
        {
            get { return _material; }
            set { _material = value; }
        }
        public string recipe
        {
            get { return _recipe; }
            set { _recipe = value; }
        }
    }
}
