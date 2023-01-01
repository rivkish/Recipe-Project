using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;

namespace BLL
{
    public class CategoryBL
    {

        private projectDb db;

        public CategoryBL(projectDb db)
        {
            this.db = db;
        }

            public List<CategoryDTO> GetCategories()
            {
                List<CategoryDTO> categorysDTO = new List<CategoryDTO>();
                List<Category> categorys = db.Categories.ToList();
            foreach (Category item in categorys)
                {
                   categorysDTO.Add(cast.CategoryCast.GetCategoryDTO(item));
                }
                return categorysDTO;

            }
        public CategoryDTO GetCategory(int id)
        {
            return cast.CategoryCast.GetCategoryDTO(db.Categories.Find(id));
        }

    }
}
