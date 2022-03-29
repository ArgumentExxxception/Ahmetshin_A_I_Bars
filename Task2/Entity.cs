using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    public class Entity
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }

        static public Dictionary<int,List<Entity>> GetDictionary (List<Entity> entities)
        {
            return entities.GroupBy(x => x.ParentId).ToDictionary(x => x.Key, x => x.ToList<Entity>());
        }
    }
}