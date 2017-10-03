using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDMDAL.InterfaceRepositories;
using SDMEntity.BE;

namespace SDMDAL.Repositories
{
    class CategoryRepositoryFakeDB : ICategoryRepository
    {
        private int Id = 1;
        private List<Category> Categories = new List<Category>();

        public Category Create(Category category)
        {
            Category newCategory;
            Categories.Add(newCategory = new Category()
            {
                ID = Id++,
                Name = category.Name,
            });
            return newCategory;
        }

        public Category Delete(int CategoryID)
        {
            var categoryFound = Get(CategoryID);
            Categories.Remove(categoryFound);
            return categoryFound;
        }

        public Category Get(int CategoryID)
        {
            return Categories.FirstOrDefault(x => x.ID == CategoryID);
        }

        public List<Category> GetAll()
        {
            return new List<Category>(Categories);
        }
    }
}
