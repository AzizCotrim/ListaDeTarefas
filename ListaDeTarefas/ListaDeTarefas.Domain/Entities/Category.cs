namespace ListaDeTarefas.Domain.Entities
{
    internal class Category
    {
        public int Id { get; }
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }
    }
}
