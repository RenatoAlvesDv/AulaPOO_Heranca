using System;
using AulaPOO_Heranca.classes;
                                                          //subclasse  // sugestão ctrl + .
namespace AulaPOO_Heranca
{                                                               
    class Program
    {
        static void Main(string[] args)
        {

           //Instanciamos nossa subclasse
            PessoaFisica pf = new PessoaFisica();                                        // quando instaciamos estamos criando  um exemplar
            PessoaFisica pessoaFisica = new PessoaFisica();

            // Atribuimos um valor para a propriedade disponivel na subclasse
            pf.nome = "Paulo";
            //pf.cpf = "999.999.999-990"

            Console.WriteLine("Digite seu CPF");
            pf.cpf = Console.ReadLine();

            //Mostramos no console o metodo de saudação da superclasse
            Console.WriteLine( pf.DarBoasVindas(pf.nome) );        

            // Mostramos no console método de validação da subclasse
            Console.WriteLine ( pf.ValidarCPF(pf.cpf) );    
        }
    }
}
