using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidRefactor.RefactoringClasses.Interfaces
{
    internal interface ILoggingToFileService
    {
        void AppendToFile(string filePath, string contents);
        void WriteToText(string filePath, string contents);
    }
}
