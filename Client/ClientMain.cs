using System;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace MyResource.Client
{
    public class ClientMain : BaseScript
    {
        public ClientMain()
        {
            // Address from memory
            ulong mem_address = 0x7ff7d4440000;

            try
            {
                OutputArgument outputArgument = new OutputArgument(mem_address);
                // Returns the string from specific address
                string result = outputArgument.GetResult<string>();
                // Prints result and length of result
                Debug.WriteLine(string.Concat(new string[]
                {
                    "read len ",
                    result.Length.ToString(),
                    " string '",
                    result,
                    "'"
                }));
            }
            // Throw an error if address is invalid
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
