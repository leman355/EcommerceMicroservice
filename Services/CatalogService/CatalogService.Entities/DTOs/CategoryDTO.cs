﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Entities.DTOs
{
    public class CategoryDTO
    {
        public record CategoryAddDTO(string CategoryName);
    }
}