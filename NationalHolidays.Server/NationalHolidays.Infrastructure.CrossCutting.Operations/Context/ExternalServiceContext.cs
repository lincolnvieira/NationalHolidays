﻿using Microsoft.Extensions.Options;
using NationalHolidays.Infrastructure.ExternalService.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalHolidays.Infrastructure.ExternalService.Context
{
    public class ExternalServiceContext
    {
        protected string NationalHolidayAPI { get; }

        public ExternalServiceContext(IOptions<ExternalServiceOptions> configuration)
        {
            NationalHolidayAPI = configuration.Value.UrlNationalHolidayAPI;
        }
    }
}
