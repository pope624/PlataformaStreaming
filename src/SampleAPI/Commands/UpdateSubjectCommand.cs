﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPI.Commands
{
    public class UpdateSubjectCommand
    {
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}