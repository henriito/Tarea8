using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8.Clases
{
    internal class ClsRace
    {
        private Carrazo CarroA;
        private Carrazo CarroB;
        private Carrazo CarroC;

        public void PedidrDatos()
        {

            CarroA = GetData();
            Console.WriteLine("Ahora datos del B");
            CarroB = GetData();
            Console.WriteLine("Ahora datos del C");
            CarroC = GetData();
        }

        public void IniciarCarrera()
        {
            int contA, contB, contC;
            contA = contB = contC = 0;
            string msgCarroA, msgCarroB, msgCarroC;
            Random velRamdom = new Random();

            msgCarroA = CarroA.EncenderMotor();
            msgCarroB = CarroB.EncenderMotor();
            msgCarroC = CarroC.EncenderMotor();
            Console.WriteLine($"{CarroA.Marca} {msgCarroA}");
            Console.WriteLine($"{CarroB.Marca} {msgCarroB}");
            Console.WriteLine($"{CarroC.Marca} {msgCarroC}");

            for (int i = 0; i < 10; i++)
            {
                int acelerar;
                acelerar = velRamdom.Next(1, 21);
                msgCarroA = CarroA.acelerar(acelerar);
                acelerar = velRamdom.Next(1, 21);
                msgCarroB = CarroB.acelerar(acelerar);
                acelerar = velRamdom.Next(1, 21);
                msgCarroC = CarroC.acelerar(acelerar);
                Console.WriteLine($"{i + 1}- {CarroA.owner}: {msgCarroA}  {CarroB.owner}: {msgCarroB} {CarroC.owner}: {msgCarroC}");
            }

            if (CarroA.GetVelocidadActual() > CarroB.GetVelocidadActual() && CarroA.GetVelocidadActual() > CarroC.GetVelocidadActual())
            {
                Console.WriteLine($"¡¡GANADOR: {CarroA.owner}!!");
                contA++;
            }
            else if (CarroB.GetVelocidadActual() > CarroC.GetVelocidadActual() && CarroB.GetVelocidadActual() > CarroA.GetVelocidadActual())
            {
                Console.WriteLine($"¡¡GANADOR: {CarroB.owner}!!");
                contB++;
            }
            else 
            {
                Console.WriteLine($"¡¡GANADOR: {CarroC.owner}!!");
                contC++;
            }


        }

        private Carrazo GetData()
        {
            string marca;
            int velocidad;
            string propietario;
            Carrazo carrotemporal;

            Console.WriteLine("Ingrese marca");
            marca = Console.ReadLine();

            Console.WriteLine("Ingrese propietario");
            propietario = Console.ReadLine();
            carrotemporal = new Carrazo(marca, propietario);
            return carrotemporal;
        }


    }
}
