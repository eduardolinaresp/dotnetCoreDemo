using CampusWebApp.Models;
using CampusWebApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusWebApp.Repository.Implementations
{
    public class StudentRepository : Repository<Student>, IRepository<Student>
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
