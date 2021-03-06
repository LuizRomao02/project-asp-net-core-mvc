using System;
using System.Collections.Generic;
using System.Linq;

namespace Workshop.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email{ get; set; }
        public DateTime BirthDate{ get; set; }
        public double BaseSalary{ get; set; }
        public Departament Departament { get; set; }
        public int DepartamentId { get; set; } //com o ID no final ja identifica que é uma chave estrangeira - naopodendo ser nulo
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();


        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departament = departament;
        }


        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
                //Sales é desta classe, a partir das vendas deste vendedor
                //Where - filtrar esta busca por data
                //todo objeto sr => sr.Date
                //soma do montande de vendas
        }
    }
}
