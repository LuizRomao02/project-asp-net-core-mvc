using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop.Models
{
    public class Departament
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();


        public Departament()
        {

        }

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            //pegar todos os vendedores deste departamento e somar o total de cada vendedor no intervalo da data
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
            //pegando cada vendedor da lista => chamando o totalsales do vendedor no periodo e faz a soma com o Sum

        }

    }
}
