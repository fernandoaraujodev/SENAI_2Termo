﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_ORM.Domains;
using Api_ORM.Interfaces;
using Api_ORM.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_ORM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutosController()
        {
            _produtoRepository = new ProdutoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                // lista os produtos no repositorio
                var produtos = _produtoRepository.Listar();

                // verifica se existe os produtos
                // caso não tenha retorna sem conteudo
                if (produtos.Count == 0)
                    return NoContent();

                //caso exista retorna Ok
                return Ok(produtos);
            }
            catch (Exception ex)
            {
                // caso ocorra algum erro retorna BadRequest e a error message
                return BadRequest(ex.Message);
            }
        }

        // GET api/
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                var produtos = _produtoRepository.BuscarPorId(id);

                if (produtos == null)
                    return NotFound();

                return Ok(produtos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post (Produto produto)
        {
            try
            {
                //adiciona um produto
                _produtoRepository.Adicionar(produto);

                //retorna um OK com os dados do prouto
                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Produto produto)
        {
            try
            {
                produto.Id = id;
                _produtoRepository.Editar(produto);

                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _produtoRepository.Remover(id);

                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
