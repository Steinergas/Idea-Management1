using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Idea_Management.Models.comment
{
    public class Comment
    {
        internal object comment;
        internal object name;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }
}