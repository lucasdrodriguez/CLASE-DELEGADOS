namespace Delegados
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Perro unPerro = new Perro();

            #region ejemplo 1
            //Action metodoAsociado;
            //unPerro.Despertarse();

            //metodoAsociado = unPerro.Despertarse;
            //metodoAsociado += AnunciarDespertada;
            //metodoAsociado.Invoke();

            #endregion

            #region ejemplo2

            Action actionSuccess;

            actionSuccess = AnunciarDespertada;

            unPerro.DespertarseDel(AnunciarDespertada, AnunciarQueEstaDespierto);

            unPerro.DespertarseDel(actionSuccess, AnunciarQueEstaDespierto);

            #endregion

            ManejadoraMensajes manejadora = new ManejadoraMensajes();

            manejadora.Comunicar(unPerro);
            manejadora.ComunicarConDel(unPerro.Despertarse);



        }

        public static void AnunciarDespertada()
        {
            Console.WriteLine("El perro se desperto");
        }
        public static void AnunciarQueEstaDespierto()
        {
            Console.WriteLine("El perro ya estaba despierto");
        }

    }
}
