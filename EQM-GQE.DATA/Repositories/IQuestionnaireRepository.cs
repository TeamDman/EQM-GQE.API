﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQM_GQE.SHARED_RESOURCES.Models;

namespace EQM_GQE.DATA.Repositories
{
    public interface IQuestionnaireRepository
    {
        Task Add(Questionnaire Questionnaire);
    }
}
