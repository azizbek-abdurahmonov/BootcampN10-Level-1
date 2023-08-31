using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace N33_T1.Services
{
    public sealed class JsonFileManagementService : FileManagementServiceBase
    {
        public override Task<string> ReadAsync(string filePath)
        {

            if (filePath.EndsWith(".json"))
            {
                return base.ReadAsync(filePath);
            }

            throw new InvalidOperationException("File extension isn't valid");
        }

        public override Task WriteAsync(string filePath, string data)
        {
            if (filePath.EndsWith(".json"))
                return base.WriteAsync(filePath, data);

            throw new InvalidOperationException("File extension is not valid!");

        }

        public async Task<T> ReadAsync<T>(string filePath)
        {
            var obj = JsonSerializer.Deserialize<T>(await ReadAsync(filePath));
            return obj;
        }
    }
}
