using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tarea_Carro.Clases
{
    internal class Carro
    {
        public string Marca { get; }
        public int Modelo { get; }
        public String Color { get; set; }
        private int Encendido = 0;
        private int velocidad_actual = 0;
        private const int MAXVELOCIDAD = 150;
        private const int MINVELOCIDAD = 0;
        public Carro(string _marca, int _modelo, string _color)
        {
            Marca = _marca;
            Modelo = _modelo;
            Color = _color;
            Encendido = 0;
            this.velocidad_actual = 0;
        }
        public string GetVelocidadActual()
        {
            return $"Vamos a {velocidad_actual} KPH";
        }
        public void EncenderMotor()
        {
            if (Encendido == 0)
            {
                Console.WriteLine("run run run run, listo para correr");
                Encendido = 1;
                this.velocidad_actual = 0;
            }
            else
            {
                Console.WriteLine("Orales!!! ya esta encendido tu carro");
            }
        }
        public string acelerar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"no puedo acelerar con el carro apagado";
                return mensaje;
            }
            velocidad_actual += 10;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Estás acelerando,    Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH Aguas rapido y furioso, vas muy rapido y ya llegaste al tope";
            }
            Console.WriteLine(mensaje);
            return mensaje;
        }
        public string acelerar(int CuantosKPH)
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"no puedo acelerar con el carro apagado";
                return mensaje;
            }
            velocidad_actual += CuantosKPH;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Estás acelerando,    Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH Aguas rapido y furioso, vas muy rapido y ya llegaste al tope";
            }
            Console.WriteLine(mensaje);
            return mensaje;
        }


        // tarea
        /* ///////////////////////////// Desacelerar  /////////////////////////*/
        public string desacelerar()
        {
            string mensaje = "";

            velocidad_actual -= 3;
            if (velocidad_actual >= MINVELOCIDAD)
            {
                mensaje = $"Desaceleraste ahora, Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MINVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH A caray, el carro ya está parado";
            }
            Console.WriteLine(mensaje);
            return mensaje;
        }

        /*  ////////////////////////////  Frenar   /////////////////////////*/
        public string frenar()
        {
            string mensaje = "";

            velocidad_actual -= 15;
            if (velocidad_actual >= MINVELOCIDAD)
            {
                mensaje = $"Estás frenando ahora Vas a {velocidad_actual} KPH";
            }               
            else
            {
                velocidad_actual = MINVELOCIDAD;
                mensaje = $"{velocidad_actual} KPH A caray, el carro ya está parado";
            }
            Console.WriteLine(mensaje);
            return mensaje;
        }

        /*  ////////////////////////////  Apagar motor   /////////////////////////*/

        public void ApagarMotor()
        {
            if (MINVELOCIDAD == 0)
            {
                Console.WriteLine("run run      run      run      run,    el carro está apagado");
                Encendido = 0;
                this.velocidad_actual = 0;
            }
            else
            {
                Console.WriteLine("A caray, Deten el carro para poder apagarlo");
            }
        }
        /*  ////////////////////////////  Bocinar   /////////////////////////*/
        public void bocinar()
        {
            string pip;
            Console.WriteLine("Tocar la bocina");
            pip = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Beep((int) 300,(int) 2000);
            }
      
        }
    }
}