using System;
using System.Collections.Generic;
using System.Linq;
using TechJobs.Models;
using System.Threading.Tasks;

namespace TechJobs.ViewModels
{
    public class BaseViewModel
    {
        // All columns, for display
        public List<JobFieldType> Columns { get; set; }

        // View title
        public string Title { get; set; } = "";

        // The column selected, defaults to all
        public JobFieldType Column { get; set; } = JobFieldType.All;

        // Default constucter for subclasses : SearchJobsVM and JobFieldsVM
        public BaseViewModel()
        {
            // Populate the list of all columns

            Columns = new List<JobFieldType>();

            foreach (JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType)))
            {
                Columns.Add(enumVal);
            }

        }
    }
}