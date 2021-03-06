﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using web.Models.Cliente;
using web.Models.Estabelecimento;

namespace web.Models.Pedido
{
    [Table("pedido")]
    public class pedido
    {
        [Key]
        public int pedidoID { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime dataPedido { get; set; }

        public float valorPedido { get; set; }

        public int quantidadeTotal { get; set; }

        public bool entrega { get; set; }

        public int clienteID { get; set; }

        public int estabelecimentoID { get; set; }

        public int pagamentoID { get; set; }

        [ForeignKey("clienteID")]
        public virtual cliente cliente { get; set; }

        [ForeignKey("estabelecimentoID")]
        public virtual estabelecimento estabelecimento { get; set; }

        [ForeignKey("pagamentoID")]
        public virtual pagamento pagamento { get; set; }
    }
}