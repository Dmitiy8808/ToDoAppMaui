using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.DataServices
{
    public interface IRestDataService
    {
        Task<List<ToDo>> GetAllToDsAsync();
        Task AddToDoAsync(ToDo toDo);
        Task DeleteToDoAsync(int id);
        Task UpdateToDoAsync(ToDo toDo);
    }
}
