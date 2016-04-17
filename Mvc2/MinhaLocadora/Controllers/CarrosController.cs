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
    public class CarrosController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/Carros
        [Route("api/carro/lista")]
        public IQueryable<CarrosModels> GetCarros()
        {
            return db.Carros.Include(i => i.Pessoa);
        }

        // GET: api/Carros/5
        [ResponseType(typeof(CarrosModels))]
        [Route("api/carro/pesquisa/{id}")]
        public async Task<IHttpActionResult> GetCarrosModels(int id)
        {
            CarrosModels carrosModels = await db.Carros.FindAsync(id);
            if (carrosModels == null)
            {
                return NotFound();
            }

            return Ok(carrosModels);
        }

        // PUT: api/Carros/5
        [ResponseType(typeof(void))]
        [Route("api/carro/alterar/{id}")]
        public async Task<IHttpActionResult> PutCarrosModels(int id, CarrosModels carrosModels)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carrosModels.Id)
            {
                return BadRequest();
            }

            db.Entry(carrosModels).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarrosModelsExists(id))
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

        // POST: api/Carros
        [ResponseType(typeof(CarrosModels))]
        [Route("api/carro/novo")]
        public async Task<IHttpActionResult> PostCarrosModels(CarrosModels carrosModels)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Carros.Add(carrosModels);
            await db.SaveChangesAsync();

            return Ok(carrosModels);
        }

        // DELETE: api/Carros/5
        [ResponseType(typeof(CarrosModels))]
        [Route("api/carro/excluir/{id}")]
        public async Task<IHttpActionResult> DeleteCarrosModels(int id)
        {
            CarrosModels carrosModels = await db.Carros.FindAsync(id);
            if (carrosModels == null)
            {
                return NotFound();
            }

            db.Carros.Remove(carrosModels);
            await db.SaveChangesAsync();

            return Ok(carrosModels);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarrosModelsExists(int id)
        {
            return db.Carros.Count(e => e.Id == id) > 0;
        }
    }
}