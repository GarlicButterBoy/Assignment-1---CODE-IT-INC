using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1___CODE_IT_INC
{
   public class Project
    {
        //Data Members
        private string projectName;
        private double budget;
        private double amountSpent;
        private int hoursRemaining;
        private string projectStatus;

        //Constructor
        public Project()
        {
            projectName = "";
            budget = 0.00;
            amountSpent = 0.00;
            hoursRemaining = 0;
            projectStatus = "";
        }

        //Getters and Setters
        public string ProjectName
        {
            get { return this.projectName; }
            set { this.projectName = value; }
        }

        public double ProjectBudget
        {
            get { return this.budget; }
            set { this.budget = value; }
        }

        public double ProjectAmountSpent
        {
            get { return this.amountSpent; }
            set { this.amountSpent = value; }
        }

        public int ProjectHoursRemaining
        {
            get { return this.hoursRemaining; }
            set { this.hoursRemaining = value; }
        }

        public string ProjectStatus
        {
            get { return this.projectStatus; }
            set { this.projectStatus = value; }
        }

        public override string ToString()
        {
            return projectName;
        }
    }
}
