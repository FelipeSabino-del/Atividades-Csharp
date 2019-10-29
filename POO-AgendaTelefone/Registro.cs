using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace POO_AgendaTelefone
{
    public class Registro
    {
        private string Nome;
        private string Telefone;
        private string Aniversario;
        public string _Nome
        {
            get{return Nome;}
        }
        public string _Telefone
        {
            get{return Telefone;}
        }
        public string _Aniversario
        {
            get{return Aniversario;}
        }

        public Registro (string Nome, string Telefone, string Aniversario)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Aniversario = Aniversario;
        }
    }
}