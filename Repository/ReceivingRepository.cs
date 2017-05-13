using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoLogistic.Data;

namespace AutoLogistic.Repository
{
    public class RecievingRepository 
    {
        private readonly ApplicationDbContext _context;
        public RecievingRepository(ApplicationDbContext context){
            _context = context;
        }

        
    }
}
