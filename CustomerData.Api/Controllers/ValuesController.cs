using AutoMapper;
using CustomerData.Api.Data;
using CustomerData.Api.Data.Entities;
using CustomerData.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CustomerData.Api.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;

        public ValuesController(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // POST api/values
        public void Post([FromBody]CustomerModel model)
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
