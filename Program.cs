using System;
using System.Security.Cryptography;
namespace poo {
    class classeTeste {
        static void Main() {
            Console.Clear();
            ContaBanco p1 = new ContaBanco();
            p1.setNumConta(1111);
            p1.setDono("Jubileu");
            p1.abrirConta("CC");

            ContaBanco p2 = new ContaBanco();
            p2.setNumConta(2222);
            p2.setDono("Creuza");
            p2.abrirConta("CP");

            p1.depositar(100);
            p2.depositar(500);
            p2.sacar(100);

            p1.sacar(150);
            p1.fecharConta();

            p1.estadoAtual();
            p2.estadoAtual();
        }
    }
}