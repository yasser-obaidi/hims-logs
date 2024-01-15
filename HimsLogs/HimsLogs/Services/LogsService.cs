using HimsLogs.Data;
using HimsLogs.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HimsLogs.Data.Repo;
using HimsLogs.Data.Repo.Commen;
using System.Diagnostics.Metrics;
namespace HimsLogs.Services
{
    public class LogsService
    {
        private readonly IUnitOfWork unit;
        public LogsService(IUnitOfWork unitOfWork)
        { //injection repo in service
            unit = unitOfWork;
        }
        public async Task<List<Log>> GetAll()
        {
            return await unit.logsRepo.GetAll();
        }
        public async Task<Log> GetById(int id)
        {
            var res = await unit.logsRepo.GetById(id);
            return res;
        }
        public async Task<Log> GetLogsByLogLevelId(int id)
        {
            var res = await unit.logsRepo.GetLogsByLogLevelId(id);
            return res;
        }
        
        public async Task<string> Add(Log input)
        {
            
            var res = await unit.logsRepo.Add(input);
            return res;






        }
        
             public async Task<string> DeleteLogs(int id)
        {
            var res = await unit.logsRepo.DeleteLogs(id);
            return res;


        }


    }
}

