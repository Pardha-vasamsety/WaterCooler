using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Preferences.Models
{
    public class Topic
    {
        public string topic { get; set; }
        public List<Subtopic> subtopics { get; set; }
    }
}
