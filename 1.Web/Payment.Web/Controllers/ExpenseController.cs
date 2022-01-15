﻿using Microsoft.AspNetCore.Mvc;
using Payment.Application.Models.Expense;
using Payment.Application.Models.PaymentInstituition;
using Payment.Application.Services.ExpenseService;
using Payment.Application.Services.PaymentInstituitionService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Payment.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly ExpenseService _expenseService;

        public ExpenseController(ExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create([FromBody] ExpenseRequestModel request)
        {
            await _expenseService.Add(request);
            return NoContent();
        }

        [HttpGet]
        [Route("")]
        public async Task<IList<ExpenseResponseModel>> GetAll()
        {
            return await _expenseService.GetAll();
        }

        [HttpDelete]
        [Route("")]
        public async Task Detele([FromQuery] Guid id)
        {
            await _expenseService.Delete(id);
        }


    }
}
