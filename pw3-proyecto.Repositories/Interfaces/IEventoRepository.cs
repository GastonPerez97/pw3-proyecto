﻿using pw3_proyecto.Entities;
using System.Collections.Generic;

namespace pw3_proyecto.Repositories.Interfaces
{
    public interface IEventoRepository
    {
        public void Save(Evento evento);
        public List<Evento> GetAllBy(int userId);
        public List<Evento> getAvailableEventsOf(int userId);
        public Evento FindById(int id);
        public Evento FindEventoReserva(int id);
        public List<Evento> GetAllEventosByUser(int idUser);
        public List<Evento> GetAllEventosByUserCalificacion(int idUser);
        public List<Evento> GetFinishedEvents();
        public void SaveChanges();
    }
}
