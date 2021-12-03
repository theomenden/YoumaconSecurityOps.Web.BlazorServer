﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoumaconSecurityOps.Core.Shared.Models.Readers;
using YoumaconSecurityOps.Core.Shared.Parameters;

namespace YoumaconSecurityOps.Core.Mediatr.Queries
{
    public class GetShiftListWithParametersQuery: QueryBase<IAsyncEnumerable<ShiftReader>>
    {
        public GetShiftListWithParametersQuery(ShiftQueryStringParameters parameters)
        {
            Parameters = parameters;
        }

        public ShiftQueryStringParameters Parameters { get;}
    }
}