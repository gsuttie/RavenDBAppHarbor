using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RavenDBAppHarbor.Models
{
    public class Category
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Name Required")]
        [StringLength(25, ErrorMessage = "Must be less than 25 characters")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}