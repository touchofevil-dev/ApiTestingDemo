using ApiTesting.Models;
using System;
using System.Collections.Generic;

namespace ApiTesting
{
    public static class DataProvider
    {
        public static IDictionary<Guid, Student> GetInitialStudentData()
        {
            IDictionary<Guid, Student> data = new Dictionary<Guid, Student>();
            Guid id = Guid.Parse("36b1b202-2fe0-4e47-9dd8-6e2f9d1fb20a");
            data.Add(id, new Student() { Id = id, FirstName = "Tom", LastName = "Riddle", Age = 18, RollNo = 1 });
            id = Guid.Parse("8CACF277-90B2-4E69-9788-33FB7AEF7566");
            data.Add(id, new Student() { Id = id, FirstName = "Harry", LastName = "Potter", Age = 12, RollNo = 2 });
            id = Guid.Parse("2b5b32f5-877d-49ae-8304-971e2e814ef1");
            data.Add(id, new Student() { Id = id, FirstName = "Ron", LastName = "Weasley", Age = 13, RollNo = 3 });
            id = Guid.Parse("cfaf80cc-f7a4-436f-a671-387253d8e6c1");
            data.Add(id, new Student() { Id = id, FirstName = "Draco", LastName = "Malfoy", Age = 14, RollNo = 4 });
            id = Guid.Parse("27E01985-C093-4624-B3D7-F216CC493E0A");
            data.Add(id, new Student() { Id = id, FirstName = "Hermione", LastName = "Granger", Age = 13, RollNo = 5 });

            return data;
        }
    }
}
