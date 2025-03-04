using System;
using Microsoft.AspNetCore.Identity;

namespace uni.learn.core.Entities;

public class User : IdentityUser
{
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public int Matricula {get; set;}
    public bool Admin {get; set;}
    public bool Profesor {get; set;}
    public string? Foto {get; set;}

}
