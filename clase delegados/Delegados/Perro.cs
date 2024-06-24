using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public class Perro
    {
        Action estoyFeliz;
        bool estoyDespierto;

        public void Despertarse() // delegado de tipo ACTION 
        {
            estoyDespierto = true;
        }

        public void DespertarseDel(Action metodoSucess,Action metodoFail)
        {
            if (!estoyDespierto)
            {
                estoyDespierto = true;
                metodoSucess.Invoke();
            }
            else
            {
                metodoFail.Invoke();
            }
        }

        public void Ladrar(string ladrido)
        {

        }

        public string Ladrar()
        {
            return "estoy ladrando";
        }

       

    }
}
