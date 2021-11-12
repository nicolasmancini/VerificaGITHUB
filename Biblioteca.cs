using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaGITHUB
{
    class Biblioteca
    {//nome, l’indirizzo e gli orari di apertura e chiusura giornaliera, che contenga l’elenco dei libri 
        private string _nome;
        private string _indirizzo;
        private DateTime _orarioApertura;
        private DateTime _orarioChiusura;
        private List<Libro> _libri;

        public Biblioteca(string nome,string indirizzo,DateTime orarioApertura,DateTime orarioChiusura,List<Libro> libri)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;
            Libri = libri;

        }
        public string Nome
        {
            get; set;
        }
        public string Indirizzo
        {
            get; set;
        }
        public DateTime OrarioApertura
        {
            get; set;
        }
        public DateTime OrarioChiusura
        {
            get; set;
        }
        public List<Libro> Libri
        {
            get;set;
        }
    }
}
