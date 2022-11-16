using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void AddCategoryBL(Category category)
        {

            _categoryDAL.Insert(category);

        }

        //GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAll()
        //{
        //    return repo.List();
        //}
        //public void CategoryAddBL(Category category)
        //{
        //    //Category name bos bırakılıp null geçilirse hata fırlatıyor , length'i olmuyor.
        //    if(category.CategoryName == "" || category.CategoryName.Length<=3|| category.CategoryDescription == "" || category.CategoryName.Length >= 51)
        //    {
        //        //HATA MESAJI
        //    }
        //    else
        //    {
        //        repo.Insert(category);
        //    }
        //CTRL + K + D satırları düzenleme
        public List<Category> GetList()
        {
            return _categoryDAL.List();
        }
    }
}
