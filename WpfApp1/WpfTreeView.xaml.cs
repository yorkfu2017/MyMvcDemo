using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfApp1.Directory;
using System.IO;
using WpfApp1.Directory.Data;
using WpfApp1.Directory;
using WpfApp1.Directory.ViewModels;

namespace WpfApp1
{

    
    /// <summary>
    /// WpfTreeView.xaml 的交互逻辑
    /// </summary>
    public partial class WpfTreeView : Window
    {

        public WpfTreeView()
        {
            InitializeComponent();
            //this.DataContext = new Class1();
            //var d = new DirectoryStructureViewModel();
            //var item1 = d.Items[0];
            //d.Items[0].ExpandCommand.Execute(null);
            this.DataContext = new DirectoryStructureViewModel(); 
        }



       
      
    }
}
