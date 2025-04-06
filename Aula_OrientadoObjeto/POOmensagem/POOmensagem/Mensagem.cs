using System;

namespace POOmensagem
{
    internal class Mensagem
    {
        //private String TextoMensagem;

        

        // public String getTextoMensagem()
        // {
        //     return this.TextoMensagem;
        // }

        // public void setTextoMensagem( String valor)
        // {
        //     this.TextoMensagem = valor.ToUpper();
        // }


        private String textoMensagem;
        public String AlteraMensagem
        {
            get
            {
                return this.textoMensagem;

            }

            set
            {
                this.textoMensagem = value;
            }
        }

        public void Exibirmensagem()
        {
            Console.WriteLine(this.textoMensagem);
        }

    }
}
