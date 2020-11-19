﻿using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    public class PartidasController
    {
        private PartidasDAO partidasDAO;

        public PartidasController()
        {
            this.partidasDAO = new PartidasDAO();
        }

        public List<Partida> getList(int idLibroDiario)
        {
            List<Partida> lista = this.partidasDAO.getList(idLibroDiario);

            return lista;
        }

    }
}