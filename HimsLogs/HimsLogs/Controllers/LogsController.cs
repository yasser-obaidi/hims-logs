using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HimsLogs.Data.Entities;
using HimsLogs.Data.Repo;
using HimsLogs.Services;
using HimsLogs.Data;
using System.Diagnostics.Metrics;

namespace HimsLogs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogsController : Controller
    {
        private readonly LogsRepo _Repo;
        private readonly LogsService service;

        public LogsController(LogsRepo logRepo, LogsService logService)
        {
            _Repo = logRepo;
            service = logService;


        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add(Log input)
        {
            try
            {
                var res = await service.Add(input);

                return Ok(res);



            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAsync()
        {
            try
            {
                return Ok(await service.GetAll() ) ;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            

        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(await service.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("GetLogsByLogLevelId")]

        public async Task<IActionResult> GetLogsByLogLevelId(int logLevelId)
        {
            {
                try
                {
                   
                    return Ok(await service.GetLogsByLogLevelId(logLevelId));

                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }

        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteLog(int input)
        {



            try
            {
                var res = await service.DeleteLogs(input);

                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
