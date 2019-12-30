using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using System.IO;

namespace WpfApp1
{

    
    /// <summary>
    /// WpfTreeView.xaml 的交互逻辑
    /// </summary>
    public partial class WpfTreeView : Window
    {
        #region constructor
        public WpfTreeView()
        {
            InitializeComponent();
        }


        #endregion
        #region on load
        /// <summary>
        /// when the application first opens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //get every logical drive on the machine
            foreach (var drive in Directory.GetLogicalDrives())
            {
                //create a new item fot it 
                var item = new TreeViewItem() {
                    //set the header and path 
                   Header = drive,
                //and a full path 
                Tag = drive
            };
                


                //add a domain item
                item.Items.Add(null);

                //listen out for item being expanded
                item.Expanded += Folder_Expanded;
                //add it to the main  treeview 
                FolderView.Items.Add(item);
            }

        }
        #endregion
        private void Folder_Expanded(object sender, RoutedEventArgs e )
        {
            var item = (TreeViewItem)sender;
            if (item.Items.Count != 1 || item.Items[0] != null)
            {
                return;

            }
            item.Items.Clear();
            var fullPath = (string)item.Tag;
            //create a blank list for directories 
            var diretories = new List<string>();
            //try and get directories from the floder ,ignore any issues doing so 
            try
            {
                var dirs = Directory.GetDirectories(fullPath);
                if(dirs.Length>0)
                {
                    diretories.AddRange(dirs);
                }
            }
            catch (Exception)
            {

                throw;
            }
            diretories.ForEach(directoryPath => {
                var subItem = new TreeViewItem()
                {
                    //set header as Folder name
                    //Header = Path.GetDirectoryName(directoryPath),
                    Header = GetFileFolderName(directoryPath),
                    //and tag a full path 
                    Tag = directoryPath
                };
                //AddChild dummy item so we can expand folder 
                subItem.Items.Add(null);
                subItem.Expanded += Folder_Expanded;

                item.Items.Add(subItem);
            });
        }
        public static string GetFileFolderName(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return string.Empty;
            }

            var normalizedPath = path.Replace('/','\\');
            var lastIndex = normalizedPath.LastIndexOf('\\');
            if (lastIndex <=0)
            {
                return path;
            }
            return path.Substring(lastIndex+1);

        }
    }
}
