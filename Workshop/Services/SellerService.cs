using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Models;
using Microsoft.EntityFrameworkCore;
using Workshop.Services.Exceptions;

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


        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Departament).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();

        }

        public void Update(Seller obj)
        {
            if (!_context.Seller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("ID não encontrado");
            }

            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e) //DbUpdateConcurrencyException caso atualize e retorne algum erro no bd em relação a conflito, o programa retorna esta função automaticamente, entao, devemos tratar esta informação
            {
                throw new DbConcurrencyException(e.Message);

            }

        }
    }
}
