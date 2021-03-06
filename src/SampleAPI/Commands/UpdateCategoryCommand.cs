﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPI.Commands
{
    public class UpdateCategoryCommand
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Photo { get; set; }
    }
}
