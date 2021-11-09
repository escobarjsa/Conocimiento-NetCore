using Api.DBModels;
using Api.Models.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteCategoriaController : ControllerBase
    {
        private readonly ApiDataContext _context;

        public ClienteCategoriaController(ApiDataContext apiDataContext)
        {
            _context = apiDataContext;
        }

        [HttpGet]
        [ActionName(nameof(GetCategoriaClienteAsync))]
        public async Task<ActionResult<IEnumerable<CategoriaCliente>>> GetCategoriaClienteAsync()
        {

            return await _context.CategoriaClientes.ToListAsync();
        }

        [HttpGet("{id}")]
        [ActionName(nameof(GetCategoriaClienteById))]
        public async Task<ActionResult<CategoriaCliente>> GetCategoriaClienteById(int id)
        {
            var categoriaClienteById = await _context.CategoriaClientes.FindAsync(id);
            if(categoriaClienteById == null)
            {
                return NotFound();
            }
            return categoriaClienteById;
            //return await _context.CategoriaClientes.ToListAsync();
        }

        [HttpPost]
        [ActionName(nameof(CreateCategoriaClienteAsync))]
        public async Task<ActionResult<CategoriaCliente>> CreateCategoriaClienteAsync(CategoriaCliente  categoriaCliente)
        {
            _context.CategoriaClientes.Add(categoriaCliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCategoriaClienteById), new { id = categoriaCliente.CategoriaId }, categoriaCliente);

        }

    }
}
