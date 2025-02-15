﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using pw3_proyecto.Common.CustomDataAnnotations;


#nullable disable

namespace pw3_proyecto.Entities
{
    [ModelMetadataType(typeof(EventoModelMetaData))]
    public partial class Evento { }

    public class EventoModelMetaData
    {
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Fecha es obligatorio.")]
        [CurrentDateOrHigher(ErrorMessage = "La fecha debe ser mayor a la actual.")]
        public DateTime Fecha { get; set; }

        [DisplayName("Cantidad de comensales")]
        [Required(ErrorMessage = "El campo Cantidad de comensales es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad de comensales tiene que ser mayor a 0.")]
        public int CantidadComensales { get; set; }

        [DisplayName("Ubicación")]
        [Required(ErrorMessage = "El campo Ubicación es obligatorio.")]
        public string Ubicacion { get; set; }

        [Required(ErrorMessage = "El campo Precio es obligatorio.")]
        [DataType(DataType.Currency)]
        [Range(1.00D, double.MaxValue, ErrorMessage = "Un evento no puede ser gratuito.")]
        public decimal Precio { get; set; }

        [DisplayName("Recetas para el evento")]
        [Required(ErrorMessage = "El campo Recetas es obligatorio, selecciona al menos una.")]
        public virtual ICollection<EventosReceta> EventosReceta { get; set; }
    }
}
