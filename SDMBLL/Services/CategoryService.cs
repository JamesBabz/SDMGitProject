using System;
using System.Collections.Generic;
using System.Text;
using SDMBLL.InterfaceServices;
using SDMDAL;
using SDMDAL.InterfaceRepositories;
using SDMEntity.BE;

namespace SDMBLL.Services
{
        public class CategoryService : ICategoryService
        {

            private ICategoryRepository repo = new DALFacade().CategoryRepository; 


        public Category Create(Category category)
        {
            return repo.Create(category);
        }

        public Category Delete(int id)
        {
            return repo.Delete(id);
        }

        public List<Category> GetAll()
        {
            return repo.GetAll();
        }

        public Category GetById(int id)
        {
            return repo.Get(id);
        }

        public Category Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
