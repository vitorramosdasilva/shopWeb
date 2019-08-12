using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using shopWeb.Data;
using shopWeb.Models;

namespace shopWeb.Controllers
{
    public class FormapagamentosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FormapagamentosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Formapagamentos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Formapagamentos.ToListAsync());
        }

        // GET: Formapagamentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formapagamentos = await _context.Formapagamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formapagamentos == null)
            {
                return NotFound();
            }

            return View(formapagamentos);
        }

        // GET: Formapagamentos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Formapagamentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao")] Formapagamentos formapagamentos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formapagamentos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formapagamentos);
        }

        // GET: Formapagamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formapagamentos = await _context.Formapagamentos.FindAsync(id);
            if (formapagamentos == null)
            {
                return NotFound();
            }
            return View(formapagamentos);
        }

        // POST: Formapagamentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao")] Formapagamentos formapagamentos)
        {
            if (id != formapagamentos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formapagamentos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormapagamentosExists(formapagamentos.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(formapagamentos);
        }

        // GET: Formapagamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formapagamentos = await _context.Formapagamentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formapagamentos == null)
            {
                return NotFound();
            }

            return View(formapagamentos);
        }

        // POST: Formapagamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formapagamentos = await _context.Formapagamentos.FindAsync(id);
            _context.Formapagamentos.Remove(formapagamentos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormapagamentosExists(int id)
        {
            return _context.Formapagamentos.Any(e => e.Id == id);
        }
    }
}
