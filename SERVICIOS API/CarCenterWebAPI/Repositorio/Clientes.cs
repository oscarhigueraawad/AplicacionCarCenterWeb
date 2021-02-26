using CarCenterWebAPI.IRepositorio;
using CarCenterWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;


namespace CarCenterWebAPI.Repositorio
{
    public class Clientes : IClientes
    {
        private readonly CARCENTERContext _context;

        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<ActionResult<Cliente>> GetCliente(string id)
        {
            var cliente = await _context.Clientes.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }




        private ActionResult<Cliente> NotFound()
        {
            throw new NotImplementedException();
        }
    }
}
