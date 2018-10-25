using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Models;

namespace ConsoleApp1
{
    public interface IModelSender
    {
        Task<bool> SendModels(IEnumerable<RequestModel> models);
    }
}
