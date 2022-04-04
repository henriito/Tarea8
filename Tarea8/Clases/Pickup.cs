using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8.Clases
{
    internal class Pickup : Carrazo
    {
        private bool FourWheelDrive = false;
        public int asientos { get; set; }

        public Pickup(string _marca, int _modelo, int _maxvel, string _owner) : base(_marca, _modelo, _maxvel, _owner)
        {
            
        }
        public string Activar4wd()
        {
            if (!FourWheelDrive)
            {
                FourWheelDrive = true;
                return "La retranca se activó!";
            }
            else
            {
                return "Ya la habias activado";
            }
        }
    }
}
