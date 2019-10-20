using AutoMapper;
using CustomerData.Api.Data;
using CustomerData.Api.Data.Entities;
using CustomerData.Api.Models;
using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
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

        // POST api/values
        public async Task<IHttpActionResult> Post([FromBody]CustomerModel model)
        {
            try
            {
                // No inquiry criteria
                if (string.IsNullOrEmpty(model.ContactEmail) && model.Id == 0) return BadRequest("No inquiry criteria");

                // Invalid Customer ID
                if (model.Id > 0)
                {
                    if (model.Id > 999999999) return BadRequest("Invalid Customer ID");

                    var customer = await _repository.GetCustomerByIdAsync(model.Id);
                    if (customer == null) return NotFound();

                    return Ok(_mapper.Map<CustomerModel>(customer));
                }

                // Invalid Email
                if (!string.IsNullOrEmpty(model.ContactEmail))
                {
                    if (!model.IsValidEmail()) return BadRequest("Invalid Email");

                    var customer = await _repository.GetCustomerByEmailAsync(model.ContactEmail);
                    if (customer == null) return NotFound();

                    return Ok(_mapper.Map<CustomerModel>(customer));
                }

                return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }

            
        }
    }
}
