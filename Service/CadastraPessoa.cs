using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class CadastraPessoa : ICadastraPessoa
    {
        private static readonly List<Person> _peopleList = new List<Person>();
        
        public void AddPerson()
        {
            Console.WriteLine(" - Adicionar Pessoa - ");
            Console.WriteLine("Digite o id da pessoa: ");
            int idPerson = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome da pessoa: ");
            string namePerson = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite o telefone da pessoa: ");
            int telephonePerson = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a idade da pessoa: ");
            int agePerson = Convert.ToInt32(Console.ReadLine());

            _peopleList.Add(new Person(idPerson, namePerson, telephonePerson, agePerson));
        }

        public void ShowPeople()
        {
            if(_peopleList.Count == 0)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                Console.WriteLine(" - Pessoas Cadastradas - ");
                foreach(Person person in _peopleList)
                {
                    Console.WriteLine(person);
                }
            }
        }

        public void SearchPeopleById()
        {
            if (_peopleList.Count == 0)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                bool founded = false;
                Console.WriteLine(" - Buscar Pessoa Por Id - ");
                Console.WriteLine("Informe o id da pessaoa: ");
                int searchPersonById = Convert.ToInt32(Console.ReadLine());
                foreach (Person person in _peopleList)
                {
                    if(person.Id == searchPersonById)
                    {
                        Console.WriteLine("Pessoa encontrada");
                        Console.WriteLine(person.ToString());
                        founded = true;
                    }
                }
                if (!founded)
                {
                    Console.WriteLine("Pessoa não encontrada");
                }
            }
        }

        public void RemovePersonById()
        {
            if(_peopleList.Count == 0)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                bool founded = false;
                Console.WriteLine(" - Remover Pessoa Por Id - ");
                Console.WriteLine("Informe o id da pessaoa: ");
                int removePersonById = Convert.ToInt32(Console.ReadLine());
                foreach (Person person in _peopleList.ToList())
                {
                    if (person.Id == removePersonById)
                    {
                        Console.WriteLine("Pessoa encontrada");
                        Console.WriteLine(person.ToString());
                        founded = true;
                        _peopleList.Remove(person);
                        Console.WriteLine("Pessoa removida com sucesso");
                    }
                }
                if (!founded)
                {
                    Console.WriteLine("Pessoa não encontrada");
                }
            }
        }

        public void EditPerson()
        {
            if (_peopleList.Count == 0)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                bool founded = false;
                Console.WriteLine(" - Editar Pessoa - ");
                Console.WriteLine("Informe o id da pessaoa: ");
                int searchPersonById = Convert.ToInt32(Console.ReadLine());
                foreach (Person person in _peopleList)
                {
                    if (person.Id == searchPersonById)
                    {
                        Console.WriteLine("Pessoa encontrada");
                        Console.WriteLine(person.ToString());
                        founded = true;
                        Console.WriteLine("Informe o novo nome da pessoa: ");
                        string newNamePerson = Convert.ToString(Console.ReadLine());
                        person.EditName(newNamePerson);
                    }
                }
                if (!founded)
                {
                    Console.WriteLine("Pessoa não encontrada");
                }
            }
        }
    }
}