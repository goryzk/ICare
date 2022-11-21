using ICare.Application.TodoLists.Queries.ExportTodos;

namespace ICare.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
