using biblioteca_clases_form;

namespace Delegado_Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action delAction;
            Func<int> delFunc;
            Func<Perro> delFuncPerro;
            Func<int, string, bool, char, Perro> delFuncMultiple;

            delFunc = Valor;
            delFunc += Valor2;

            delFuncPerro = PrimerPerro;
            delFuncPerro += PerroMasGrande;

            delFuncMultiple = EjemploMultiple;

            int resultado = delFunc.Invoke();

            Console.WriteLine(resultado);

            Perro unPerrote = delFuncMultiple.Invoke(10, "dsdsa", true, 'a');
        }

        private static Perro EjemploMultiple(int arg1, string arg2, bool arg3, char arg4)
        {
            throw new NotImplementedException();
        }

        private static Perro PerroMasGrande()
        {
            throw new NotImplementedException();
        }

        private static Perro PrimerPerro()
        {
            throw new NotImplementedException();
        }

        public static int Valor()
        {
            return 100;
        }
        public static int Valor2()
        {
            return 500;
        }
    }
}
