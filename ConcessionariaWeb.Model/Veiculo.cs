﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConcessionariaWeb.Model
{
    public partial class Veiculo
    {
        [Key]
        [Column("marca")]
        [StringLength(50)]
        [Unicode(false)]
        public string Marca { get; set; }
        [Required]
        [Column("modelo")]
        [StringLength(20)]
        [Unicode(false)]
        public string Modelo { get; set; }
        [Column("anoFabricacao")]
        public int? AnoFabricacao { get; set; }
        [Column("valor", TypeName = "money")]
        public decimal Valor { get; set; }
    }
}