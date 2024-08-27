﻿using eCommerceServer.Service;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceServer.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public sealed class CategoriesController(CategoryService categoryService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var response = await categoryService.GetAllAsync(cancellationToken);
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> Create(string name, CancellationToken cancellationToken)
    {
        await categoryService.CreateAsync(name, cancellationToken);
        return Created();
    }
}