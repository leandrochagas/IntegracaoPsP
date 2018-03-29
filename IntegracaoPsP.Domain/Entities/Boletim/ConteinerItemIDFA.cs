
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace IntegracaoPsP.Domain.Entities.Boletim
{
    public class ConteinerItemIDFA
    {
        [Required]
        [StringLength(3)]
        public string Identificador { get; set; }
        [Required]
        [StringLength(8)]
        public string CNPJBase { get; set; }
        [Required]
        [StringLength(4)]
        public string CNPJFilial { get; set; }
        [Required]
        [StringLength(2)]
        public string CNPJControle { get; set; }
        [Required]
        [StringLength(10)]
        public string NumeroViagem { get; set; }

        //[Required]
      //  [RequiredIf("FaltaOuAcrescimo", Comparison.IsEqualTo, "F")]
        [StringLength(30)]
        //  [ConditionalAttribute("Index", typeof(RemoteAttribute), Apply = false, ConstructorParam = new object[] { "NameExists", "Home" })]
        public string NumeroBoletim { get; set; }

       // [Required]
        [StringLength(5)]
        public string Portoemissao { get; set; }

        // [Required]
        [StringLength(4)]
        public string Emitente { get; set; }

        // [Required]
        [StringLength(8)]
        public string DataEmissao { get; set; }
        // [Required]
        [StringLength(5)]
        public string PortoDestinoFinal { get; set; }

        [Required]
        [StringLength(11)]
        public string IdConteiner { get; set; }

        [Required]
        [StringLength(1)]
        public string FaltaOuAcrescimo { get; set; }


        //Custom("Salário", "SalarioValido", "O Salário não atende os requisitos", ValidaSalario);

        //private bool ValidaSalario(object[] values)
        //{ //feito para operar com o Custom, pode mudar as regras fácil aqui de forma canônica
        //    return ((!Errors.ContainsKey("IdadeInconsistente") && Value.Idade > 21 && Value.Salario > 1000M)) ||
        //        (Value.Cargo != "Gerente" && Value.Salario > 900M) ||
        //        (Value.Cargo == "Gerente" && Value.Salario > 1200M);
        //}

        [Required]
        [StringLength(6)]
        public string Sequencial { get; set; }
    }
}
