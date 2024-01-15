using HimsLogs.Data.Commen;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HimsLogs.Data.Entities
{

    public class Log : BaseEntity
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public int LogLevelId { get; set; }
        public string ShortMessage { get; set; }
        public string FullMessage { get; set; }
        public string SourceService { get; set; }
        public string SourceFunction { get; set; }
        public DateTime CreatedOn { get; set; }









    }
}




