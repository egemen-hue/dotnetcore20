using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    //concrete içinde yer alan sınıf manegaer
    public class CategoryManeger : ICategoryService
    {
        //CategoryRepository categoryRepository = new CategoryRepository(); // bütün metotlara erişim sağlayabilmek adına 
        GenericRepository<Category> repo = new GenericRepository<Category>();
        public void CategoryAdd(Category category)
        {
            throw new NotImplementedException();

            //if (category.CategoryName!="" && category.CategoryDescription!=""&& category.CategoryName.Length>=5 && category.CategoryStatus==true )
            //{
            //    categoryRepository.AddCategory(category);
            //}
            //else
            //{
            //    //hata verirt
            //}

        }

        public void CategoryDelete(Category category)
        {
            if(category.CategoryID!=0)
            {
                repo.Delete(category);
            }
            else
            {
                //hatamesajı
            }
            
        }

        public void CategoryUpdate(Category category)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
