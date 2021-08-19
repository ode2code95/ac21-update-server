using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestEntry.Controllers
{
    /// <summary>
    /// An example of a controller to upload files to demonstrate the request size limit setting (https://www.talkingdotnet.com/how-to-increase-file-upload-size-asp-net-core/)
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class ProductUpdateController : ControllerBase
    {
        /// <summary>
        /// Get a product by id
        /// </summary>
        /// <param name="customerId">A product id</param>
        /// <param name="productId"></param>
        [HttpGet]
        [Route("{customerId}/{productId}")]
        public IActionResult GetUpdateStatus(string customerId, string productId)
        {
            try {
                var cid = Guid.Parse(customerId);
                var pid = Guid.Parse(productId);
            }
            catch {
                return BadRequest();
            }

            return Ok();
        }
    }
}
