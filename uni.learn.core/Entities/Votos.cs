using System;

namespace uni.learn.core.Entities;

public class Votos : Base
{
    public int CursoId {get; set;}
    public string UserId { get; set;}
    public bool Like {get; set;} 
}

