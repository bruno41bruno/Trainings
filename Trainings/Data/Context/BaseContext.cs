﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base(@"Data Source=192.168.0.165;Initial Catalog=Trainings;Persist Security Info=True;User ID=Trainings;Password=trainings@123")
        {

        }
    }
}