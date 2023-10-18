using System.Collections;

namespace CodeWarts.Infrastructure.Practice;

public class EnumerationPractice
{
    public static void Execute()
    {
        // var persons = new Person[]
        // {
        //     new Person() { Name = "Name1", Surname = "Surname1" },
        //     new Person() { Name = "Name2", Surname = "Surname2" },
        //     new Person() { Name = "Name3", Surname = "Surname3" },
        //     new Person() { Name = "Name4", Surname = "Surname4" },
        //     new Person() { Name = "Name5", Surname = "Surname5" }
        // };
        //
        // var personEnumerable = new PersonEnumerable(persons);
        //
        // while (personEnumerable.GetEnumerator().MoveNext())
        // {
        //     var enumerator = personEnumerable.GetEnumerator();
        //     var current = personEnumerable.GetEnumerator().Current;
        // }
        //
        var personsList = new List<Person>()
        {
            new Person() { Name = "Name1", Surname = "Surname1" },
            new Person() { Name = "Name2", Surname = "Surname2" }
        };

        var enumeratorL = personsList.GetEnumerator();
        var a1 = enumeratorL.Current;
        var a2 = enumeratorL.Current;
        var a3 = enumeratorL.MoveNext();
        var a4 = enumeratorL.Current;
    }

    private class PersonEnumerable : IEnumerable<Person>
    {
        private IEnumerator<Person> _enumerator;

        public PersonEnumerable(Person[] persons)
        {
            _enumerator = new PersonEnumerator(persons);
        }

        public IEnumerator<Person> GetEnumerator() => _enumerator;

        IEnumerator IEnumerable.GetEnumerator() => _enumerator;
    }

    private class PersonEnumerator : IEnumerator<Person>
    {
        private Person[] _persons;
        private int _index;

        public PersonEnumerator(Person[] persons)
        {
            _persons = persons;
            _index = 0;
        }

        public bool MoveNext()
        {
            Current = _persons[_index];
            _index++;
            return _index <= _persons.Length;
        }

        public void Reset()
        {
            _index = 0;
        }

        public Person Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }

    private class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    private class PersonCollection : ICollection<Person>
    {
        private Person[] _persons;
        private int _index;

        public PersonCollection(Person[] persons)
        {
            _persons = persons;
            _index = 0;
        }

        public IEnumerator<Person> GetEnumerator() =>
            new PersonEnumerator(_persons);

        IEnumerator IEnumerable.GetEnumerator()=>
            new PersonEnumerator(_persons);

        public void Add(Person item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            Array.Clear(_persons);
        }

        public bool Contains(Person item)
        {
            return false;
        }

        public void CopyTo(Person[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Person item)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
    }
}