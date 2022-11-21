using System.Globalization;
using ICare.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace ICare.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
