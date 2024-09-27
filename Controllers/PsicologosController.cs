using ControleClinicaPsicologia.Data;
using ControleClinicaPsicologia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleClinicaPsicologia.Controllers
{

    public class PsicologosController : Controller
    {
        private readonly ControleClinicaPsicologiaContext _context;
        

        public PsicologosController(ControleClinicaPsicologiaContext context)
        {
            _context = context;
        }

        #region GET

        public async Task<IActionResult> Index()
        {
            return View(await _context.Psicologos.ToListAsync());
        }
        #endregion



        #region GET Create
        public IActionResult Create()
        {
            return View();
        }
        #endregion

        // POST: Psicologos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        #region POST Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PsicologoId,PsicologoNome,Especialidade,NumeroRegistro,Telefone")] Psicologo psicologo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(psicologo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(psicologo);

        }
        #endregion

        // POST: Psicologos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.


        // GET: Psicologos/Edit/5
        #region GET Edit
        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var psicologo = await _context.Psicologos.FindAsync(id);
            if (psicologo == null)
            {
                return NotFound();
            }
            return View(psicologo);
        }


        #endregion

        #region POST Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var psicologo = await _context.Psicologos.FindAsync(id);
            if (psicologo == null)
            {
                return NotFound();
            }

            return View(psicologo);
        }

        #endregion

        #region Delete
        // GET: Psicologoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var psicologo = await _context.Psicologos
                .FirstOrDefaultAsync(m => m.PsicologoId == id);
            if (psicologo == null)
            {
                return NotFound();
            }

            return View(psicologo);
        }
        #endregion

        // POST: Psicologoes/Delete/5

        #region Delete POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var psicologo = await _context.Psicologos.FindAsync(id);
            if (psicologo != null)
            {
                _context.Psicologos.Remove(psicologo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        private bool PsicologoExists(int id)
        {
            return _context.Psicologos.Any(e => e.PsicologoId == id);
        }


    }
}
