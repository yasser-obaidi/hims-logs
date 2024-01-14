using HimsLogs.Services;
using HimsLogs.Data.Repo;
using Microsoft.EntityFrameworkCore;
namespace HimsLogs.Services
{
    public interface IUnitOfWork
    {
        public LogsRepo logsRepo { get; }
    }
    public class UnitOfWork : IUnitOfWork
    {
        public LogsRepo logsRepo { get; }
        public UnitOfWork(LogsRepo Repo)
        {
            logsRepo = Repo;



        }
    }
    }

