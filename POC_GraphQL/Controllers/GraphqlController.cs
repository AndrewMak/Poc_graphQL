using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POC_GraphQL.Database;
using POC_GraphQL.Graphql;
using GraphQL;
using Microsoft.AspNetCore.Mvc;

namespace POC_GraphQL.Controllers 
{
  [Route("graphql")]
  [ApiController]
  public class GraphqlController: ControllerBase 
  {
    [HttpPost]
    public async Task<ActionResult> Post([FromBody] GraphQLQuery query) 
    {
      var schema = new MySchema();
      var inputs = query.Variables.ToInputs();

      var result = await new DocumentExecuter().ExecuteAsync(_ =>
      {
        _.Schema = schema.GraphQLSchema;
        _.Query = query.Query;
        _.OperationName = query.OperationName;
        _.Inputs = inputs;
      });

      if (result.Errors?.Count > 0)
      {
        return BadRequest(result.Errors);
      }

      return Ok(result);
    }
  }
}