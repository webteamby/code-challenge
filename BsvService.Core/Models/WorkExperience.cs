using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BsvService.Core.Models
{
    public class WorkExperience
    {
        /// <summary>
        /// User's job title
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// User's company
        /// </summary>
        public string Company { get; set; }
        
        /// <summary>
        /// Year the user started company
        /// </summary>
        public int JobStartYear { get; set; }
        
        /// <summary>
        /// Year the user ended company
        /// </summary>
        public int JobEndYear { get; set; }
    }
}
