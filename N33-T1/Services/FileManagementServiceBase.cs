using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N33_T1.Services
{
    public abstract class FileManagementServiceBase
    {
        public virtual async Task<string> ReadAsync(string filePath)
        {
            var allText = await File.ReadAllTextAsync(filePath);
            return allText;
        }

        public virtual async Task WriteAsync(string filePath, string data)
        {
            await File.WriteAllTextAsync(filePath, data);
        }


    }
}
