﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services
{
    public interface ItodoRepository
    {
        public List<Todo> AllTodos();
    }
}
