using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreinoCadastroPrédio.ViewlModels
{
    public class FuncaoUsuarioViewModel
    {
        public string FuncaoId { get; set; }
        public string Nome { get; set; }
        public string descricao { get; set; }
        public bool isSelecionado { get; set; }
    }
}
