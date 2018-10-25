using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Models;

namespace ConsoleApp1
{
    public class BogusModelGenerator : IModelGenerator
    {

        public IEnumerable<RequestModel> GetRandomRequests(int size)
        {
            var requestFaker = new Faker<RequestModel>()
                .RuleFor(x => x.Index, a => a.Random.Number(10000))
                .RuleFor(x => x.Date, a => a.Date.Soon(30))
                .RuleFor(x => x.Visits, a => a.PickRandom<int?>(a.Random.Number(10000), null))
                .RuleFor(x => x.Name, a => a.Lorem.Word());

            return requestFaker.Generate(size);         
        }



    }
}
