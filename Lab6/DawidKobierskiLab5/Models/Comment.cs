﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DawidKobierskiLab5.Models
{
    public class Comment : ModelBase
    {
        public virtual Author Author { get; set; }
        public string Content { get; set; }
    }
}