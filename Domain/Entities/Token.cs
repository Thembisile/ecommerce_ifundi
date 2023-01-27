﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Token : BaseEntity<Guid>, IAggregateRoot
    {

        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }

        public string EndTimeRefreshToken { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }

    }
}
