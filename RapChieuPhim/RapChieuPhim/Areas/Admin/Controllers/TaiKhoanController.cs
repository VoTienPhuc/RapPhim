﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RapChieuPhim.Areas.Admin.Data;
using RapChieuPhim.Areas.Admin.Models;

namespace RapChieuPhim.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TaiKhoanController : Controller
    {
        private readonly DPContext _context;

        public TaiKhoanController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/TaiKhoan
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.TaiKhoanModel.Include(t => t.NguoiDungModel);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/TaiKhoan/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoanModel = await _context.TaiKhoanModel
                .Include(t => t.NguoiDungModel)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (taiKhoanModel == null)
            {
                return NotFound();
            }

            return View(taiKhoanModel);
        }

        // GET: Admin/TaiKhoan/Create
        public IActionResult Create()
        {
            ViewData["NguoiDung_ID"] = new SelectList(_context.Set<NguoiDungModel>(), "ID", "ID");
            return View();
        }

        // POST: Admin/TaiKhoan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Ten_dang_nhap,Mat_khau,Loai_tai_khoan,NguoiDung_ID,Da_xoa")] TaiKhoanModel taiKhoanModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taiKhoanModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NguoiDung_ID"] = new SelectList(_context.Set<NguoiDungModel>(), "ID", "ID", taiKhoanModel.NguoiDung_ID);
            return View(taiKhoanModel);
        }

        // GET: Admin/TaiKhoan/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoanModel = await _context.TaiKhoanModel.FindAsync(id);
            if (taiKhoanModel == null)
            {
                return NotFound();
            }
            ViewData["NguoiDung_ID"] = new SelectList(_context.Set<NguoiDungModel>(), "ID", "ID", taiKhoanModel.NguoiDung_ID);
            return View(taiKhoanModel);
        }

        // POST: Admin/TaiKhoan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Ten_dang_nhap,Mat_khau,Loai_tai_khoan,NguoiDung_ID,Da_xoa")] TaiKhoanModel taiKhoanModel)
        {
            if (id != taiKhoanModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taiKhoanModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaiKhoanModelExists(taiKhoanModel.ID))
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
            ViewData["NguoiDung_ID"] = new SelectList(_context.Set<NguoiDungModel>(), "ID", "ID", taiKhoanModel.NguoiDung_ID);
            return View(taiKhoanModel);
        }

        // GET: Admin/TaiKhoan/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoanModel = await _context.TaiKhoanModel
                .Include(t => t.NguoiDungModel)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (taiKhoanModel == null)
            {
                return NotFound();
            }

            return View(taiKhoanModel);
        }

        // POST: Admin/TaiKhoan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var taiKhoanModel = await _context.TaiKhoanModel.FindAsync(id);
            _context.TaiKhoanModel.Remove(taiKhoanModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaiKhoanModelExists(string id)
        {
            return _context.TaiKhoanModel.Any(e => e.ID == id);
        }
    }
}
