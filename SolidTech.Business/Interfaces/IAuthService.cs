﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTech.Business.Interfaces
{
    public interface IAuthService
    {
        public User Login(LoginDto loginDto);


    }
}
