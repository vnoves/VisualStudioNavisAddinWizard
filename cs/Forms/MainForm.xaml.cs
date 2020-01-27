using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;

namespace $safeprojectname$
{
    /// <summary>
    /// Interaction logic for MainForm.xaml
    /// </summary>
    public partial class MainForm : Window
    {

    private ExternalCommandData p_commanddata;

    public Document _doc;

    public UIApplication uiApp;



        /// <summary>
        /// Check if the suffix is a number or not
        /// </summary>
        /// <param name="cmddata_p"></param>
        public MainForm(ExternalCommandData cmddata_p)
        {
            this.DataContext = this;
            this.p_commanddata = cmddata_p;
            InitializeComponent();
        }

        public string projectName = App.NameSpaceNm;
        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }

        public string projectVersion = CommonAssemblyInfo.Number;
        public string ProjectVersion
        {
        get { return projectVersion; }
        set { projectVersion = value; }
        }

    private void Border_MouseDown(object sender, MouseButtonEventArgs e)

    {

        this.DragMove();

    }

    /// <summary>
    /// Button close form when clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Close_Click(object sender, RoutedEventArgs e)
        {
        this.Close();
        }


    private void Title_Link(object sender, RoutedEventArgs e)
    {
        System.Diagnostics.Process.Start("https://google.com");
    }
}
}
