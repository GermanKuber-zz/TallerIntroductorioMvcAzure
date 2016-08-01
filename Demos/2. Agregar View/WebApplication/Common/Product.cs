using System.Collections.Generic;
using System.Linq;

namespace WebApplication.Common
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public bool Oferta { get; set; }
    }

    public static class ProductService
    {
        private static List<Product> _productos;

        private static void GenerarProductos()
        {
            if (_productos == null)
            {
                _productos = new List<Product> {
                    new Product {
                        Id = 0,
                        Nombre = "Notebook",
                        Precio = 10000,
                        Oferta = false
                    },
                     new Product {
                        Id = 0,
                        Nombre = "Monitor",
                        Precio = 3500,
                        Oferta = false
                    },
                      new Product {
                        Id = 0,
                        Nombre = "Teclado",
                        Precio = 250,
                        Oferta = true
                    },
                       new Product {
                        Id = 0,
                        Nombre = "Disco Rigido",
                        Precio = 2000,
                        Oferta = true
                    },
                        new Product {
                        Id = 0,
                        Nombre = "Tablet",
                        Precio = 2200,
                        Oferta = false
                    }
                };
            }
        }

        public static List<Product> GetAll()
        {
            GenerarProductos();
            return _productos;
        }
        public static Product GetById(int id)
        {
            GenerarProductos();
            return _productos.FirstOrDefault(x => x.Id == id);
        }
        public static void Add(string nombre, decimal precio, bool oferta)
        {
            GenerarProductos();
            var lastId = _productos.Max(x => x.Id);
            var newProduct = new Product
            {
                Id = ++lastId,
                Nombre = nombre,
                Precio = precio,
                Oferta = oferta
            };
        }

    }
}
