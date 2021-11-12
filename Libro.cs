using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaGITHUB
{
    class Libro
    { 
        //Classe Libro con attributi e metodi utili
        private string _autore;
        private string _titolo;
        private string _editore;
        private DateTime _anno;
        private int _nPagine;

        public Libro(string autore,string titolo,string editore,DateTime anno,int pagine)
        {
            Autore = autore;
            Editore = editore;
           Titolo=titolo;
            Anno = anno;
            NPagine = pagine;
        }
        public override string ToString()
        {
            return Titolo+" "+Autore+" "+Editore+" "+NPagine+" "+Anno;
        }
        public int ReadingTime()
        {
            int tempo = 0;
            if (NPagine <= 100)
            {
                tempo = 1;
            }
            else if (NPagine >= 200)
            {
                tempo = 3;
            }
            else
            {
                tempo = 2;
            }
            return tempo;
        }
        public string Autore
        {
            get;set;
        }
        public string Titolo
        {
            get;set;
        }
        public string Editore
        {
            get;set;
        }
        public DateTime Anno
        {
            get;set;
        }
        public int NPagine
        {
            get;set;
        }
    }
}
