﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EQM_GQE.SHARED_RESOURCES.Models;
using EQM_GQE.LOGICAL;
using EQM_GQE.SHARED_RESOURCES.Interfaces;

namespace EQM_GQE.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionnaireController : ControllerBase
    {
        // Sample data
        private static readonly string[] Templates = new[]
        {
            "{ 'pages': [ { 'name': 'page1', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page2', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page3', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page4', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page5', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page6', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page7', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page8', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page9', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }", 
            "{ 'pages': [ { 'name': 'page10', 'elements': [ { 'type': 'text', 'name': 'question1' }, { 'type': 'checkbox', 'name': 'question2', 'choices': [ 'item1', 'item2', 'item3' ] } ] } ] }" 
        };
        
        private readonly IQuestionnaireLogic _questionnaireLogic;

        public QuestionnaireController(IQuestionnaireLogic questionnaireLogic)
        {
            _questionnaireLogic = questionnaireLogic;
        }

        [HttpGet]
        public IEnumerable<Questionnaire> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Questionnaire
            {
                Id = index,
                CreatedOn = DateTime.Now.AddDays(index),
                Template = Templates[rng.Next(Templates.Length)]
            })
            .ToArray();
        }

        [HttpPost]        
        public async Task<ActionResult> CreateQuestionnaire(Questionnaire oQuestionnaire)
        {
            var result = await _questionnaireLogic.Add(oQuestionnaire);
            if (result == 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpPut("{id}")]      
        public async Task<ActionResult> UpdateQuestionnaire(Questionnaire Questionnaire, long id)
        {
            if (id != Questionnaire.Id)
            {
                return BadRequest();
            }
            return await _questionnaireLogic.Update(Questionnaire) ? Ok() : BadRequest();
          
        }
    }
}
