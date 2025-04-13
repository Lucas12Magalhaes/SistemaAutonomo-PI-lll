﻿using KingMeServer;
using sistema_autonomo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_autonomo
{
    internal class Automacao
    {
        public void Posicionar(int jogador, string senha,int id)
        {
            string minhasCartas = Jogo.ListarCartas(jogador, senha);
            string[] minhasCartasTratadas = new string[minhasCartas.Length];
            string tabuleiro = Jogo.VerificarVez(id);
            tabuleiro = tabuleiro.Replace("\r", "");
            string[] tabuleiroTratado;
            tabuleiroTratado = tabuleiro.Split('\n');
            List<string> CartasJogadas = new List<string>();
            MessageBox.Show(minhasCartas);
          
            for(int i =1; i< tabuleiroTratado.Length - 1; i++)
            {

                CartasJogadas.Add(tabuleiroTratado[i].Substring(2, 1));

            }

            for (int i = 0; i < minhasCartas.Length; i++)
            {
                minhasCartasTratadas[i] = minhasCartas.Substring(i, 1);
            }

           for(int i = 0; i < minhasCartas.Length; i++)
            {
                if (!(CartasJogadas.Contains(minhasCartasTratadas[i])))
                {
                    Jogo.ColocarPersonagem(jogador, senha, i + 1, minhasCartasTratadas[i]);
                   

                }
            }



            //Jogo.ColocarPersonagem(jogador, senha, setor, personagem);
        }
    }

}
