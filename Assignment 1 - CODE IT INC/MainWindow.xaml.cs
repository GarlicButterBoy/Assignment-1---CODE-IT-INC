using Assignment_1___CODE_IT_INC;
using System;
using System.Collections;
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
        //dynamic temp = new ArrayList();
      //  Project[] tempProject = new Project[] { };
        //I should probably create an array of project classes to keep track of the various data, then use for loops when clicking on the listbox?
        //something like that. I'm close!

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateProject_Click(object sender, RoutedEventArgs e)
        {
           // int count = 0;
            Project project = new Project();
            project.ProjectName = txtProjectName.Text;
            project.ProjectBudget = double.Parse(txtBudget.Text);
            project.ProjectAmountSpent = double.Parse(txtSpent.Text);
            project.ProjectHoursRemaining = int.Parse(txtHoursLeft.Text);
            project.ProjectStatus = cbStatusList.Text;
            lbProjectList.Items.Add(project);
           // tempProject[count] = project;
           // count++;
           //lbProjectList.Add = project;
        }



        private void listBoxClick(object sender, EventArgs e)
        {
            Project project = (Project)lbProjectList.SelectedItem;

            ProjectInfo newWindow = new ProjectInfo();
            newWindow.Show();
            newWindow.txtProjectNameDisplay.Text = project.ProjectName;
            newWindow.txtBudgetDisplay.Text = Convert.ToString(project.ProjectBudget);
            newWindow.txtTimeRemainingDisplay.Text = Convert.ToString(project.ProjectHoursRemaining);
            newWindow.txtSpentDisplay.Text = Convert.ToString(project.ProjectAmountSpent);
            newWindow.cbStatusDisplay.Text = project.ProjectStatus;
        }
    }
}
