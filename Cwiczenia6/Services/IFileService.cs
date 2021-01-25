using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia6.Services
{
    public interface IFileService
    {
        public void SaveToFile(string filename, string content);
    }
}
