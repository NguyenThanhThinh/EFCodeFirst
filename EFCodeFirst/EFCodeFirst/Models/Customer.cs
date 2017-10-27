namespace EFCodeFirst.Models
{
    using EFCodeFirst.Helpers;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Customer:BaseEntity
    {
       
        private string firstName;
        private string lastName;
        private int? age;
        private string address;
        private string email;
        private string creditCardNumber;
        private ExceptionMessage ex;

        private Customer()
        {
            this.ex = new ExceptionMessage();
            this.Sales = new HashSet<Sale>();
        }
        public Customer(string name, string lastName, string email)
            : this()
        {
            this.FirstName = name;
            this.LastName = lastName;
            this.Email = email;
        }

        [Required]
        [StringLength(NAME_MAX_LENGTH)]
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.ex.StringExistenceValidation(value, nameof(Customer), nameof(this.FirstName));
                this.ex.StringMaxLengthValidation(value, NAME_MAX_LENGTH, nameof(this.FirstName));
                this.firstName = value;
            }
        }

        [Required]
        [StringLength(NAME_MAX_LENGTH)]
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.ex.StringExistenceValidation(value, nameof(Customer), nameof(this.LastName));
                this.ex.StringMaxLengthValidation(value, NAME_MAX_LENGTH, nameof(this.LastName));
                this.lastName = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.ex.NummericNonNegativeValidation(value, nameof(this.Age));
                this.age = value;
            }
        }

        [Required]
        [StringLength(EMAIL_MAX_LENGTH)]
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.ex.StringExistenceValidation(value, nameof(Customer), nameof(this.Email));
                this.ex.StringMaxLengthValidation(value, EMAIL_MAX_LENGTH, nameof(this.Email));
                this.email = value;
            }
        }

        [StringLength(ADDRESS_MAX_ALLOWED_LENGTH)]
        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                this.ex.StringMaxLengthValidation(value, ADDRESS_MAX_ALLOWED_LENGTH, nameof(this.Address));
                this.address = value;
            }
        }

        [MinLength(CREDIT_CART_NUMBER_EXACT_LENGTH)]
        [MaxLength(CREDIT_CART_NUMBER_EXACT_LENGTH)]
        [Display(Name = "Credit Card Number")]
        public string CreditCardNumber
        {
            get
            {
                return this.creditCardNumber;
            }

            set
            {
                this.ex.StringMaxLengthValidation(value, CREDIT_CART_NUMBER_EXACT_LENGTH, nameof(this.CreditCardNumber));
                this.ex.StringMinLengthValidation(value, CREDIT_CART_NUMBER_EXACT_LENGTH, nameof(this.CreditCardNumber));
                this.creditCardNumber = value;
            }
        }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
