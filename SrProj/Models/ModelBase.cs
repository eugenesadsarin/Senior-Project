﻿
using System;

namespace SrProj.Models
{
    public abstract class ModelBase
    {
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }

        protected ModelBase()
        {
            CreateDate = DateTime.UtcNow;
        }
    }
}
