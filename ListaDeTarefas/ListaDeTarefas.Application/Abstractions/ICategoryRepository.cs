using ListaDeTarefas.Domain.Entities;

namespace ListaDeTarefas.Application.Abstractions
{
    public interface ICategoryRepository
    {
        //bool para fazer a verificacao que existe
        Task<bool> ExistsCategoryAsync(string name);

        //int para retornar o id criado
        Task<int> AddCategoryAsync(Category category);

    }
}
