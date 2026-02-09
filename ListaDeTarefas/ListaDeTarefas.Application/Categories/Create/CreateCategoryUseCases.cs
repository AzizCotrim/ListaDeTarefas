using ListaDeTarefas.Application.Abstractions;
using ListaDeTarefas.Domain.Entities;

namespace ListaDeTarefas.Application.Categories.Create
{
    public class CreateCategoryUseCases
    {
        private readonly ICategoryRepository _repo;

        public CreateCategoryUseCases(ICategoryRepository repo)
        {
            _repo = repo;
        }

        public async Task<CreateCategoryResponse> CreateCategoryAsync(CreateCategoryRequest request)
        {
            var conflict = await _repo.ExistsCategoryAsync(request.Name);
            if (conflict)
                throw new InvalidOperationException("Ja existe um cargo com esse nome");

            Category category = new Category(request.Name);

            int id = await _repo.AddCategoryAsync(category);
            return new CreateCategoryResponse(id);
        }
    }
}
