using Examen.Data.Infrastructures;
using Examen.Domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen.Service
{
    public class TypeMaisonService : Service<TypeMaison>, ITypeService
    {
        public TypeMaisonService(IUnitOfWork utwk) : base(utwk)
        {

        }
    }
}
