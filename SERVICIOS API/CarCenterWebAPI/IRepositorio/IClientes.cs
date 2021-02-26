using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarCenterWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarCenterWebAPI.IRepositorio
{
    public interface IClientes
    {
        Task<ActionResult<IEnumerable<Cliente>>> GetClientes();

        Task<ActionResult<Cliente>> GetCliente(string id);

        //Task<IActionResult> PutCliente(string id, Cliente cliente);

        //Task<ActionResult<Cliente>> PostCliente(Cliente cliente);

        //Task<ActionResult<Cliente>> DeleteCliente(string id);

    }
}
