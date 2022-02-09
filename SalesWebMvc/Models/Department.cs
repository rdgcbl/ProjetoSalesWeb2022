using System.Collections.Generic;
using System;
using System.Linq;

namespace SalesWebMvc.Models {
    public class Department {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() { }
        public Department(int id, string name) {
            Id = id;
            Name = name;
        }
        public void AddSeller(Seller seller) {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final) { // total da venda
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
            // to pegando cada vendedor da minha lista Sellers, chamando o totalSales do vendedor daquele
            // periodo inicial e final, ai eu faço uma soma geral para o departamento
        }
    }
}
