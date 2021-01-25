using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wyklad6_nauka.Services
{
    public interface IFileService
    {
        public void SaveToFile(string filename, string content);
    }
}
