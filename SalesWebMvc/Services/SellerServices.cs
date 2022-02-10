using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services {
    public class SellerServices {
        private readonly SalesWebMvcContext _context;

        public SellerServices(SalesWebMvcContext context) { //construtor
            _context = context;
        }


    }
}
