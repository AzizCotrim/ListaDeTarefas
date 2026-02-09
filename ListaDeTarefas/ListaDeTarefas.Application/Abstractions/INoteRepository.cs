using ListaDeTarefas.Domain.Entities;

namespace ListaDeTarefas.Application.Abstractions
{
    public interface INoteRepository
    {
        Task<int> AddNote(Note note);
    }
}
