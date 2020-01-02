using System.Collections.Generic;
using System.Linq;
using GraphQL;
using Microsoft.EntityFrameworkCore;
using POC_GraphQL.Database;

namespace POC_GraphQL.Graphql
{
    public class Query
    {

        [GraphQLMetadata("collections")]
        public IEnumerable<Collection> GetCollections()
        {
            using (var db = new StoreContext())
            {
                return db.Collections
                .Include(b => b.Securities)
                .ToList();
            }
        }

        [GraphQLMetadata("securities")]
        public IEnumerable<Security> GetSecurities()
        {
            using (var db = new StoreContext())
            {
                return db.Securities
                .Include(a => a.Collection)
                .ToList();
            }
        }

        [GraphQLMetadata("Security")]
        public Security GetSecurity(string id)
        {
            using (var db = new StoreContext())
            {
                return db.Securities
                .Include(a => a.Collection)
                .SingleOrDefault(a => a.securityId == id);
            }
        }

    }
}