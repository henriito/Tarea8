using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8.Clases
{
    internal class Carrazo
    {
        public string Marca { get; }
        public int Modelo { get; }
        public int cont { get; }
        public String Color { get; set; }

        public string owner { get; set; }

        private int Encendido = 0;
        private int velocidad_actual = 0;

        public int MAXVELOCIDAD { get; }
 
        public Carrazo(string _marca, string _owner)
        {
            Marca = _marca;
            owner = _owner;
            Encendido = 0;
            MAXVELOCIDAD = 320;
            this.velocidad_actual = 0;

        }

        //contruir 2do constructor
        public Carrazo(string _marca, int _modelo, int _maxvel, string _owner)
        {
            Marca = _marca;
            Modelo = _modelo;
            MAXVELOCIDAD = _maxvel;
            owner = _owner;
            this.velocidad_actual = 0;
        }
        public int GetVelocidadActual()
        {
            return velocidad_actual;
        }

        public string EncenderMotor()
        {
            if (Encendido == 0)
            {

                Encendido = 1;
                this.velocidad_actual = 0;
                return "BRRUUUUMMM, LISTOS PARA CORRER";
            }
            else
            {
                return "El auto ya estaba encendidooo";
            }
        }

        public string acelerar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"Lo sentimos, pero el carro esta apagado";
                return mensaje;
            }

            velocidad_actual += 10;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH Vamos a la velocidad maximaa.";
            }

            return mensaje;
        }

        public string acelerar(int CuantosKPH)
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"No puedo acelerar con el carro apagado";
                return mensaje;
            }

            velocidad_actual += CuantosKPH;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"{velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH Llegamos a la velocidad maximaaa";
            }

            return mensaje;
        }
    }
}
