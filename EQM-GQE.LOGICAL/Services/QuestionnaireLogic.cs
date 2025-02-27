﻿using EQM_GQE.SHARED_RESOURCES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQM_GQE.SHARED_RESOURCES.Interfaces;

namespace EQM_GQE.LOGICAL
{
    public class QuestionnaireLogic : IQuestionnaireLogic
    {
        private readonly IQuestionnaireRepository _questionnaireRepository;
      
        public QuestionnaireLogic(IQuestionnaireRepository questionnaireRepository)
        {
            _questionnaireRepository = questionnaireRepository;
        }

        public async Task<int> Add(Questionnaire oQuestionnaire)
        {
            Questionnaire questionnaire = new()
            {
                Template = oQuestionnaire.Template,
                DocumentTitle_EN = oQuestionnaire.DocumentTitle_EN,
                DocumentTitle_FR = oQuestionnaire.DocumentTitle_FR,
                CreatedOn = oQuestionnaire.CreatedOn,
                ModifiedOn = oQuestionnaire.ModifiedOn,
                CreatedBy = oQuestionnaire.CreatedBy,
                ModifiedBy = oQuestionnaire.ModifiedBy,
                ActiveStatus = oQuestionnaire.ActiveStatus,
                DocumentVersion = oQuestionnaire.DocumentVersion,
                EffectiveFromDate = oQuestionnaire.EffectiveFromDate,
                EffectiveToDate = oQuestionnaire.EffectiveToDate,
                ChangeSummary_EN = oQuestionnaire.ChangeSummary_EN,
                ChangeSummary_FR = oQuestionnaire.ChangeSummary_FR,
                OrganisationAccessibility = oQuestionnaire.OrganisationAccessibility,
                ParentId = oQuestionnaire.ParentId,
                BusinessLine = oQuestionnaire.BusinessLine,
                DocumentStatus = oQuestionnaire.DocumentStatus,
                DocumentType = oQuestionnaire.DocumentType,
                SecurityClassification = oQuestionnaire.SecurityClassification,
                DeletedOn = oQuestionnaire.DeletedOn
            };

            var id = await _questionnaireRepository.Add(questionnaire);
            return id;
        }

        public async Task<bool> Update(Questionnaire Questionnaire)
        {                 
            return await _questionnaireRepository.Update(Questionnaire);
        }
        
        public Questionnaire Get(int id)
        {
            var questionnaire = _questionnaireRepository.Get(id);
            return questionnaire;
        }

         public IList<Questionnaire> GetWithHistory(int id)
        {
            var list = new List<Questionnaire>();
            var questionnaire = _questionnaireRepository.Get(id);
            if (questionnaire != null){
                list.Add(questionnaire);
                list.AddRange(GetWithHistory(questionnaire.ParentId));
            }

            return list;
        }

        public async Task<List<Questionnaire>> GetAllAsync()
        {
            var questionnaires = await _questionnaireRepository.GetAllAsync();            
            return questionnaires;
        }

         public async Task<List<Questionnaire>> GetAllActiveAsync()
        {
            var questionnaires = await _questionnaireRepository.GetAllAsync(); 
            questionnaires = questionnaires.Where(q => q.ActiveStatus == true).ToList();
            return questionnaires;
        }

         public async Task<List<Questionnaire>> GetAllByModeAsync(int mode)
        {
            var questionnaires = await _questionnaireRepository.GetAllAsync();
            questionnaires = questionnaires.Where(q => q.ActiveStatus == true && q.BusinessLine.BusinessLineId == mode).ToList();         
            return questionnaires;
        }
    }
}
