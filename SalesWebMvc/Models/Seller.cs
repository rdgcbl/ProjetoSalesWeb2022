using System;
using System.Collections.Generic;
using SalesWebMvc.Models.Enums; //
using System.Linq; // para fazer a funcao TotalSales
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models {
    public class Seller {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)] //serve para definir o email como uma forma de link
        public string Email { get; set; }

        [Display(Name = "Birth Date")] //serve para colocar um espaco entre as palavras
        [DataType(DataType.Date)] //serve para remover as horas que fica na frente
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:f2}")]
        [Display(Name = "Base Salary")] //serve para colocar um espaco entre as palavras
        public double BaseSalary { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
        public Department Department { get; set; }
        public int DepartmentId { get; set; } /////

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
