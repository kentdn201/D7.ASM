using D5.Models;

namespace D5___MVC.Services;

public interface IPersonService
{
    List<Person> GetAll();

    Person GetOne(int index);
    void Create(Person person);
    void Update(int index, Person person);
    void Delete(int index);
}
