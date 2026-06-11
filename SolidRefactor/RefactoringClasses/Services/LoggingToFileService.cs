using SolidRefactor.RefactoringClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidRefactor.RefactoringClasses.Services
{
    internal class LoggingToFileService : ILoggingToFileService
    {
        public void AppendToFile(string filePath, string contents)
        {
            File.AppendAllText(filePath, contents);
        }

        public void WriteToText(string filePath, string contents)
        {
            File.WriteAllText(filePath, contents);
        }
    }
}
