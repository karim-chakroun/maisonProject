using Examen.Data.Infrastructures;
using Examen.Domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen.Service
{
    public class MaisonService : Service<Maison>, IMaisonService
    {
        public MaisonService(IUnitOfWork utwk) : base(utwk)
        {

        }

    }
}
