using System;

namespace POOmensagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1;

            msg1 = new Mensagem();
            msg1.AlteraMensagem = "Alô mundo";

            msg1.Exibirmensagem();
            Console.ReadKey();
        }
    }
}
