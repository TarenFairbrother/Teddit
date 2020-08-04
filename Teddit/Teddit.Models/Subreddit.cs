using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Text;

namespace Teddit.Models
{
    public class Subreddit
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int PostId { get; set; }

        [ForeignKey("PostId")]
        public List<Post> Posts { get; set; }
    }
}
