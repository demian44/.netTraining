using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Models
{
    public class MyDependency : IMyDependency
    {
        private readonly ILogger<MyDependency> _logger;

        public MyDependency(ILogger<MyDependency> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public Task WriteMessage(string message)
        {
            _logger.LogInformation(
                "MyDependency.WriteMessage called. Message: {MESSAGE}",
                message);

            return Task.FromResult(0);
        }
    }
}
