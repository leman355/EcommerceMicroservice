﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Entities.DTOs
{
    public class FeatureDTO
    {
        public string FeatureKey { get; set; }
        public List<FeatureValueDTO> FeatureValues { get; set; }
    }

}