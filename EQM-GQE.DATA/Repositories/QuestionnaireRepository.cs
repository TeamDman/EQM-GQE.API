﻿using EQM_GQE.SHARED_RESOURCES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQM_GQE.DATA.Repositories
{
    public class QuestionnaireRepository : IQuestionnaireRepository
    {
        private readonly IQuestionnaireContext _context;

        public QuestionnaireRepository(IQuestionnaireContext context)
        {
            _context  = context;
        }

        public async Task Add(Questionnaire Questionnaire)
        {
            _context.Questionnaires.Add(Questionnaire);
            await _context.SaveChangesAsync();
        }
    }
}
