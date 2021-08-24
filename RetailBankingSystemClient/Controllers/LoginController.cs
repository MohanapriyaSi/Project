﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetailBankingSystemClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RetailBankingSystemClient.Controllers
{
    public class LoginController : Controller
    {
        // GET: LoginController1

        public ActionResult Index(string user)
        {
            //string role = user;
            //if(role=="admin")
            //{
            //    return RedirectToAction("Customer");
            //}
            //else
            //{
                return View();
            //}

            
        }


        // GET: LoginController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
