using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Models;

namespace Workshop.Services
{
    public class SellerService
    {
        private readonly WorkshopContext _context;

        public SellerService(WorkshopContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()  //listar as informações do banco de dados
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj) //adicionar as informações no banco de dados
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
