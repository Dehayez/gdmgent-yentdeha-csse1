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

		public class BuildHLN : IBuilder
    {
        private Product _product = new Product();
        
        public BuildHLN()
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

		// Director excecutes the building steps in particular sequence
    public class Director
    {
        private IBuilder _builder;
        
        public IBuilder Builder
        {
            set { _builder = value; } 
        }
        
        // The Director can construct several product variations using the same
        // building steps.
        public void buildMetro()
        {
            this._builder.Weer();
            this._builder.Binnenlands();
            this._builder.Buitenlands();
        }
        
        public void buildHLN()
        {
            this._builder.Weer();
						this._builder.Economie();
						this._builder.Gids();
            this._builder.Binnenlands();
            this._builder.Buitenlands();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
    
            var director = new Director();
						var directorTwo = new Director();

            var builder = new BuildMetro();
						var builderTwo = new BuildHLN();

            director.Builder = builder;
						directorTwo.Builder = 
            
            Console.WriteLine("De Metro:");
            director.buildMetro();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("HLN:");
            director.buildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());
        }
    }
}