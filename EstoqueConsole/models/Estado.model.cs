﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueConsole.models
{
    class Estado : Pais
    {
        public int idPais { get; set; }
        public string estado { get; set; }
        public string uf { get; set; }

        public int cadastrarEstado(int idPais, string nomeEstado, string uf = "")
        {
            var db = new estoqueEntities();

            var estado = db.ESTADO.Create();

            estado.PAIS_idPAIS = idPais;
            estado.NOME_ESTADO = nomeEstado;
            estado.UF = uf;

            db.ESTADO.Add(estado);
            db.SaveChanges();

            return estado.idESTADO;
        }
    }
}
