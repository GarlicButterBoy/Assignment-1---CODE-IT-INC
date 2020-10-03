using Assignment_1___CODE_IT_INC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BillingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Global Scope Object
        Project tempProject = new Project();
        //I should probably create an array of project classes to keep track of the various data, then use for loops when clicking on the listbox?
        //something like that. I'm close!

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateProject_Click(object sender, RoutedEventArgs e)
        {
            Project project = new Project();
            project.ProjectName = txtProjectName.Text;
            project.ProjectBudget = double.Parse(txtBudget.Text);
            project.ProjectAmountSpent = double.Parse(txtSpent.Text);
            project.ProjectHoursRemaining = int.Parse(txtHoursLeft.Text);
            project.ProjectStatus = cbStatusList.Text;
            lbProjectList.Items.Add(project.ProjectName);
            tempProject = project;
        }

        private void listBoxClick(object sender, EventArgs e)
        {
            ProjectInfo newWindow = new ProjectInfo();
            newWindow.Show();

            newWindow.txtProjectNameDisplay.Text = tempProject.ProjectName;
            newWindow.txtBudgetDisplay.Text = Convert.ToString(tempProject.ProjectBudget);
            newWindow.txtTimeRemainingDisplay.Text = Convert.ToString(tempProject.ProjectHoursRemaining);
            newWindow.txtSpentDisplay.Text = Convert.ToString(tempProject.ProjectAmountSpent);
            newWindow.cbStatusDisplay.Text = tempProject.ProjectStatus;
        }
    }
}
