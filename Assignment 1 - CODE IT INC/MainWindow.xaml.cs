using Assignment_1___CODE_IT_INC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        //Declare a public observable collection
        public ObservableCollection<Project> projects = new ObservableCollection<Project>();

        public MainWindow()
        {
            InitializeComponent();

            //Add a default to the list
            projects.Add(new Project() { ProjectName = "Durham Website", ProjectBudget = 15400.99, ProjectAmountSpent = 5023.67, ProjectHoursRemaining = 234, ProjectStatus = "Testing" });

            //data bind
            lbProjectList.ItemsSource = projects;
        }

        private void btnCreateProject_Click(object sender, RoutedEventArgs e)
        {
            //Creates the project, assigns the values, and stores it in the listbox
            projects.Add(new Project() { ProjectName = txtProjectName.Text, ProjectBudget = double.Parse(txtBudget.Text),
            ProjectAmountSpent = double.Parse(txtSpent.Text), ProjectHoursRemaining = int.Parse(txtHoursLeft.Text), ProjectStatus = cbStatusList.Text }) ;

            /* Project project = new Project();
            project.ProjectName = txtProjectName.Text;
            project.ProjectBudget = double.Parse(txtBudget.Text);
            project.ProjectAmountSpent = double.Parse(txtSpent.Text);
            project.ProjectHoursRemaining = int.Parse(txtHoursLeft.Text);
            project.ProjectStatus = cbStatusList.Text;
            lbProjectList.Items.Add(project);
           */

            //Clears the text
            ClearText();
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

        //Text Clear Function
        private void ClearText()
        {
            txtProjectName.Text = string.Empty;
            txtBudget.Text = "0.00";
            txtHoursLeft.Text = "0";
            txtSpent.Text = "0.00";
            cbStatusList.Text = string.Empty;

        }
    }
}
