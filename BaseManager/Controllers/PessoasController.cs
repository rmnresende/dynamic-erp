using System.Collections.Generic;
using BaseManager.Models;
using BaseManager.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BaseManager.Controllers
{
    [Route("api/pessoas")]
    public class PessoasController : ControllerBase
    {
        private readonly IPessoaRepository _repository;

        public PessoasController(IPessoaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("clientes/all")]
        public ActionResult<IEnumerable<Pessoa>> RecuperarTodosClientes()
        {
            var clientes = _repository.RecuperarCientes();
            return Ok(clientes);
        }

        [HttpGet("clientes/{idCliente}")]
        public ActionResult<Pessoa> RecuperarClientePeloId(long idCliente)
        {
            var cliente = _repository.RecuperarClientePeloId(idCliente);
            return Ok(cliente);
        }

        [HttpGet("fornecedores/all")]
        public ActionResult<IEnumerable<Pessoa>> RecuperarTodosFornecedores()
        {
            var fornecedores = _repository.RecuperarFornecedores();
            return Ok(fornecedores);
        }

        [HttpGet("fornecedores/{idFornecedor}")]
        public ActionResult<Pessoa> RecuperarFornecedorPeloId(long idFornecedor)
        {
            var fornecedor = _repository.RecuperarFornecedorPeloId(idFornecedor);
            return Ok(fornecedor);
        }
    }
}