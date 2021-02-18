using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Repository;
using RepositoryModel.response;
using RepositoryModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly ICurso _curso;
        public CursoController(ICurso curso)
        {
            _curso = curso;
        }
        [HttpGet("[action]")]
        public IActionResult GetAllCurso()
        {
            var model = _curso.GetAll();
            return Ok(model);
        }
        [HttpGet("[action]/{id}")] 
        public IActionResult GetByIdCurso([FromRoute] int id)
        {
            var model = _curso.GetById(id);
            return Ok(model);
        }
        [HttpPost("[action]")]
        public IActionResult saveCurso([FromBody] CursoViewModel model)
        {
            DataResult data = new DataResult();

            if (ModelState.IsValid)
            {
                data = _curso.Insert(model);
            }
            return Ok(data);

        }

        [HttpPut("[action]")]
        public IActionResult updateCurso([FromBody] CursoViewModel model)
        {
            DataResult data = new DataResult();
            if (ModelState.IsValid)
            {
                data = _curso.update(model);
            }
            return Ok(data);
        }
    }
}
