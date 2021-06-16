﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProfanityFilter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfanityFilterController : ControllerBase
    {

        [HttpGet("{input}")]
        public async Task<string> Filter(string input)
        {
            HttpClient client = new HttpClient();
            var apiCall = "https://www.purgomalum.com/service/plain?text=" + input;
            var apiResponse = await client.GetStringAsync(apiCall);
            client.Dispose();
            return apiResponse;
        }
    }
}
