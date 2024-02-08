using REST_ASP.NET_Project1NET8.Model;

namespace REST_ASP.NET_Project1NET8.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);

    }
}
