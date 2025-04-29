﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_filmes_senai.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage ="O nome é obrigatório!")]
        public string? Nome { get; set; }

        [Column(TypeName ="VARCHAR(50)")]
        [Required(ErrorMessage ="O email é obrigatório!")]
        public string? Email { get; set; }

        [Column(TypeName ="VARCHAR(60)")]
        [Required(ErrorMessage ="A senha é obrigatória!")]
        [StringLength(60,MinimumLength = 6, ErrorMessage ="A senha deve conter no mínimo 6 caracteres e no máximo 60" )]
        public string? Senha { get; set; }
    }
}


    