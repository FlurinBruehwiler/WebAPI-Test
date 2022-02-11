﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPITest.Models
{
    public partial class Following
    {
        public int FollowerId { get; set; }
        public int FollowingId1 { get; set; }

        public virtual Member Follower { get; set; }
        public virtual Member FollowingId1Navigation { get; set; }
    }
}
