using System;
using System.Collections.Generic;
using System.Text;
// 20.1.2021 Encapsulation is information hiding in the class from the outside. In practice fields are set to private
namespace C_sharp_training
{
    class Encapsultaion
    {
    }

    class Stiffener
    {
        private double _y;
        private double _z;

        public void SetCoordinates(double y, double z)
        {
            this._y = y;
            this._z = z;
        }

        public double[] GetCoordinates()
        {
            double[] yz= new double[] { this._y, this._z };
            return yz;
            
        }


    }
}
