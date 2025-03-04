using System;
using uni.learn.core.Entities;

namespace uni.learn.core.Specifications;

public class CursoSpecifications : BaseSpecifications<Curso>
{
    public CursoSpecifications(CursoSpecificationParams cursoParams) : base(
        x => (string.IsNullOrEmpty(cursoParams.Search) ||
            x.Titulo.ToLower().Contains(cursoParams.Search.ToLower()) ||
            x.Descripcion.ToLower().Contains(cursoParams.Search.ToLower())) &&
            (string.IsNullOrEmpty(cursoParams.Categoria) ||
            x.Categorias.Any(c => c.Nombre.ToLower().Contains(cursoParams.Categoria.ToLower())))

    )
    {
        AddIncludes(x => x.Categorias);
        AddOrderBy(x => x.Vistas);
    }

}
