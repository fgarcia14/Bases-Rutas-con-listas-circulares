using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases_Rutas_con_listas_circulares
{
    class Ruta
    {
        Base inicio;
        Base temp;

        public Ruta()
        {
            inicio = null;
        }

        public Base buscar(String nombre)
        {
            Base retorno = null;
            temp = inicio;
            do
            {
                if (temp.nombre==nombre)
                {
                    retorno = temp;
                }
                temp = temp.siguiente;
            } while (temp!=inicio);
            return retorno;
        }

        public void agregar(Base nuevo)
        {
            if (inicio==null)
            {
                inicio = nuevo;
                inicio.siguiente = inicio;
			}
			else if (buscar(nuevo.nombre)==null)
			{
				inicio = temp;
				while (temp.siguiente!=inicio)
				{
					temp = temp.siguiente;
				}
				nuevo.siguiente = inicio;
				temp.siguiente = nuevo;
			}
        }

		public void eliminar(String nombre)
		{
			if (inicio.siguiente==inicio && inicio.nombre==nombre)
			{
				inicio = null;
			}
			else if (inicio.nombre==nombre)
			{
				while (temp.siguiente!=inicio)
				{
					temp = temp.siguiente;
				}
				temp.siguiente = inicio.siguiente;
				inicio = inicio.siguiente;
			}
			else
			{
				temp = inicio;
				do
				{
					if (temp.siguiente.nombre == nombre)
					{
						temp.siguiente = temp.siguiente.siguiente;
					}
					temp = temp.siguiente;
				} while (temp!=inicio);
			}
		}

		public void eliminarInicio()
		{
			if (inicio.siguiente==inicio)
			{
				inicio = null;
			}else
			{
				temp = inicio;
				while (temp.siguiente != inicio)
				{
					temp = temp.siguiente;
				}
				temp.siguiente = inicio.siguiente;
				inicio = inicio.siguiente;
			}
		}

		public void eliminarUltimo()
		{
			if (inicio.siguiente==inicio)
			{
				inicio = null;
			}
			else
			{
				temp = inicio;
				while (temp.siguiente.siguiente!=inicio)
				{
					temp=temp.siguiente;
				}
				temp.siguiente = inicio;
			}
		}

		public void insertarDespuesDe(String nombre, Base base1)
		{
			temp = inicio;
			do
			{
				if (temp.nombre==nombre)
				{
					base1.siguiente = temp.siguiente;
					temp.siguiente = base1;
				}
				temp = temp.siguiente;
			} while (temp!=inicio);
		}

		public String reporte()
		{
			String datos = "";
			temp = inicio;
			do
			{
				if (temp!=null)
				{
					datos += temp.ToString() + Environment.NewLine;
					temp = temp.siguiente;
				}
			} while (temp!=inicio);
			return datos;
		}


    }
}
