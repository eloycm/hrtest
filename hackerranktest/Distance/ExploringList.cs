using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerranktest.Distance
{
    public class ExploringList
    {
        protected HashSet<string> FoundFacilities = new HashSet<string>();
        protected HashSet<string> UniqueDesideredItems = new HashSet<string>();
        public bool AllFound { get; set; } = false;
        public List<string> DesideredItems { set
            {
                UniqueDesideredItems.UnionWith(value);
            } }

        public void AddBlock(List<string> block)
        {
            var foundItems = UniqueDesideredItems.Intersect(block);
            FoundFacilities.UnionWith(foundItems);
            AllFound = FoundFacilities.Count == UniqueDesideredItems.Count;
        }   
            
    }
}
