using System;
using System.Threading.Tasks;

namespace HangfireDemo.Jobs
{
    public interface IMyJob
    {

        Task RunAtTimeOf(DateTime now);
    }
}