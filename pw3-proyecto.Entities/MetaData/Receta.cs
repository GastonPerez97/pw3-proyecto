﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace pw3_proyecto.Entities
{
    [ModelMetadataType(typeof(RecetaModelMetaData))]
    public partial class Receta { }

    public class RecetaModelMetaData
    {
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
        public string Nombre { get; set; }

        [DisplayName("Tiempo de cocción")]
        [Required(ErrorMessage = "El campo Tiempo de cocción es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El valor debe ser mayor o igual a 1.")]
        public int TiempoCoccion { get; set; }

        [DisplayName("Descripción")]
        [Required(ErrorMessage = "El campo Descripcion es obligatorio.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo Ingredientes es obligatorio.")]
        public string Ingredientes { get; set; }

        [DisplayName("Tipo de receta")]
        [Required(ErrorMessage = "El campo Tipo de receta es obligatorio.")]
        public int IdTipoReceta { get; set; }
    }
}
