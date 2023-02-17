using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace C_sharp_2_prakticheskaya
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      

        public MainWindow()
        {
            InitializeComponent();
            datepicker.SelectedDate = DateTime.Today;

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            /*Создать*/
            DateTime? date = datepicker.SelectedDate;
            string name = name_for_note.Text;
            string discript = discript_for_note.Text;  
            note.note_name.Add(name);
            note.note_discripton.Add(discript);
            note.note_date.Add(date);
            listbox.Items.Add(name);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void name_for_note_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            while (true)
            {
                if (datepicker.SelectedDate == note.note_date[listbox.SelectedIndex])
                {
                    name_for_note.Text = note.note_name[listbox.SelectedIndex];
                    discript_for_note.Text = note.note_discripton[listbox.SelectedIndex];

                }
                else
                {
                    name_for_note.Clear();
                    discript_for_note.Clear();
                }
                foreach (var item in listbox.Items)
                {

                }
            }
            
/*            name_for_note.Text = note.note_name[listbox.SelectedIndex];
            discript_for_note.Text = note.note_discripton[listbox.SelectedIndex];
            
            datepicker.SelectedDate = note.note_date[listbox.SelectedIndex];*/
            
        }

        private void datepicker_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
        
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
