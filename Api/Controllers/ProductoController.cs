using Api.Models;
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
    public class ProductoController : ControllerBase
    {
        private readonly ApiDataContext _context;
        public ProductoController(ApiDataContext apiDataContext)
        {
            _context = apiDataContext;
        }

        [HttpGet]
        [ActionName(nameof(GetProductoAsync))]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProductoAsync()
        {
            return await _context.Productos.ToListAsync();
        }

        [HttpGet("{id}")]
        [ActionName(nameof(GetProductoById))]
        public async Task<ActionResult<Producto>> GetProductoById(int id)
        {
            var productoById = await _context.Productos.FindAsync(id);
            if (productoById == null)
            {
                return NotFound();
            }
            return productoById;
        }

        [HttpPost]
        [ActionName(nameof(CreateProductoAsync))]
        public async Task<ActionResult<Producto>> CreateProductoAsync(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductoById), new { id = producto.Id }, producto);

        }

        [HttpPut("{id}")]
        [ActionName(nameof(UpdateProducto))]
        public async Task<ActionResult<Producto>> UpdateProducto(int id, Producto producto)
        {
            if (id != producto.Id)
            {
                return BadRequest();
            }

            _context.Entry(producto).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();//Guarda en la base de datos
            }
            catch
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ActionName(nameof(DeleteProducto))]
        public async Task<ActionResult<Producto>> DeleteProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }

            _context.Productos.Remove(producto); //Borrar producto
            await _context.SaveChangesAsync(); //Guarda los cambios

            return NoContent();
        }
    }
}
