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
        public void AggiungiLibro(Libro l)
        {
            Libri.Add(l);
        }
        public Libro RicercaLibro(string titolo)
        {
            
            foreach(Libro l in Libri)
            {
                if (l.Titolo == titolo)
                {
                    return l;
                    
                }
                
            }
            return null;
            
        }
        public List<Libro> RicercaLibriAutore(string autore)
        {
            List<Libro> libriAutore=new List<Libro>();
            foreach(Libro l in Libri)
            {
                if (l.Autore == autore)
                {
                    libriAutore.Add(l);
                }
            }
            return libriAutore;
        }
        public int LibriPresenti()
        {
            return Libri.Count();
        }
    }
}