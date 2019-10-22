using AutoMapper;
using CustomerData.Api.Data;
using CustomerData.Api.Filters;
using CustomerData.Api.Models;
using Microsoft.Web.Http;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace CustomerData.Api.Controllers
{
    [ApiVersion("1.0")]
    [RoutePrefix("api/v{version:apiVersion}/customers")]
    public class CustomersController : ApiController
    {
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;

        public CustomersController(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IHttpActionResult> CustomerInquiry([FromBody]CustomerModel model)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    if (string.IsNullOrEmpty(model.ContactEmail) && !model.Id.HasValue)
                    {
                        return BadRequest("No inquiry criteria");
                    }

                    var customer = model.Id.HasValue
                        ? await _repository.GetCustomerByIdAsync(model.Id.Value)
                        : await _repository.GetCustomerByEmailAsync(model.ContactEmail);

                    if (customer == null)
                    {
                        return NotFound();
                    }

                    return Ok(_mapper.Map<CustomerModel>(customer));
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an error on '{0}' invocation: {1}", nameof(CustomerInquiry), ex);
                return BadRequest();
            }
        }
    }
}
