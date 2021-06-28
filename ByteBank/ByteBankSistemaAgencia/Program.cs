using System;
using ByteBank.ByteBankModelos;

namespace ByteBank.ByteBankSistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.Adicionar(new ContaCorrente(345, 23462));
            lista.Adicionar(new ContaCorrente(363, 22451));
            lista.Adicionar(new ContaCorrente(735, 23552));
            lista.Adicionar(new ContaCorrente(333, 23552));
            lista.Adicionar(new ContaCorrente(456, 65423));
            lista.Adicionar(new ContaCorrente(654, 87457));
            lista.Adicionar(new ContaCorrente(334, 97348));
            lista.Adicionar(new ContaCorrente(678, 65899));
            lista.Adicionar(new ContaCorrente(735, 12223));
            lista.Adicionar(new ContaCorrente(735, 98576));
            lista.Adicionar(new ContaCorrente(735, 53534));
            lista.Adicionar(new ContaCorrente(735, 56253));
            lista.Adicionar(new ContaCorrente(735, 43657));
            lista.Adicionar(new ContaCorrente(735, 77534));
            lista.Adicionar(new ContaCorrente(735, 34436));
            lista.Adicionar(new ContaCorrente(735, 98867));
        }
    }
}
