using System;
using System.Collections.Generic;
using System.Text;
using SDMEntity.BE;

namespace SDMBLL.InterfaceServices
{
    interface ICategoryService
    {
        //C
        Category Create(Category category);

        //R
        List<Category> GetAll();
        Category GetById(int id);

        //U
        Category Update(Category category);

        //D
        Category Delete(int id);

    }
}
