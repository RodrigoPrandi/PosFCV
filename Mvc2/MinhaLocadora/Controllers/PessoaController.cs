using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using MinhaLocadora.Models;

namespace MinhaLocadora.Controllers
{
    public class PessoaController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/Pessoa
        [Route("api/pessoa/lista")]
        public IQueryable<PessoaModels> GetPessoas()
        {
            return db.Pessoas;
        }

        // GET: api/Pessoa/5
        [ResponseType(typeof(PessoaModels))]
        [Route("api/pessoa/pesquisa/{id}")]
        public async Task<IHttpActionResult> GetPessoaModels(int id)
        {
            PessoaModels pessoaModels = await db.Pessoas.FindAsync(id);
            if (pessoaModels == null)
            {
                return NotFound();
            }

            return Ok(pessoaModels);
        }

        // PUT: api/Pessoa/5
        [ResponseType(typeof(void))]
        [Route("api/pessoa/alterar/{id}")]
        public async Task<IHttpActionResult> PutPessoaModels(int id, PessoaModels pessoaModels)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pessoaModels.Id)
            {
                return BadRequest();
            }

            db.Entry(pessoaModels).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoaModelsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Pessoa
        [ResponseType(typeof(PessoaModels))]
        [Route("api/pessoa/novo")]
        public async Task<IHttpActionResult> PostPessoaModels(PessoaModels pessoaModels)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pessoas.Add(pessoaModels);
            await db.SaveChangesAsync();

            return Ok(pessoaModels);
        }

        // DELETE: api/Pessoa/5
        [ResponseType(typeof(PessoaModels))]
        [Route("api/pessoa/excluir/{id}")]
        public async Task<IHttpActionResult> DeletePessoaModels(int id)
        {
            PessoaModels pessoaModels = await db.Pessoas.FindAsync(id);
            if (pessoaModels == null)
            {
                return NotFound();
            }

            db.Pessoas.Remove(pessoaModels);
            await db.SaveChangesAsync();

            return Ok(pessoaModels);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PessoaModelsExists(int id)
        {
            return db.Pessoas.Count(e => e.Id == id) > 0;
        }
    }
}