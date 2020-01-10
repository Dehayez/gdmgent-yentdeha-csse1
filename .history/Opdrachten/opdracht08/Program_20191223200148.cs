using System;
using System.Collections.Generic;

namespace Opdracht08
{
		// The different parts of the Product objects
    public interface IBuilder
    {
        void Weer();

				void Economie();

				void Gids();
        
        void Binnenlands();
        
        void Buitenlands();
    }
    

		// Different variatians of Builders
		// It provides specific implementations of the building steps
    public class BuildMetro : IBuilder
    {
        private Product _product = new Product();
        
        public BuildMetro()
        {
            this.Reset();
        }
        
        public void Reset()
        {
            this._product = new Product();
        }
        
        // All production steps work with the same product instance.
        public void Weer()
        {
            this._product.Add("Weer");
        }

				public void Economie()
        {
            this._product.Add("Economie");
        }

				public void Gids()
        {
            this._product.Add("Gids");
        }
        
        public void Binnenlands()
        {
            this._product.Add("Binnenlands");
        }
        
        public void Buitenlands()
        {
            this._product.Add("Buitenlands");
        }
        
        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }

		public class BuildMetro : IBuilder
    {
        private Product _product = new Product();
        
        public BuildMetro()
        {
            this.Reset();
        }
        
        public void Reset()
        {
            this._product = new Product();
        }
        
        // All production steps work with the same product instance.
        public void Weer()
        {
            this._product.Add("Weer");
        }

				public void Economie()
        {
            this._product.Add("Economie");
        }

				public void Gids()
        {
            this._product.Add("Gids");
        }
        
        public void Binnenlands()
        {
            this._product.Add("Binnenlands");
        }
        
        public void Buitenlands()
        {
            this._product.Add("Buitenlands");
        }
        
        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
    
    // It makes sense to use the Builder pattern only when your products are
    // quite complex and require extensive configuration.
    //
    // Unlike in other creational patterns, different concrete builders can
    // produce unrelated products. In other words, results of various builders
    // may not always follow the same interface.
    public class Product
    {
        private List<object> _parts = new List<object>();
        
        public void Add(string part)
        {
            this._parts.Add(part);
        }
        
        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
        }
    }
    
    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. Strictly speaking, the Director class is
    // optional, since the client can control builders directly.
    public class Director
    {
        private IBuilder _builder;
        
        public IBuilder Builder
        {
            set { _builder = value; } 
        }
        
        // The Director can construct several product variations using the same
        // building steps.
        public void buildMinimalViableProduct()
        {
            this._builder.Weer();
        }
        
        public void buildFullFeaturedProduct()
        {
            this._builder.Weer();
            this._builder.Binnenlands();
            this._builder.Buitenlands();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The client code creates a builder object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the builder object.
            var director = new Director();
            var builder = new BuildMetro();
            director.Builder = builder;
            
            Console.WriteLine("Standard basic product:");
            director.buildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.buildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Custom product:");
            builder.Weer();
            builder.Buitenlands();
            Console.Write(builder.GetProduct().ListParts());
        }
    }
}