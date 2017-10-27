namespace EFCodeFirst.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using Helpers;

    public class StoreLocation : BaseEntity
    {

        private string locationName;
        private ExceptionMessage ex;

        private StoreLocation()
        {
            this.ex = new ExceptionMessage();
            this.Sales = new HashSet<Sale>();
        }

        public StoreLocation(string locationName)
            : this()
        {
            this.LocationName = locationName;
        }

        [Required]
        [StringLength(LOCATION_NAME_MAX_LENGTH)]
        [Display(Name = "Location Name")]
        public string LocationName
        {
            get
            {
                return this.locationName;
            }

            set
            {
                this.ex.StringExistenceValidation(value, nameof(StoreLocation), nameof(this.LocationName));
                this.ex.StringMaxLengthValidation(value, LOCATION_NAME_MAX_LENGTH, nameof(this.LocationName));
                this.locationName = value;
            }
        }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
