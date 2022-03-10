using System;
using System.Collections.Generic;
using System.Linq;
using Workshop.Models;

namespace Workshop.Services
{
    public class DepartamentService
    {
        private readonly WorkshopContext _context;

        public DepartamentService(WorkshopContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList();
        }
    }
}
