﻿using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            { new Proyecto
                {
                    Titulo = "Amazon",
                    Descripcion = "E-Comerce realizado en ASP.NET Core",
                    Link = "https://amazon.com",
                    ImagenURL = "/imagenes/amazon.png"
                },
                new Proyecto
                {
                    Titulo = "New York Time",
                    Descripcion = "Pàgina de noticias en React",
                    Link = "https://nytimes.com",
                    ImagenURL = "/imagenes/nyt.png"
                },
                new Proyecto
                {
                    Titulo = "Reddit",
                    Descripcion = "Red social para compartir en comunidades",
                    Link = "https://reddit.com",
                    ImagenURL = "/imagenes/reddit.png"
                },
                new Proyecto
                {
                    Titulo = "Steam",
                    Descripcion = "E-Comerce realizado en ASP.NET Core",
                    Link = "https://store.steampowered.com",
                    ImagenURL = "/imagenes/steam.png"
                },
            };
        }
    }
}
