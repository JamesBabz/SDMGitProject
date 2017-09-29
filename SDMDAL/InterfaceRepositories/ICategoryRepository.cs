using System;
using System.Collections.Generic;
using System.Text;
using SDMEntity.BE;

namespace SDMDAL.InterfaceRepositories
{
    public interface ICategoryRepository
    {

        //C
        Category Create(Category category);

        //R
        List<Category> GetAll();

        Category Get(int CategoryID);

        //U


        //D
        Category Delete(int CategoryID);

    }
}
