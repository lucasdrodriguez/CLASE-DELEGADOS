namespace biblioteca_clases_form
{
    public class Proceso
    {
        bool notificar;

        public void HacerProceso(Action<string> delNotificador)
        {
            notificar = true;
            /////////////////
            ///////////////
            //////////////
            ///////////////

            if (notificar)
            {
                delNotificador.Invoke("fallo algo en metodo Proceso porque... yo quise");
            }
        }

    }
}
