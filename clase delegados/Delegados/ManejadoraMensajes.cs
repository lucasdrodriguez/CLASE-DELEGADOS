using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public class ManejadoraMensajes
    {

        public void Comunicar(Perro perro)
        {
            perro.Despertarse();
        }

        public void ComunicarConDel(Action mensaje)
        {
            mensaje.Invoke();
        }

    }
}
