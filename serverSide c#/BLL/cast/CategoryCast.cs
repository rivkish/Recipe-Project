using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;

namespace BLL.cast
{
    public class CategoryCast
    {
        public CategoryDTO GetCategoryDTO(Category category)
        {
            return new CategoryDTO() { ID = category.Id, Name = category.Name, Icon = category.Icon };
        }

        public Category GetCategory(CategoryDTO categoryDTO)
        {
            return new Category() { ID = categoryDTO.Id, Name = categoryDTO.Name, Icon = categoryDTO.Icon };
        }
    }
}
