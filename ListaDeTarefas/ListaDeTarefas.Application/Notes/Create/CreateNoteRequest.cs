namespace ListaDeTarefas.Application.Notes.Create
{
    public record CreateNoteRequest(string title, string? description, int categoryId);
}
