using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rules.API.RuleEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Rules.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RulesController : ControllerBase
    {
        // GET api/<RuleController>/5
        [HttpGet("{accountId}")]
        public string Get([Required] double balance, long accountId)
        {
            BusinessRule businessRules = new BusinessRule();
            var result = businessRules.EvaluateMinBal(balance, accountId);
            return result;
        }

        // GET api/<RuleController>/5
        [HttpGet("ServiceCharge/{accountId}")]
        public async Task<string> GetServiceCharge(long accountId)
        {
            HttpClient client = new HttpClient();

            var response = await client.GetAsync("http://localhost:2298/api/Rule/23557448?balance=100");
            var evaluationStatus = await response.Content.ReadAsStringAsync();
            if (evaluationStatus == RuleStatus.Denied.ToString())
                return "Service charge should be calculated";
            return "done!";
        }


    }
}
