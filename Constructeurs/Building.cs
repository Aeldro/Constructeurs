using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructeurs
{
    internal class Building
    {
        private double _height;
        private int _floors;

        public Building(int floors, double height)
        {
            this._floors = floors;
            this._height = height;
        }

        public Building(int floors)
        {
            this._floors = floors;
            this._height = floors * 3;
        }

        public double GetFloorMaxSize() { return _height / _floors; }

        public int GetFloorCount() { return _floors; }

        public double GetSize() { return _height; }
    }
}
