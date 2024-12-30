using CodeFirstEFCore.DatabaseContext;
using CodeFirstEFCore.Dtos;
using CodeFirstEFCore.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CodeFirstEFCore.Controllers
{
    [Route("controller")]
    public class CustomerController : Controller
    {
        [HttpGet]
        public List<CustomerDto> Get()
        {
            var context = new OnlineStoreDBContext();

            return context.Customers.Select(c => new CustomerDto
            {
                Name = c.Name,
                Email = c.Email,
            }).ToList();
        }
        [HttpPost]
        public HttpStatusCode Post(AddCustomerDto customer)
        {
            var context = new OnlineStoreDBContext();

            var customerObj = new Customer
            {
                Name = customer.Name,
                Email = customer.Email,
            };

            context.Customers.Add(customerObj);
            context.SaveChanges();
            return HttpStatusCode.OK;
        }
        [HttpPut]
        public HttpStatusCode Put(UpdateCustomerDto customer)
        {
            var context = new OnlineStoreDBContext();

            var customerObj = new Customer
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
            };

            context.Customers.Update(customerObj);
            context.SaveChanges();
            return HttpStatusCode.OK;
        }
        [HttpDelete]
        public HttpStatusCode Delete(int customerId)
        {
            var context = new OnlineStoreDBContext();

            var customerObj = context.Customers.First(c => c.Id == customerId);

            context.Customers.Remove(customerObj);
            context.SaveChanges();
            return HttpStatusCode.OK;
        }
    }
}
