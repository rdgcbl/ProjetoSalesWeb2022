using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;  // para usar o ToList()

namespace SalesWebMvc.Services {
    public class SellerService {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context) { //construtor
            _context = context;
        }

        public List<Seller> FindAll() { // operacao findAll para BD
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj) {
            
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
