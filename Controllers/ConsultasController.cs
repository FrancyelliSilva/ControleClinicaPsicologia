using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControleClinicaPsicologia.Data;
using ControleClinicaPsicologia.Models;

namespace ControleClinicaPsicologia.Controllers
{
    public class ConsultasController : Controller
    {
        private readonly ControleClinicaPsicologiaContext _context;

        public ConsultasController(ControleClinicaPsicologiaContext context)
        {
            _context = context;
        }


        // GET: Consultas
        #region GET
        public async Task<IActionResult> Index()
        {
            return View(await _context.Consultas.ToListAsync());
        }

        #endregion

        
        // GET: Consultas/Create
        #region CREATE
        public IActionResult Create()
        {
           return View();
        }

        #endregion

        // POST: Consultas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        #region POST Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConsultaId,PacienteNome,PsicologoNome,Telefone,DataConsulta,HoraConsulta,Observacoes")] Consulta consulta)
        {
            if (ModelState.IsValid)
            {                
                 _context.Add(consulta);
                 await _context.SaveChangesAsync();
                 return RedirectToAction(nameof(Index));
                
            }

            return View(consulta);
        }

        #endregion



        // GET: Consultas/Edit/5

        #region EDITAR
        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas.FindAsync(id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        #endregion

        // POST: Consultas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        #region Edit POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas.FindAsync(id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        #endregion

        // GET: Consultas/Delete/5

        #region DELETE
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas
                .FirstOrDefaultAsync(m => m.ConsultaId == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }
        #endregion


        // POST: Consultas/Delete/5

        #region POST Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consulta = await _context.Consultas.FindAsync(id);
            if (consulta != null)
            {
                _context.Consultas.Remove(consulta);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        #endregion


        private bool ConsultaExists(int id)
        {
            return _context.Consultas.Any(e => e.ConsultaId == id);
        }

    }
}
