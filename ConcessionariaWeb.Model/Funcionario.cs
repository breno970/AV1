﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConcessionariaWeb.Model
{
    public partial class Funcionario
    {
        public Funcionario()
        {

        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("nome")]
        [StringLength(40)]
        [Unicode(false)]
        public string Nome { get; set; }
        [Column("CPF")]
        public long Cpf { get; set; }
        [Column("email")]
        [StringLength(50)]
        [Unicode(false)]
        public string Email { get; set; }
    }
}