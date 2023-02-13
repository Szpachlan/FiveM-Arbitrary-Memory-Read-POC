using System;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace MyResource.Client
{
    public class ClientMain : BaseScript
    {
        public ClientMain()
        {
            ulong mem_address = 0x7ff7d4440000;

            try
            {
                OutputArgument outputArgument = new OutputArgument(mem_address);
                string result = outputArgument.GetResult<string>();
                Debug.WriteLine(string.Concat(new string[]
                {
                    "read len ",
                    result.Length.ToString(),
                    " string '",
                    result,
                    "'"
                }));
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}