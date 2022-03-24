﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WebSite.Models
{
    public class UserListViewModel
    {
        public IEnumerable<Teacher> Teachers { get; set; }
        public SelectList Teacher { get; set; }
        public string Name { get; set; }
    }
}
