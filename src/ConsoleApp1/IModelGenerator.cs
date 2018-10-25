using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Models;

namespace ConsoleApp1
{
    interface IModelGenerator
    {
        IEnumerable<RequestModel> GetRandomRequests(int size);

    }
}
