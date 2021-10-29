using TODOApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TODOApis.Data
{
    public interface ITodosService
    {
        Task<IList<Todo>> GetTodosAsync();
        Task<Todo> AddTodoAsync(Todo todo);
        Task RemoveTodoAsync(int todoId);
        Task<Todo> UpdateAsync(Todo todo);
    }
}
