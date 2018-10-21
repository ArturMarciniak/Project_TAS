using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace to_do_app
{
    public class UsersInTask
    {
        public int Id { get; set; }

        public int IdUser { get; set; }

        [ForeignKey(nameof(IdUser))]
        public virtual User User { get; set; }

        public int IdTask { get; set; }

        [ForeignKey(nameof(IdTask))]
        public virtual Task Task { get; set; }
    }
}
