using ExampleCourseWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExampleCourseWork.Forms
{
    public partial class EditBookForm : Form
    {
        private Book book;
        private bool isEditMode;
        private Library library;
        private bool isNewBook;
         List<string> collections;
        private bool isLibrarian;
        
        public EditBookForm(Book book, bool isEditMode, Library library, bool isNewBook = false, bool isLibrarian = false)
        {
            InitializeComponent();
            this.book = book;
            this.isEditMode = isEditMode;
            this.library = library;
            this.isNewBook = isNewBook;
            this.collections = library.Collections;
            this.isLibrarian = isLibrarian;
            InitializeCollectionComboBox();
            LoadBookData();
            UserRole();

        }

        private void InitializeCollectionComboBox()
        {
           // CollectionComboBox.Items.AddRange(new[] { "Read", "Will read", "Love" });
            CollectionComboBox.Items.Clear();
            CollectionComboBox.Items.AddRange(library.Collections.ToArray());
            CollectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;


            if (!string.IsNullOrEmpty(book.Collection))
            {
                CollectionComboBox.SelectedItem = book.Collection;
            }
            CollectionComboBox.Enabled = !isLibrarian;
        }

        private void UserRole()
        {
            DeleteButton.Visible = isLibrarian;
            CollectionComboBox.Enabled = !isLibrarian;
            
        }
   


        private void LoadBookData()
        {
            IdtextBox.Text = book.Id.ToString();
            TitleTextBox.Text = book.Title;
            AuthortextBox.Text = book.Author;
            YeartextBox.Text = book.Year.ToString();
            GenretextBox.Text = book.Genre;
            LanguagetextBox.Text = book.Language;
            AnnotationtextBox.Text = book.Annotation;

            // У режимі перегляду зробити поля недоступними для редагування
            if (!isEditMode)
            {
                CollectionComboBox.Enabled = false;
                IdtextBox.ReadOnly = true;
                TitleTextBox.ReadOnly = true;
                AuthortextBox.ReadOnly = true;
                YeartextBox.ReadOnly = true;
                GenretextBox.ReadOnly = true;
                LanguagetextBox.ReadOnly = true;
                AnnotationtextBox.ReadOnly = true;
                //DeleteButton.Visible = false;
                
            }
            if (isNewBook)
            {
                CollectionComboBox.Enabled = true;
            }
            DeleteButton.Visible = isLibrarian;
            RemoveBookFromCollectionButton.Visible = !isLibrarian;


            //else
            //{
            //    DeleteButton.Visible = true;              
            //}
            //if(!isNewBook){ 
            //    book.LoadBookData(IdtextBox, TitleTextBox, AuthortextBox, YeartextBox, GenretextBox, LanguagetextBox, AnnotationtextBox);
            //}
            //if (!isEditMode)
            //{
            //    IdtextBox.ReadOnly = true;
            //    TitleTextBox.ReadOnly = true;
            //    AuthortextBox.ReadOnly = true;
            //    YeartextBox.ReadOnly = true;
            //    GenretextBox.ReadOnly = true;
            //    LanguagetextBox.ReadOnly = true;
            //    AnnotationtextBox.ReadOnly = true;

            //    OkButton.Visible = false;
            //    DeleteButton.Visible = false;
            //    CancelButton.Text = "Закрити";

            //}
            //else
            //{
            //    IdtextBox.ReadOnly = true;
            //    DeleteButton.Visible = !isNewBook;

            //}
        }

        

        private void OkButton_Click(object sender, EventArgs e)
        {
            //if (isEditMode || isNewBook)
            //{
            //    book.Title = TitleTextBox.Text;
            //    book.Author = AuthortextBox.Text;
            //    book.Year = Convert.ToInt32(YeartextBox.Text);
            //    book.Genre = GenretextBox.Text;
            //    book.Language = LanguagetextBox.Text;
            //    book.Annotation = AnnotationtextBox.Text;
            //    book.Collection = CollectionComboBox.SelectedItem?.ToString();

            //    if (isNewBook)
            //    {
            //        library.Books.Add(book);
            //    }
            //    this.DialogResult = DialogResult.OK;
            //}
            //this.Close();
            if (ValidateBookData())
            {
                book.Id = int.Parse(IdtextBox.Text);
                book.Title = TitleTextBox.Text;
                book.Author = AuthortextBox.Text;
                book.Year = int.Parse(YeartextBox.Text);
                book.Genre = GenretextBox.Text;
                book.Language = LanguagetextBox.Text;
                book.Annotation = AnnotationtextBox.Text;
                book.Collection = CollectionComboBox.SelectedItem?.ToString(); // Зберегти вибрану колекцію

                if (isNewBook)
                {
                    library.Books.Add(book);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {///////
            
            /////
            ///
            var result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                library.Books.Remove(book);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidateBookData()
        {
            // Додайте перевірку даних книги перед збереженням
            if (string.IsNullOrEmpty(TitleTextBox.Text) || string.IsNullOrEmpty(AuthortextBox.Text) || string.IsNullOrEmpty(GenretextBox.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі обов'язкові поля.");
                return false;
            }

            return true;
        }

        public void UpdateCollectionComboBoxes(List<string> collections)
        {
            CollectionComboBox.Items.Clear();
            CollectionComboBox.Items.AddRange(collections.ToArray());
            if(!string.IsNullOrEmpty(book.Collection))
            {
                CollectionComboBox.SelectedItem = book.Collection;
            }
        }

        private void RemoveBookFromCollectionButton_Click(object sender, EventArgs e)
        {
            Book selectedBook = book;

            if (selectedBook == null)
            {
                MessageBox.Show("Будь ласка, виберіть книгу, яку потрібно видалити з колекції.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Отримання назви колекції з ComboBox
            string collectionName = CollectionComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(collectionName))
            {
                MessageBox.Show("Будь ласка, виберіть колекцію.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Видалення книги з обраної колекції
            library.RemoveBookFromCollection(selectedBook, collectionName);

            // Оновлення списку книг у ResultList
            //  UpdateResultList(library.GetBooksByCollection(collectionName));
            UpdateCollectionComboBoxes(collections);
            // Повідомлення про успішне видалення книги з колекції
            MessageBox.Show($"Книгу '{selectedBook.Title}' видалено з колекції '{collectionName}'.", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
