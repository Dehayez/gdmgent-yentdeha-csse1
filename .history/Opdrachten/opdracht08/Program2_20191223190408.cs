using System;
using System.Collections.Generic;

namespace oefening1
{
    public interface IBuilder
    {
        void Krantenkop();
        
        void Binnenlands();
        
        void Buitenlands();
		void Economie();
		void Sport();
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
        public void Krantenkop()
        {
            this._product.Add("Krantenkop");
        }
        
        public void Binnenlands()
        {
            this._product.Add("Binnenlands");
        }
        
        public void Buitenlands()
        {
            this._product.Add("Buitenlands");
        }

		public void Economie()
        {
            this._product.Add("Economie");
        }

		public void Sport()
        {
            this._product.Add("Sport");
        }        

        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }

    public class BuildTijd : IBuilder
    {
        private Product _product = new Product();
        
        public BuildTijd()
        {
            this.Reset();
        }
        
        public void Reset()
        {
            this._product = new Product();
        }
        
        // All production steps work with the same product instance.
        public void Krantenkop()
        {
            this._product.Add("Krantenkop");
        }
        
        public void Binnenlands()
        {
            this._product.Add("Binnenlands");
        }
        
        public void Buitenlands()
        {
            this._product.Add("Buitenlands");
        }

		public void Economie()
        {
            this._product.Add("Economie");
        }

		public void Sport()
        {
            this._product.Add("Sport");
        }        

        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }

        public class BuildNieuwsblad : IBuilder
    {
        private Product _product = new Product();
        
        public BuildNieuwsblad()
        {
            this.Reset();
        }
        
        public void Reset()
        {
            this._product = new Product();
        }
        
        // All production steps work with the same product instance.
        public void Krantenkop()
        {
            this._product.Add("Krantenkop");
        }
        
        public void Binnenlands()
        {
            this._product.Add("Binnenlands");
        }
        
        public void Buitenlands()
        {
            this._product.Add("Buitenlands");
        }

		public void Economie()
        {
            this._product.Add("Economie");
        }

		public void Sport()
        {
            this._product.Add("Sport");
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

            str = str.Remove(str.Length - 2); 

            return "Krantendelen: " + str + "\n";
        }
    }
    
    public class Director
    {
        private IBuilder _builder;
        
        public IBuilder Builder
        {
            set { _builder = value; } 
        }
        
        public void BuildTijd()
        {
            this._builder.Krantenkop();
        }
        
        public void BuildHLN()
        {
            this._builder.Krantenkop();
            this._builder.Binnenlands();
            this._builder.Buitenlands();
			this._builder.Economie();
			this._builder.Sport();
        }

        public void BuildNieuwsblad()
        {
            this._builder.Krantenkop();
            this._builder.Binnenlands();
            this._builder.Buitenlands();
			this._builder.Sport();
        }
    }

		
}