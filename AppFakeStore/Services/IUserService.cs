﻿using AppFakeStore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFakeStore.Services
{
    public interface IUserService
    {
        //Task<Usuario> GetUsuarioByIdAsync(int id);
        Task<IEnumerable<User>> GetUsersAsync();

        Task<User> GetUserByIdAsync(int id);
    }
}
