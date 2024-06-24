namespace Delegado_Action_Parametrizado
{
    public delegate void NotificarConString(string str);
   
    internal class Program
    {



        static void Main(string[] args)
        {

            Action<string, int, string, int, bool> delegadoMio;

            //Action<string> miDelegadoAction;
            NotificarConString miDelegadoAction;

            miDelegadoAction = Mensajear_1;

            miDelegadoAction.Invoke("testing");


            Action<Perro> rutinaPerro;
            Perro unPerro = new Perro();
            unPerro.nombre = "pepe";
            unPerro.edad = 12;

            unPerro.Rascarse(Mensajear_1);



            rutinaPerro = IrAVeterinaria;
            rutinaPerro += IrAPasear;
            rutinaPerro += IrAPeluqueria;
            rutinaPerro += IrACasa;

            rutinaPerro.Invoke(unPerro);


        }

        private static void IrACasa(Perro perro)
        {
            perro.estaDurmiendo = true;
        }

        private static void IrAPeluqueria(Perro perro)
        {
            perro.estaPeinado = true;
        }

        private static void IrAPasear(Perro perro)
        {
            perro.yaPaseo = true;
        }

        private static void IrAVeterinaria(Perro perro)
        {
            perro.estaSano = true;
        }

        public static void Mensajear_1(string mensajito)
        {
            Console.WriteLine(mensajito);
        }

        public static void Mensajear_2(string mensajito)
        {
            Console.WriteLine("soy el mensaje 2 y digo: " + mensajito);
        }
    }
}
