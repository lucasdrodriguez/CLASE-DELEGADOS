using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegado_Action_Parametrizado.Program;

namespace Delegado_Action_Parametrizado
{
    public class Perro
    {

        public string nombre;
        public int edad;
        public bool estaPeinado;
        public bool yaPaseo;
        public bool estaSano;
        public bool estaDurmiendo;


        public void Rascarse(NotificarConString mostrarError)
        {

            mostrarError.Invoke("se rasco del lado incorrecto");


        }


    }
}
