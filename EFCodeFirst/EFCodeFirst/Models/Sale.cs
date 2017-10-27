
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Models
{
    using EFCodeFirst.Helpers;
    using System.ComponentModel.DataAnnotations;

    public class Sale
    {
        private int productId;
        private int customerId;
        private int storeLocationId;
        private ExceptionMessage ex;
        private Sale()
        {
            this.ex = new ExceptionMessage();
        }

        public Sale(int productId, int customerId, int storeLocationId, DateTime date)
            : this()
        {
            this.ProductId = productId;
            this.CustomerId = customerId;
            this.StoreLocationId = storeLocationId;
            this.Date = date;
        }

        public Sale(int productId, int customerId, int storeLocationId)
            : this(productId, customerId, storeLocationId, DateTime.Now)
        {
        }
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product Id")]
        public int ProductId
        {
            get
            {
                return this.productId;
            }

            set
            {
                this.ex.IdGreaterThanZeroValidation(value);
                this.productId = value;
            }
        }

        [Required]
        [Display(Name = "Customer Id")]
        public int CustomerId
        {
            get
            {
                return this.customerId;
            }

            set
            {
                this.ex.IdGreaterThanZeroValidation(value);
                this.customerId = value;
            }
        }

        [Required]
        [Display(Name = "Store Location Id")]
        public int StoreLocationId
        {
            get
            {
                return this.storeLocationId;
            }

            set
            {
                this.ex.IdGreaterThanZeroValidation(value);
                this.storeLocationId = value;
            }
        }

        [Required]
        public DateTime Date { get; set; }

        public virtual Product Product { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual StoreLocation StoreLocation { get; set; }
    }
}
