using Domain.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    internal interface ICotegoryRepository
    {
        public List<category> GetAll();
        public category  GetCategory(int id);
        public bool Create(category category);
        public bool Update(category category);
        public bool Delete(int id);
        bool Create(Category Category);
    }
}
