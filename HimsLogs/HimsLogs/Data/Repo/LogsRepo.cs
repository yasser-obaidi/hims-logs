using HimsLogs.Data;
using HimsLogs.Data.Entities;

using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using MySqlX.XDevAPI.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using HimsLogs.Data.Entities;
using HimsLogs.Data.Repo.Commen;

namespace HimsLogs.Data.Repo
{
    public class LogsRepo : Repository<Log>
    {
        public LogsRepo(Context context) : base(context)
        {

        }
        public async Task<string> Add(Log input)
        {
            await AddAsync(input);
            await context.SaveChangesAsync();
            input.CreatedAt = DateTime.Now;
            return "Added successfully";
        }
        public async Task<List<Log>> GetAll()
        {
            return await Get().ToListAsync();
        }
        public async Task<Log> GetById(int id)
        {
            var result = await context.Logs
                .FirstOrDefaultAsync(e => e.Id == id );

            if (result != null)
            {
                return await context.Logs
                .FirstOrDefaultAsync(e => e.Id == id);

            }
            throw new Exception("id not found");
        }
        
            public async Task<Log> GetLogsByLogLevelId(int logLevelId)
        {
            var result = await context.Logs
                .FirstOrDefaultAsync(e => e.LogLevelId == logLevelId);

            if (result != null)
            {
                return await context.Logs
                .FirstOrDefaultAsync(e => e.LogLevelId == logLevelId);

            }
            throw new Exception("LogsLogLevelId NOT FOUND");
        }


    }
}
