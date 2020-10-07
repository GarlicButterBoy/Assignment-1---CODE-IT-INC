using Assignment_1___CODE_IT_INC;
using System;
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
using System.Windows.Shapes;

namespace BillingApp
{
    /// <summary>
    /// Interaction logic for ProjectInfo.xaml
    /// </summary>
    public partial class ProjectInfo : Window
    {

        public ObservableCollection<Project> projects;
        public string projectName;
        public object sender;
        public ProjectInfo(ObservableCollection<Project> projects, string projectName, object sender)
        {
            this.projects = projects;
            this.projectName = projectName;
            this.sender = sender;
            InitializeComponent();

            txtProjectNameDisplay.Content = projectName;
        }
        //If the alter button is clicked
        private void btnAlter_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                for (int i = 0; i < projects.Count; i++)
                {
                    if (projects[i].ProjectName == projectName)
                    {
                        projects[i].ProjectBudget = double.Parse(txtBudgetDisplay.Text);
                        projects[i].ProjectAmountSpent = double.Parse(txtSpentDisplay.Text);
                        projects[i].ProjectHoursRemaining = int.Parse(txtTimeRemainingDisplay.Text);
                        projects[i].ProjectStatus = cbStatusDisplay.Text;
                        CollectionViewSource.GetDefaultView(projects).Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Exception Occured:\n" + ex.ToString());
            }
            finally
            {
                this.Close();
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
