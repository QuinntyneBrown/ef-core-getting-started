using System.Collections.Generic;

namespace EfCoreGettingStarted.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; } = new HashSet<Article>();
    }
}
