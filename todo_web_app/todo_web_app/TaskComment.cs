using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace to_do_app
{
    public class TaskComment
    {
        public int Id { get; set; }
        public int IdTask { get; set; }
        public string Context { get; set; }
        public bool IsDeleted { get; set; }
        [ForeignKey(nameof(IdTask))]
        public virtual Task Comment { get; set; }
    }
       
}
