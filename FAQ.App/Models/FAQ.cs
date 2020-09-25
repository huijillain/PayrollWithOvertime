using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAQ.App.Models
{
    public class FAQ
    {   //this is a c# object, 1 FAQ has 1 category relationship
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }  // load data right away, search by ..../name.../Category, if we have more categories, we can use List<Category> instead
        public string TopicId { get; set; }
        public Topic Topic { get; set; }

    }
}
