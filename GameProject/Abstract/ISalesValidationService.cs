﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Concentre;
using GameProject.Entities;

namespace GameProject.Abstract
{
    internal interface ISaleValidationService
    {
        int Validatesale(Campaign campaign);
    }
}