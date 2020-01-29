using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductivityTools.Examples.WPFDependencyProperty.Controls
{
    /// <summary>
    /// Interaction logic for CommitEditBox.xaml
    /// </summary>
    public partial class CommitEditBox : UserControl
    {
        public CommitEditBox()
        {
            InitializeComponent();
        }

        public string BoxText
        {
            get { return (string)GetValue(BoxTextProperty); }
            set { SetValue(BoxTextProperty, value); }
        }

        public static readonly DependencyProperty BoxTextProperty =
            DependencyProperty.Register("BoxText", typeof(string), typeof(CommitEditBox));

        public ICommand Click
        {
            get { return (ICommand)GetValue(ClickProperty); }
            set { SetValue(ClickProperty, value); }
        }

        public static readonly DependencyProperty ClickProperty =
            DependencyProperty.Register("Click", typeof(ICommand), typeof(CommitEditBox));
    }
}
