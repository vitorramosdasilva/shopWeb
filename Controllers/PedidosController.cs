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
    public class PedidosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PedidosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pedidos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Pedidos.Include(p => p.IdclienteNavigation).Include(p => p.IdformapagNavigation).Include(p => p.IdstatusNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Pedidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidos = await _context.Pedidos
                .Include(p => p.IdclienteNavigation)
                .Include(p => p.IdformapagNavigation)
                .Include(p => p.IdstatusNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedidos == null)
            {
                return NotFound();
            }

            return View(pedidos);
        }

        // GET: Pedidos/Create
        public IActionResult Create()
        {
            ViewData["Idcliente"] = new SelectList(_context.Clientes, "Id", "Bairro");
            ViewData["Idformapag"] = new SelectList(_context.Formapagamentos, "Id", "Descricao");
            ViewData["Idstatus"] = new SelectList(_context.Set<Status>(), "Id", "Situacao");
            return View();
        }

        // POST: Pedidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Idcliente,Idformapag,Frete,Total,Idstatus,Data")] Pedidos pedidos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pedidos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idcliente"] = new SelectList(_context.Clientes, "Id", "Bairro", pedidos.Idcliente);
            ViewData["Idformapag"] = new SelectList(_context.Formapagamentos, "Id", "Descricao", pedidos.Idformapag);
            ViewData["Idstatus"] = new SelectList(_context.Set<Status>(), "Id", "Situacao", pedidos.Idstatus);
            return View(pedidos);
        }

        // GET: Pedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidos = await _context.Pedidos.FindAsync(id);
            if (pedidos == null)
            {
                return NotFound();
            }
            ViewData["Idcliente"] = new SelectList(_context.Clientes, "Id", "Bairro", pedidos.Idcliente);
            ViewData["Idformapag"] = new SelectList(_context.Formapagamentos, "Id", "Descricao", pedidos.Idformapag);
            ViewData["Idstatus"] = new SelectList(_context.Set<Status>(), "Id", "Situacao", pedidos.Idstatus);
            return View(pedidos);
        }

        // POST: Pedidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Idcliente,Idformapag,Frete,Total,Idstatus,Data")] Pedidos pedidos)
        {
            if (id != pedidos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedidos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidosExists(pedidos.Id))
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
            ViewData["Idcliente"] = new SelectList(_context.Clientes, "Id", "Bairro", pedidos.Idcliente);
            ViewData["Idformapag"] = new SelectList(_context.Formapagamentos, "Id", "Descricao", pedidos.Idformapag);
            ViewData["Idstatus"] = new SelectList(_context.Set<Status>(), "Id", "Situacao", pedidos.Idstatus);
            return View(pedidos);
        }

        // GET: Pedidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidos = await _context.Pedidos
                .Include(p => p.IdclienteNavigation)
                .Include(p => p.IdformapagNavigation)
                .Include(p => p.IdstatusNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedidos == null)
            {
                return NotFound();
            }

            return View(pedidos);
        }

        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pedidos = await _context.Pedidos.FindAsync(id);
            _context.Pedidos.Remove(pedidos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PedidosExists(int id)
        {
            return _context.Pedidos.Any(e => e.Id == id);
        }
    }
}
