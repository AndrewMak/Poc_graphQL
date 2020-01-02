using GraphQL.Types;

namespace POC_GraphQL.Graphql
{
    public class MySchema 
  {
    private ISchema _schema { get; set; }
    public ISchema GraphQLSchema 
    {  
      get 
      {
        return this._schema;
      }
    }
    
    public MySchema() 
    {
      this._schema = Schema.For(@"
          type Collection {
            id: ID
            name: String,
            description: String,
            Securities: [Security]
          }

          type Security {
            rentabilityType: Int,
            incomeTaxFree: String,
            incomeTaxDescription: String,
            index: String,
            indexType: Int,
            isGuaranteedByFgc: String,
            issuerName: String,
            liquidity: Int,
            liquidityDescription: String,
            maturity: String,
            maturityDays: Int,
            maturityDescription: String,
            nickname: String,
            price: String,
            ratingDescription: String,
            relativeRentability: String,
            securityImplementationType: Int,
            simulatedRentability:String,
            simulatedInvestmentValue:String,
            stockQuantity: String,
            yield: String,
            percentIndex: String,
            incomeTaxRate: String,
            securityId: ID,
            securityNameType: String,
            securityType: String,
            rentability: String,
            minTick: String,
            suitability: Int,
            isQualified: String,
            isPromotion: String
            collections: Collection
          }

          type Mutation {
            addSecurity(name: String): Security
          }

          type Query {
              collections: [Collection]
              Security(id: ID): Security,
              Securities: [Security]
          }
      ", _ =>
      {
        _.Types.Include<Query>();
        _.Types.Include<Mutation>();
      });
    }

  }
}