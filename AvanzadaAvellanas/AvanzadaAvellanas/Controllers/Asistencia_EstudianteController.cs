﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvanzadaAvellanas.ViewModel.Asistencia_EstudianteViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AvanzadaAvellanas.Controllers
{
    public class Asistencia_EstudianteController : Controller
    {
        //private IRepositorioAsistencia_Estudiante repoAsistencia;

        public Asistencia_EstudianteController ()
        {
            //repoAsistencia = new Estructura();
        }
        public IActionResult Asistencia_Estudiante()
        {
            //ViewBag.Title = "Asistencia de Estudiantes";

            return View(new Asistencia_EstudianteViewModel()
            {
                //Title = "Asistencia de Estudiante",
                //Asistencia = repoAsistencia.ObtenerAsistenciaEstudiantes()
            });
            

        }
    }
}