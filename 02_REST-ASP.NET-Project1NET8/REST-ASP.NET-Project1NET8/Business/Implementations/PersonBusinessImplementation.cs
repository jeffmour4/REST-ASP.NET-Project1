using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using REST_ASP.NET_Project1NET8.Model;
using REST_ASP.NET_Project1NET8.Model.Context;
using REST_ASP.NET_Project1NET8.Repository;
using System.Net;

namespace REST_ASP.NET_Project1NET8.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IPersonRepository _repository;

        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
