using System;
using PneusCheiroso.Repositorio;
using PneusCheiroso.Dominio;
using System.Collections.Generic;
using System.Text;

namespace PneusCheiroso.Services
{
    public class Task
    {
        Conexao lista = new Conexao();
        Carro dadosCarro;
        Total informacoesTotal;

        public void totalPneus()
        {
            informacoesTotal = new Total();
            int y = 0;
            
       

            informacoesTotal.TotalPneus = y;
            lista.total.Add(informacoesTotal);
        } 

        public void PrecoTotal(int QuantidadePneu, double PrecoUnitario)
        {
            informacoesTotal = new Total();
            double p;

            p = (QuantidadePneu * PrecoUnitario);

            informacoesTotal.PrecoTotal = p;
            lista.total.Add(informacoesTotal);
        }
    }
}
