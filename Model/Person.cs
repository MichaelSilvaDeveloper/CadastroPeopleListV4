namespace Model
{
    public class Person
    {
        public Person(int id, string name, int telephone, int age)
        {
            Id = id;
            Name = name;
            Telephone = telephone;
            Age = age;
        }

        public override string ToString()
        {
            return "Pessoa: " + "\n" + "Id: " + Id + "\n" + "Nome: " + Name + "\n" + "Telefone: " + Telephone + "\n" + "Idade: " + Age + "\n";
        }

        public void EditName(string name) => Name = name;

        public int Id { get; set; }

        public string Name { get; set; }

        public int Telephone { get; set; }

        public int Age { get; set; }
    }
}