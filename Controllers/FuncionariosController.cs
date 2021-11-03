using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MatrixCrud.Models;
using ProjetoAquasis.Models;

namespace MatrixCrud.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly FuncionarioContext _context;

        public FuncionariosController(FuncionarioContext context)
        {
            _context = context;
        }

        // GET: Funcionarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.funcionarios.ToListAsync());
        }

       

        // GET: Funcionarios/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Funcionario());
            else
                return View(_context.funcionarios.ToListAsync());
        }

        // POST: Funcionarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("FuncionId,Nome,Matricula,posição,estado")] Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                if (funcionario.FuncionId == 0)
                    _context.Add(funcionario);
                else 
                    _context.Update(funcionario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(funcionario);
        }


        // POST: Funcionarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        

        // GET: Funcionarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var funcionario = await _context.funcionarios.FindAsync(id);
            _context.funcionarios.Remove(funcionario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index)); ;
        }


       
    }
}
