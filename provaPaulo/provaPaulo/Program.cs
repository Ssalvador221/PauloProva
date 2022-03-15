using System;
using System.Collections;
using System.Collections.Generic;

namespace provaPaulo
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente obj1 = new Cliente();
            Evento obj2 = new Evento();

            Cliente a = new Cliente("Ana", "223.112.354-78", "(48)991233123", "asdasdad@gmail.com");
            Cliente b = new Cliente("Pedrin", "222.112.354-78", "(48)991233123", "asdasdad@gmail.com");
            Cliente c = new Cliente("Ricardo", "224.112.354-78", "(48)991233123", "asdasdad@gmail.com");
            Cliente d = new Cliente("Dudinha", "221.112.354-78", "(48)991233123", "asdasdad@gmail.com");

            ArrayList cliente = new ArrayList();
            cliente.Add(a);
            cliente.Add(b);
            cliente.Add(c);
            cliente.Add(d);
            



            Console.WriteLine("Seja Bem Vindo ao Paulinho Eventos");
            Console.Write("Seu Nome: ");
            obj1.Nome = Console.ReadLine();
            Console.Write("Seu Número de Telefone: ");
            obj1.Tele = Console.ReadLine();
            Console.Write("Seu Cpf: " );
            obj1.Cpf = Console.ReadLine();
            Console.Write("Seu Email para Contato: ");
            obj1.Email = Console.ReadLine();
            Console.WriteLine();

            foreach (var item in cliente)
                Console.Write(item + " \n");
            Console.WriteLine();

            Console.WriteLine(obj1.ToString());

















        }
    }
}
