﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPITest.Models
{
    public partial class Memberlikelist
    {
        public int MemberId { get; set; }
        public int ListId { get; set; }

        public virtual List List { get; set; }
        public virtual Member Member { get; set; }
    }
}
