﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCMS.Domain.Domain.Content
{
    public class MenuModule : ModuleBody
    {
        [Key]
        public int ModuleId { get; set; }
        public Module ParentModule { get; set; }
    }
}