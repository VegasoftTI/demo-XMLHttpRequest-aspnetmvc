using System;
using System.Collections.Generic;

namespace DemoXMLHttpRequest.Models
{
    public class Cliente
    {
        public Cliente(string nome)
        {
            this.ID = Guid.NewGuid().ToString();
            this.Nome = nome;
        }
        public string ID { get; private set; }
        public string Nome { get; private set; }
    }

    public class Clientes
    {
        public static IList<Cliente> ListaDeClientes
        {
            get
            {
                return new List<Cliente> { 
                new Cliente("Fabiano"),
                new Cliente("Priscila"),
                new Cliente("Raphael"),
                new Cliente("Adriano"),
                new Cliente("Daniel"),
                new Cliente("Fernanda"),
                new Cliente("Rebeca"),
                new Cliente("Murilo"),
                new Cliente("Vinícius"),
                new Cliente("Isabel")
            };
            }
        }
    }
}