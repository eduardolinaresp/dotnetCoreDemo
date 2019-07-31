using Hangfire;
using HangfireDemo.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireDemo.Jobs
{
    public class MyJob : IMyJob
    {
        private readonly ILogger<MyJob> _logger;
        private readonly MydbContext _dbContext;


        public MyJob(ILogger<MyJob> logger, MydbContext dbContext )
        {
            _logger = logger;
            _dbContext = dbContext;

        }

        public async Task Run(IJobCancellationToken token)
        {

            token.ThrowIfCancellationRequested();

            await RunAtTimeOf(DateTime.Now);

        }


        public async Task RunAtTimeOf(DateTime now)
        {
            _logger.LogInformation("Job Starts");

            await _dbContext.SaveChangesAsync();

            _logger.LogInformation("Job Complete");

        }
    }
}
