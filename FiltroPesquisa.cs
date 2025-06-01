using System;
using System.Collections.Generic;
using System.Linq;

namespace PetManager
{
    public static class FiltroPesquisa
    {
        public static List<RegistroPet> Filtrar(
            List<RegistroPet> lista,
            string pesquisaNome,
            string statusFiltro, // "Todos", "Ativos", "Inativos"
            string tipoFiltro,   // "Todos", "Gato", "Cachorro", etc
            string porteFiltro)  // "Todos", "Pequeno", etc
        {
            DateTime hoje = DateTime.Today;

            IEnumerable<RegistroPet> query = lista;

            if (!string.IsNullOrWhiteSpace(pesquisaNome))
            {
                query = query.Where(r => r.Nome.IndexOf(pesquisaNome, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (statusFiltro == "Ativos")
                query = query.Where(r => !r.DataSaida.HasValue || r.DataSaida.Value > hoje);
            else if (statusFiltro == "Inativos")
                query = query.Where(r => r.DataSaida.HasValue && r.DataSaida.Value <= hoje);

            if (!string.IsNullOrWhiteSpace(tipoFiltro) && tipoFiltro != "Todos")
                query = query.Where(r => r.Tipo.Equals(tipoFiltro, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(porteFiltro) && porteFiltro != "Todos")
                query = query.Where(r => r.Porte.Equals(porteFiltro, StringComparison.OrdinalIgnoreCase));

            return query.ToList();
        }
    }
}