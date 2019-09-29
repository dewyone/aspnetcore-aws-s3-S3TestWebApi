﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace S3TestWebApi.Models
{
    public class S3Response
    {
        public HttpStatusCode Status { get; set; }

        public string Message { get; set; }
    }
}
