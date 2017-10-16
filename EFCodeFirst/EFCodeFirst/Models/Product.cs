
namespace EFCodeFirst.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using Helpers;
    public class Product
    {
        private const int NAME_MAX_LENGTH = 50;

        private string name;
        private double quantity;
        private decimal price;
        private string description;
        private ExceptionMessage ex;

        private Product()
        {
            this.ex = new ExceptionMessage();
        }

        public Product(string name, double quantity, decimal price)
            : this()
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(NAME_MAX_LENGTH)]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.ex.StringExistenceValidation(value, nameof(Product), nameof(this.Name));
                this.ex.StringMaxLengthValidation(value, NAME_MAX_LENGTH, nameof(this.Name));
                this.name = value;
            }
        }

        [Required]
        public double Quantity
        {
            get
            {
                return this.quantity;
            }

            set
            {
                this.ex.NummericNonNegativeValidation(value, nameof(this.Quantity));
                this.quantity = value;
            }
        }

        [Required]
        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.ex.NummericNonNegativeValidation(value, nameof(this.Price));
                this.price = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                if (value == null)
                {
                    this.description = "No description";
                }
                else
                {
                    this.description = value;
                }
            }
        }
    }
}
