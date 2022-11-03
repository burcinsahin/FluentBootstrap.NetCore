﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FluentBootstrap.Tests.Web.Models.MvcTests
{
    public class ViewModel
    {
        [Display(Name = "Property A")]
        public string PropA { get; set; }
        public int PropB { get; set; }
        public string PropC { get; set; }
        public Dictionary<int, string> PropCOptions { get; set; }
        public bool PropD { get; set; }
        public ChildModel Child { get; set; }
    }

    public class ChildModel
    {
        [Display(Name = "Child Property A")]
        public string ChildPropA { get; set; }
    }
}