using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using Manager;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Model;

namespace QuantityMeasurement_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IManager manager;
        public ValuesController(IManager manager)
        {
            this.manager = manager;
        }

      [Route("FeetToInch")]
      [HttpPost]
      public IActionResult FeetToInch(conversion value)
      {
            var result = this.manager.FeetToInch(value);
            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
      }
        [Route("InchToFeet")]
        [HttpPost]
        public IActionResult InchToFeet(conversion value)
        {
            var result =this.manager.InchToFeet(value);
            if(result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }
        [Route("MeterToCentimeter")]
        [HttpPost]
        public IActionResult MeterToCentimeter(conversion value)
        {
            var result = this.manager.MeterToCentimeter(value);
            if(result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }
        [Route("CentimeterToMeter")]
        [HttpPost]
        public IActionResult CentimeterToMeter(conversion value)
        {
            var result = this.manager.CentimeterTometer(value);
            if(result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }
        [Route("KilogramToGram")]
        [HttpPost]
        public IActionResult KilogramToGram(conversion value)
        {
            var result = this.manager.KilogramToGram(value);
            if(result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }
        [Route("GramToKilogram")]
        [HttpPost]
        public IActionResult GramToKilogram(conversion value)
        {
            var result = this.manager.GramToKilogram(value);
            if(result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }
            
        
    }
}
