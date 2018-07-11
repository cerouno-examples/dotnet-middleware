using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeToTest.Code
{
    public class Booking
    {
        public User User { get; set; }

        public bool CanCancel(User user)
        {
            if (user.IsAdmin)
                return true;

            if (this.User == user)
                return true;

            return false;
        }
    }
}
