using Service;
using System;

namespace CadastroPeopleListV4
{
    internal class Program
    {
        private static ICadastraPessoa iCadastraPessoa;

        private static void AddPerson() => iCadastraPessoa.AddPerson();

        private static void ShowPeople() => iCadastraPessoa.ShowPeople();

        private static void SearchPerson() => iCadastraPessoa.SearchPeopleById();

        private static void RemovePerson() => iCadastraPessoa.RemovePersonById();

        private static void EditPerson() => iCadastraPessoa.EditPerson();

        private static ICadastraPessoa getIntanceCadastraPessoa()
        {
            return new CadastraPessoa();
        }

        static void Main(string[] args)
        {
            iCadastraPessoa = getIntanceCadastraPessoa();

            string option = "";
            while (option != "0")
            {
                Console.WriteLine(" - Cadastro de Pessoa - ");
                Console.WriteLine("\nDigite uma opção: ");
                Console.WriteLine("[ 1 ] - Adicionar Pessoa");
                Console.WriteLine("[ 2 ] - Exibir Pessoas");
                Console.WriteLine("[ 3 ] - Buscar Pessoa Por Id");
                Console.WriteLine("[ 4 ] - Remover Pessoa");
                Console.WriteLine("[ 5 ] - Editar Pessoa");
                Console.WriteLine("[ 0 ] - Sair");
                option = Convert.ToString(Console.ReadLine());

                switch (option)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        ShowPeople();
                        break;
                    case "3":
                        SearchPerson();
                        break;
                    case "4":
                        RemovePerson();
                        break;
                    case "5":
                        EditPerson();
                        break;
                    case "0":
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}