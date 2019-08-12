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
    public class ItenspedidosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItenspedidosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Itenspedidos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Itenspedidos.Include(i => i.IdpedidoNavigation).Include(i => i.IdprodutoNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Itenspedidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itenspedidos = await _context.Itenspedidos
                .Include(i => i.IdpedidoNavigation)
                .Include(i => i.IdprodutoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itenspedidos == null)
            {
                return NotFound();
            }

            return View(itenspedidos);
        }

        // GET: Itenspedidos/Create
        public IActionResult Create()
        {
            ViewData["Idpedido"] = new SelectList(_context.Set<Pedidos>(), "Id", "Data");
            ViewData["Idproduto"] = new SelectList(_context.Set<Produtos>(), "Id", "Descricao");
            return View();
        }

        // POST: Itenspedidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Idproduto,Idpedido,Quantidade")] Itenspedidos itenspedidos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itenspedidos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idpedido"] = new SelectList(_context.Set<Pedidos>(), "Id", "Data", itenspedidos.Idpedido);
            ViewData["Idproduto"] = new SelectList(_context.Set<Produtos>(), "Id", "Descricao", itenspedidos.Idproduto);
            return View(itenspedidos);
        }

        // GET: Itenspedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itenspedidos = await _context.Itenspedidos.FindAsync(id);
            if (itenspedidos == null)
            {
                return NotFound();
            }
            ViewData["Idpedido"] = new SelectList(_context.Set<Pedidos>(), "Id", "Data", itenspedidos.Idpedido);
            ViewData["Idproduto"] = new SelectList(_context.Set<Produtos>(), "Id", "Descricao", itenspedidos.Idproduto);
            return View(itenspedidos);
        }

        // POST: Itenspedidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Idproduto,Idpedido,Quantidade")] Itenspedidos itenspedidos)
        {
            if (id != itenspedidos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itenspedidos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItenspedidosExists(itenspedidos.Id))
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
            ViewData["Idpedido"] = new SelectList(_context.Set<Pedidos>(), "Id", "Data", itenspedidos.Idpedido);
            ViewData["Idproduto"] = new SelectList(_context.Set<Produtos>(), "Id", "Descricao", itenspedidos.Idproduto);
            return View(itenspedidos);
        }

        // GET: Itenspedidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itenspedidos = await _context.Itenspedidos
                .Include(i => i.IdpedidoNavigation)
                .Include(i => i.IdprodutoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itenspedidos == null)
            {
                return NotFound();
            }

            return View(itenspedidos);
        }

        // POST: Itenspedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itenspedidos = await _context.Itenspedidos.FindAsync(id);
            _context.Itenspedidos.Remove(itenspedidos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItenspedidosExists(int id)
        {
            return _context.Itenspedidos.Any(e => e.Id == id);
        }
    }
}
