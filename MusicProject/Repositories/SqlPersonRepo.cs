using MusicProject.Models;
using System;
using System.Collections.Generic;

namespace MusicProject.Repositories
{
    public class SqlPersonRepo : IPersonRepo
    {
        public PersonModel FetchPerson(string name)
        {
            throw new NotImplementedException();
        }

        public PersonModel CreatePerson(string name, DateTime birthDate, DateTime? deathDate, string homeRegion)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<PersonModel> GetMembers(string artistName)
        {
            throw new NotImplementedException();
        }

        public PersonModel SavePerson(string oldName, string newName, DateTime birthDate, DateTime? deathDate, string homeRegion)
        {
            throw new NotImplementedException();
        }
    }
}
