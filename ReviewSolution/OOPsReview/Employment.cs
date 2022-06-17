using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview.Data
{
    public class Employment
    {
        
        private string _Title;
        private double _Years;

        public string Title
        {
            //a property is assoicated with a single piece of data
            get
            {            
                return _Title;
            }
            set
            {
                //ensure that the incoming data is not null or empty or just whitespace
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Title is a required piece of data.");
                }

                //data is consider valid
                _Title = value;
            }
        }

        //auto implemented property

        public SupervisoryLevel Level { get; set; }

        public double Years
        {
            get { return _Years; }
            set
            {
                if (!Utilities.IsZeroPositive(value))
                {
                    throw new ArgumentOutOfRangeException($"Years of {value} is invalid. Must be 0 or greater");
                }
                _Years = value;
            }
        }

        //constructor
        //Default constructor
        public Employment()
        {

            Level = SupervisoryLevel.TeamMember;
            Title = "Unknown";
        }

        //Greedy Constructor
        public Employment(string title, SupervisoryLevel level, double years = 0.0)
        {       
            Title = title;
            Level = level;
            Years = years; //eventually the data will be placed in _Years
        }

        //Behaviours (a.k.a. methods)

        public override string ToString()
        {
            //this string is known as a "comma separate values (csv)" string
            //this string uses the get; of the property
            return $"{Title},{Level},{Years}";
        }

        public void SetEmploymentResponsibilityLevel(SupervisoryLevel level)
        {
            //this method, in this example would not be necessary as the access directly
            //  the Level (property) is public ( set; )
            //HOWEVER: IF the Level property had a private set;, the outsider user would NOT
            //  have direct access to changing the property.
            //THERFORE: a method (besides the constructor) would need to be supplied to allow
            //  the outsider user the ability to alter the property value (if they so desired)

            //this assignment uses the set; of the property
            Level = level;

        }

    }
}
