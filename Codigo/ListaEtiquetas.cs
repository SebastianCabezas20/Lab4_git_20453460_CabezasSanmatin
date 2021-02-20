﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Codigo
{
    public class ListaEtiquetas
    {
        List<Etiqueta> listaEtiquetas; //ArrayList que contendra las Etiquetas
        /*crea la lista de etiquetas*/
        public ListaEtiquetas()
        {
            this.listaEtiquetas = new List<Etiqueta>();
        }
        /*
        agrega una etiqueta al stack
        @param etiqueta, corresponde a una clase etiqueta*/
        public void agregarEtiqueta(Etiqueta etiqueta)
        {
            this.listaEtiquetas.Add(etiqueta);
        }


        /*
        Permite verificar si existe nombre en la lista de etiquetas
        @param nombreEtiqueta, corresponde a nombre de etiqueta a buscar
        @return boolean que indica si se verifica o no*/
        public bool verificarNombre(String nombreEtiqueta)
        {
            for (int i = 0; i < this.listaEtiquetas.Count; i++)
            {
                if (this.listaEtiquetas[i].getEtiqueta().Equals(nombreEtiqueta))
                { //Si existe el nombre en la lista de etiquetas
                    return true;
                }
            }
            return false;
        }
        /*
        Permite buscar una etiqueta mediante su nombre
        @param nombreEtiqueta, corresponde al nombre de la etiqueta
        @return Etiqueta, corresponde a la etiqueta buscada*/
        public Etiqueta buscador(String nombreEtiqueta)
        {
            for (int i = 0; i < listaEtiquetas.Count; i++)
            {
                if (this.listaEtiquetas[i].getEtiqueta().Equals(nombreEtiqueta))
                { //Si coincide el nombre de la etiqueta, se retorna
                    return this.listaEtiquetas[i];
                }
            }
            return null;
        }

        public int cantidadEtiquetas()
        {
            return this.listaEtiquetas.Count;
        }

        public Etiqueta getEtiqueta(int index)
        {
            return this.listaEtiquetas[index];
        }
    }
}
