using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WpfApp1.Directory.Data;
using System.Linq;
using System.Windows.Input;

namespace WpfApp1.Directory.ViewModels
{
    public class DirectoryItemViewModel : BaseViewModel
    {
        public DirectoryItemType Type { get; set; }
        public string FullPath { get; set; }
        public string Name { get { return this.Type == DirectoryItemType.Drive ? this.FullPath : DirectoryStructure.GetFileFolderName(this.FullPath); } }

        public ObservableCollection<DirectoryItemViewModel> Children { get; set; }
        public bool CanExpand { get { return this.Type != DirectoryItemType.File; } }
        public bool IsExpanded
        {
            get 
            {
                return this.Children?.Count(f => f != null)>0;
            }
            set
            {
                if (value == true)
                {
                    Expand();
                }
                else
	            {
                    this.ClearChildren();
                }
            }
        }
        private void ClearChildren()
        {
            this.Children = new ObservableCollection<DirectoryItemViewModel>();
            if (this.Type != DirectoryItemType.File)
            {
                this.Children.Add(null);
            }
        }
        //the command to expand this item
        public ICommand ExpandCommand { get; set; }
        public DirectoryItemViewModel(string fullPath, DirectoryItemType type)
        {

            this.ExpandCommand = new RelayCommand(Expand);
            this.FullPath = fullPath;
            this.Type = type;
            this.ClearChildren();
        }
       
        private void Expand()
        {
            if (this.Type == DirectoryItemType.File)
            {
                return;
            }
            //find all children
            var children = DirectoryStructure.GetDirectoryContents(this.FullPath);
            this.Children = new ObservableCollection<DirectoryItemViewModel>(children.Select
                (content =>new DirectoryItemViewModel(content.FullPath,content.Type)));
        }

    }
}
