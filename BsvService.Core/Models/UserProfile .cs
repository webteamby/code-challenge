using System.Collections.Generic;

namespace BsvService.Core.Models
{
    public class UserProfile: BaseModel
    {
        /// <summary>
        /// User's email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// User's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// User's last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// User's Bio
        /// </summary>
        public string Bio { get; set; }
        /// <summary>
        /// User's photo url
        /// </summary>
        public string PhotoUrl { get; set; }

        /// <summary>
        /// User's phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// User's region area
        /// </summary>
        public string Region { get; set; }
        
        /// <summary>
        /// User's industry
        /// </summary>
        public string Industry { get; set; }

        /// <summary>
        /// User's Education
        /// </summary>
        public List<Education> Educations { get; set; }
        /// <summary>
        /// User's WorkExperience
        /// </summary>
        public List<WorkExperience> WorkExperiences { get; set; }

        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Blog { get; set; }
    }
}
