using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases_Rutas_con_listas_circulares
{
    class Base
    {
        String _nombre;
        int _minutos;

        public Base siguiente;

        public String nombre { get { return _nombre; } }
        public int minutos { get { return _minutos; } }

        public Base(String nombre, int minutos)
        {
            _nombre = nombre;
            _minutos = minutos;
        }

		public override string ToString()
		{
			return "Nombre: " + nombre + Environment.NewLine + "Minutos: " + minutos;
		}
	}
}
