﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.AbstractFactory;
using TrabajoIntegrador.iterator;
using TrabajoIntegrador.TemplateMethod;

namespace TrabajoIntegrador.Proxy
{
    public class MedicoProxy :IResponsable
    {

          public MedicoProxy(IResponsable r) : base(r) { }

          public MedicoProxy() { }


          override public void atenderInfarto(IInfartable infartable)
          {
              Ambulancia a = new Ambulancia();
              Desfibrilador d = new Desfibrilador();

              a.encenderSirena();
              a.Conducir();
              d.usar();
              new RCP1().EfectuarRCP(infartable);
              d.guardar();

          }

          public void atenderDesmayo()
          {
              Console.WriteLine("El medico esta atendiendo el demayo del paciente");

          }






    }
}
