﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoumaconSecurityOps.Core.Shared.Models.Readers;

namespace YoumaconSecurityOps.Core.Mediatr.Queries
{
    public record GetLocationsQuery : IQuery<IAsyncEnumerable<LocationReader>>
    {
        public Guid Id => Guid.NewGuid();
    }
}
