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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateProject_Click(object sender, RoutedEventArgs e)
        {
           //Creates the project, assigns the values, and stores it in the listbox
            Project project = new Project();
            project.ProjectName = txtProjectName.Text;
            project.ProjectBudget = double.Parse(txtBudget.Text);
            project.ProjectAmountSpent = double.Parse(txtSpent.Text);
            project.ProjectHoursRemaining = int.Parse(txtHoursLeft.Text);
            project.ProjectStatus = cbStatusList.Text;
            lbProjectList.Items.Add(project);

        }



        private void listBoxClick(object sender, EventArgs e)
        {

            //Gets the selected item from the listbox
            Project project = (Project)lbProjectList.SelectedItem;

            //creates the new window
            ProjectInfo newWindow = new ProjectInfo();
            newWindow.Show();

            //displays the information stored in the listbox index selected
            newWindow.txtProjectNameDisplay.Text = project.ProjectName;
            newWindow.txtBudgetDisplay.Text = Convert.ToString(project.ProjectBudget);
            newWindow.txtTimeRemainingDisplay.Text = Convert.ToString(project.ProjectHoursRemaining);
            newWindow.txtSpentDisplay.Text = Convert.ToString(project.ProjectAmountSpent);
            newWindow.cbStatusDisplay.Text = project.ProjectStatus;
        }
    }
}
