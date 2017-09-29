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
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
