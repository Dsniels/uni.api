using System;

namespace uni.learn.core.Entities;

public class Curso : Base
{
    public string Titulo { get; set; }
    public string AuthorId { get; set; }
    public User Author { get; set; }
    public List<Categoria> Categorias { get; set; }
    public string Video { get; set; }
    public string Portada { get; set; }
    public string Descripcion {get; set;}
    public int Vistas { get; set; }
    public bool Aprobado { get; set; }
}
