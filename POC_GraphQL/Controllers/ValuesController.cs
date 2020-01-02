using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using Microsoft.AspNetCore.Mvc;
using POC_GraphQL.Graphql;

namespace POC_GraphQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task<ActionResult> Get()
        {

            var schema = new MySchema();
            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
            _.Schema = schema.GraphQLSchema;
            _.Query = "{ collections { name } }";// query.Query;
            //_.OperationName = query.OperationName;
            //_.Inputs = inputs;
            });

            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }

    }
}
