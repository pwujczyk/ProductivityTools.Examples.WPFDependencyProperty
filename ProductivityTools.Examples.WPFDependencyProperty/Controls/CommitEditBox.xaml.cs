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
            DependencyProperty.Register("BoxText", typeof(string), typeof(CommitEditBox), new PropertyMetadata(string.Empty,OnBoxTextChanged));

        private static void OnBoxTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CommitEditBox notesControl = d as CommitEditBox;
            notesControl.OnSetTextChanged(e);
        }

        private void OnSetTextChanged(DependencyPropertyChangedEventArgs e)
        {
            txt.Text = e.NewValue?.ToString();
        }



        public ICommand Click
        {
            get { return (ICommand)GetValue(ClickProperty); }
            set { SetValue(ClickProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Click.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClickProperty =
            DependencyProperty.Register("Click", typeof(ICommand), typeof(CommitEditBox));
    }
}
