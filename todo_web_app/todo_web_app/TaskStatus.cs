using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace to_do_app
{
    public class TaskStatus
    {
        public int Id { get; set; }
        public string Context { get; set; }
        public int IdTask { get; set; }
        [ForeignKey(nameof(IdTask))]
        public virtual Task Status { get; set; }
    }
}
