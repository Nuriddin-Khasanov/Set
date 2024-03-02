using Domain.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class CategoryRepository : ICotegoryRepository
    {
        private List<Category> _categories;

        bool Create(Category category)
        {
            _categories.Add(category);
            return true;
        }

        bool ICotegoryRepository.Create(category category)
        {
            throw new NotImplementedException();
        }

        bool ICotegoryRepository.Delete(int id)
        {
            var deletedCategory = GetCategory(id);

            if(deletedCategory != null)
            {
                _categories.Remove(deletedCategory);
                return true;
            }

            return false;
        }

        List<category> ICotegoryRepository.GetAll()
        {
            return _categories;
        }

        category GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        category ICotegoryRepository.GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        bool ICotegoryRepository.Update(category category)
        {
            throw new NotImplementedException();
        }
    }

 }
