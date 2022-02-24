using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;  // para usar o ToList()
using System.Threading.Tasks; //Async
using Microsoft.EntityFrameworkCore;//Async

namespace SalesWebMvc.Services {
    public class DepartmentService {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context) { //construtor
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync() {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync(); 
        }



    }
}
