using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleCourseWork.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public string Annotation { get; set; }
        public string Collection { get; set; }

        public void LoadBookData(TextBox idTextBox, TextBox titleTextBox, TextBox authorTextBox, TextBox yearTextBox, TextBox genreTextBox, TextBox languageTextBox, TextBox annotationTextBox)
        {
            idTextBox.Text = Id.ToString();
            titleTextBox.Text = Title;
            authorTextBox.Text = Author;
            yearTextBox.Text = Year.ToString();
            genreTextBox.Text = Genre;
            languageTextBox.Text = Language;
            annotationTextBox.Text = Annotation;
        }

        public string DisplayInfo
        {
            get { return $"{Title} автора {Author}"; }
        }
    }
}
