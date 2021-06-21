using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class Aluguel
    {
        public int AluguelId { get; set; }

        [Required(ErrorMessage = "Este campo {0} é obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage ="Valor invelido")]
        public decimal Valor { get; set; }

        public int MesId { get; set; }

        [Display(Name = "Mês")]
        public Mes Mes { get; set; }

        [Required(ErrorMessage = "Este campo {0} é obrigatório")]
        [Range(2021, 2030, ErrorMessage = "Ano invelido")]
        public int Ano { get; set; }

        public virtual ICollection<Pagamento> Pagamentos{ get; set; }
    }
}
