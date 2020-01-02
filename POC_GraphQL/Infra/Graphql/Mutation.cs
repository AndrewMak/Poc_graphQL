using POC_GraphQL.Database;
using GraphQL;

namespace POC_GraphQL.Graphql
{
    [GraphQLMetadata("Mutation")]
    public class Mutation
    {
        [GraphQLMetadata("addSecurity")]
        public Security Add(string name)
        {
            using (var db = new StoreContext())
            {
                var secure = new Security() { issuerName = name };
                db.Securities.Add(secure);
                db.SaveChanges();
                return secure;
            }
        }
    }
}