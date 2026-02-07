namespace ListaDeTarefas.Application.Note.Create
{
    public record CreateNoteRequest(string title, string? description, int categoryId);
}
