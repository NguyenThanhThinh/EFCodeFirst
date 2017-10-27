using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        protected const int NAME_MAX_LENGTH = 50;
        protected const int EMAIL_MAX_LENGTH = 100;
        protected const int CREDIT_CART_NUMBER_EXACT_LENGTH = 16;
        protected const int ADDRESS_MAX_ALLOWED_LENGTH = 255;
        protected const int LOCATION_NAME_MAX_LENGTH = 255;

    }
}
