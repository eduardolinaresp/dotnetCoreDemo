using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireDemo.Jobs
{
    public class HangfireJobScheduler
    {
        public static void ScheduleRecurringJobs()
        {

            //RecurringJob.RemoveIfExists(nameof(EmailSendingJob));

            RecurringJob.RemoveIfExists(nameof(MyJob));
            RecurringJob.AddOrUpdate<MyJob>(nameof(MyJob),
                 job => job.Run(JobCancellationToken.Null),
                 Cron.Daily(5, 00), TimeZoneInfo.Local
                );

        }

    }
}
