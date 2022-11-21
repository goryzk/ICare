using ICare.Application.Common.Mappings;
using ICare.Domain.Entities;

namespace ICare.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
