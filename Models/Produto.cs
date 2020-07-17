using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "o campo descrição é obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "o campo Quantidade é obrigatório")]
        [Range(1, 100, ErrorMessage ="Valor fora da faixa aceitavel")]
        public int Quantidade { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "o campo Preço é obrigatório")]
        public int Preco { get; set; }

        [Display(Name = "Categoria Id")]
        public int CategoriaId { get; set; }
        public  Categoria Categoria{ get; set; }
    }
}
