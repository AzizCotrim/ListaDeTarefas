using ListaDeTarefas.Domain.Entities.Category;

namespace ListaDeTarefas.Application.Abstractions
{
    public interface ICategoryRepository
    {
        //bool para fazer a verificacao que existe
        Task<bool> ExistsCategory(string name);

        //int para retornar a quantidade de linhas alteradas
        Task<int> AddCategory(Category category);

    }
}
