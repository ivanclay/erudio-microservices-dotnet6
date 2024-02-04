﻿using RestWithAspNet5Udemy.Model;
using System;
using System.Collections.Generic;
using System.Threading;

namespace RestWithAspNet5Udemy.Services.Impementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                persons.Add(MockPerson(i));
            }
            return persons;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Ivan" + i,
                LastName = "Moura" + i,
                Address = "B Street, City A" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindById(long id)
        {
            return new Person 
            {
                Id = id,
                FirstName = "Ivan",
                LastName = "Moura",
                Address = "B Street, City A",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
