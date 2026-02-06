namespace ListaDeTarefas.Domain.Entities
{
    public class Nota
    {

        public int Id { get; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public int? CategoryId { get; set; }

        public Nota(string title, string? description, int? categoriaId)
        {
            Title = title;
            Description = description;
            CategoryId = categoriaId;
        }
    }
}
