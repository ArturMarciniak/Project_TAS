using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace to_do_app
{
    public class Task
    {
        public int Id { get; set; }
        public string Context { get; set; }
        public string IdStatus { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<UsersInTask> User { get; set; }

        public ICollection<TaskComment> Comment { get; set; }
        
        public ICollection<TaskStatus> Status { get; set; }

    }
}
