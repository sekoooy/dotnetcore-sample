using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreSampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataTransferController : Controller
    {
        [HttpGet]
        public ActionResult<List<KeyValuePair<string, string>>> Get()
        {
            return Data.Instance.DataList;
        }

        [HttpGet("{key}")]
        public ActionResult<List<string>> Get(string key)
        {
            List<string> values = (from data in Data.Instance.DataList where data.Key == key select data.Value).ToList();
            return values;
        }

        [HttpPost]
        public void Post([FromBody] KeyValuePair<string, string> value)
        {
            Data.Instance.DataList.Add(value);
        }
    }
}