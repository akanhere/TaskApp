using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TaskApp.Models;
using TaskApp.Services;
using Xamarin.Forms;

namespace TaskApp.ViewModels
{
    public class TaskListViewModel : BindableObject
    {
        private ObservableCollection<Task> _tasks;

        public TaskListViewModel()
        {
            LoadData();
        }

        public ObservableCollection<Task> Tasks
        {
            get { return _tasks; }
            set
            {
                _tasks = value;
                OnPropertyChanged("Tasks");
            }
        }

        private void LoadData()
        {
            Tasks = new ObservableCollection<Task>(TaskService.Instance.GetTasks());
        }
    }
}
