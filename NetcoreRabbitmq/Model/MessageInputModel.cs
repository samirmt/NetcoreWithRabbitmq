﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetcoreRabbitmq.Model
{
    public class MessageInputModel
    {
        public int FromId { get; set; }
        public int ToId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
