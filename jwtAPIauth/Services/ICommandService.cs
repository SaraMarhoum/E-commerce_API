using jwtAPIauth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwtAPIauth.Services
{
    public interface ICommandService
    {
        Task<Command> Create(Command command);
        Task Update(Command command);
        Task Delete(int id);
        Task<IEnumerable<Command>> GetAll();
        Task<Command> GetById(int id);
    }
}
