﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerJobStoreQuartz_TS
{
    interface IService
    {
        void Start();
        void Stop();
    }
}
