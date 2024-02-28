using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDialogi
{
    internal class ListOfPersons
    {
        public ObservableCollection<Person> persons;
        public ListOfPersons()
        {
            persons = new ObservableCollection<Person>();
            LoadPersons("plik.txt");
        }
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
        public void RemovePerson(Person person)
        {
            persons.Remove(person);
        }
        public void EditPerson(int index, Person person)
        {
            persons[index] = person;
        }
        public void RemovePersonAt(int index)
        {
            if (index >= 0 && index < persons.Count)
                persons.RemoveAt(index);
        }
        public void LoadPersons(string file)
        {
            persons.Clear();
            persons.Add(new Person("Karol", "Jański", EducationLevel.średnie));
            persons.Add(new Person("Ania", "Dudek", EducationLevel.podstawowe));
            persons.Add(new Person("Maciej", "Król", EducationLevel.wyższe));
            persons.Add(new Person("Marta", "Sobieski", EducationLevel.średnie));
            persons.Add(new Person("Oskar", "MItło", EducationLevel.średnie));
            persons.Add(new Person("Monika", "Eker", EducationLevel.podstawowe));
            persons.Add(new Person("Dawid", "Oki", EducationLevel.wyższe));
            persons.Add(new Person("Olgiert", "Piłka", EducationLevel.średnie));
        }
        public void SavePersons(string file)
        {
            //tu zapis do pliku
        }
    }
}