/*
 ------------------------------------------------------------------------------------------------
                                 BENNER
 ------------------------------------------------------------------------------------------------
 Projeto(s).......: Avaliação - BENNER
 Sistema(s).......: Microondas Digital
 Cliente(s).......: BENNER
 Requisitante(s)..: 
 Gestor(es).......: 
 Desenvolvedor(es): Sergio Jr
 Descrição........: Programa (Models)
 Data.............: 30/01/2020
 Parametrô(s).....: N/A
 -------------------------------------------------------------------------------------------------
 Manutenção.......:
 Requisitante(s)..: 
 Desenvolvedor(es): 
 Descrição........: 
 Data.............: 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.Models
{
    public class Programa
    {
        private string _nome;
        private string _instrucoes;
        private int _tempo;
        private int _potencia;
        private char _caracter;

        public Programa()
        {

        }

        public Programa(string nome, string instrucoes, int tempo, int potencia, char carcter)
        {
            Nome = nome;
            Instrucoes = instrucoes;
            Tempo = tempo;
            Potencia = potencia;
            Carcter = carcter;

        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Instrucoes { get => _instrucoes; set => _instrucoes = value; }
        public int Tempo { get => _tempo; set => _tempo = value; }
        public int Potencia { get => _potencia; set => _potencia = value; }
        public char Carcter { get => _caracter; set => _caracter = value; }
    }
}
