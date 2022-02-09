using System;
using System.Collections.Generic;
using SalesWebMvc.Models.Enums; //
using System.Linq; // para fazer a funcao TotalSales

namespace SalesWebMvc.Models {
    public class Seller {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
        public Department Department { get; set; }

        public Seller() { }
        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department) {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddSales(SalesRecord sr) { // adicionar uma venda
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr) { // remover uma venda
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final) { // total da venda
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        // Utilizar o LINQ expressao lambda -> a coleção 'sales' ponto where, (agora eu faço a logica
        // sr tal que sr.Date (uso a data la da classe SalesRecord) e depois faço a soma .SUM tal que 
        // sr.Amount (da classe SalesRecord) .Sum() aqui eu faço a soma e puxa o Amount que é o valor.
        }





    }
}
