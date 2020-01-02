using System.Collections.Generic;

namespace POC_GraphQL.Database
{
  public class Collection
  {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Security> Securities { get; set; }
    }
}