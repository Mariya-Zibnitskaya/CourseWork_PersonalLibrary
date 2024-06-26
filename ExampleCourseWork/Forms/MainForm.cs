﻿using ExampleCourseWork.Models;
using ExampleCourseWork.Programs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleCourseWork.Forms
{
    public partial class MainForm : Form
    {
        private Library library;
        private List<Book> searchResults;
        private Librarian librarian;
        private bool isLibrarian;

        public MainForm()
        {
            InitializeComponent();
            library = new Library();
            library.LoadBooksFromJson("C:\\Users\\Masha\\Desktop\\IT-kids\\Nure\\ExampleCourseWork\\ExampleCourseWork\\books.json");
            librarian = new Librarian("adminname", "password123");
            searchResults = new List<Book>();
            DisplayBooks(library.Books);
            InitializeCollectionComboBox();
            InitializeEventHandlers();
            MainPageButton.Visible = false;
            isLibrarian = false;
            UserFeatures();
            
        }

        private void InitializeCollectionComboBox()
        {
            collectionToolStripComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            collectionToolStripComboBox.Items.Clear();

            List<string> collections = library.GetAllCollections();

            if (collections != null)
            {
                collectionToolStripComboBox.Items.AddRange(collections.ToArray());
            }

            if (collectionToolStripComboBox.Items.Count > 0)
            {
                collectionToolStripComboBox.SelectedIndex = 0;
            }

            collectionToolStripComboBox.SelectedIndexChanged += CollectionToolStripComboBox_SelectedIndexChanged;
        }


        private void InitializeEventHandlers()
        {
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            library.SaveBooksToJson("C:\\Users\\Masha\\Desktop\\IT-kids\\Nure\\ExampleCourseWork\\ExampleCourseWork\\books.json");
        }
        private void CollectionToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCollection = collectionToolStripComboBox.SelectedItem?.ToString();     
            searchResults = library.Books.Where(b => b.Collection == selectedCollection).ToList();
            if (searchResults.Any())
            {
                UpdateResultList(searchResults);
                MainPageButton.Visible = true;
            }
            else
            {
                MessageBox.Show($"Колекція '{selectedCollection}' порожня.", "Наявність книг у колекції", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateResultList(searchResults);
                MainPageButton.Visible = false;
            }
            
        }

        private void ResultList_DoubleClick(object sender, EventArgs e)
        {
            var selectedBook = GetSelectedBook();
            if (selectedBook != null)
            {
                using (var editBookForm = new EditBookForm(selectedBook, false, library, false, isLibrarian))
                {
                    editBookForm.ShowDialog();
                }
            }
        }

        private Book GetSelectedBook()
        {
            var selectedBook = (string)ResultList.SelectedItem;
            return library.Books.FirstOrDefault(b => $"{b.DisplayInfo}" == selectedBook);
        }

        private void DisplayBooks(List<Book> books)
        {
            ResultList.DataSource = null;
            ResultList.DataSource = library.Books.Select(b => $"{b.DisplayInfo}").ToList();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            library.SaveBooksToJson("C:\\Users\\Masha\\Desktop\\IT-kids\\Nure\\ExampleCourseWork\\ExampleCourseWork\\books.json");
            MessageBox.Show("Have been saved");
            Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var idText = IdTextBox.Text.Trim();
            var titleText = TitleTextBox.Text.Trim();
            var authorText = AuthorTextBox.Text.Trim();
            var yearText = YearTextBox.Text.Trim();
            var genreText = GenreTextBox.Text.Trim();
            var languageText = LanguageTextBox.Text.Trim();

            searchResults = library.SearchBooks(idText, titleText, authorText, yearText, genreText, languageText);
           
            UpdateResultList(searchResults);


        }

        private void UpdateResultList(List<Book> books)
        {
            ResultList.DataSource = null;
            ResultList.DataSource = books.Select(b => $"{b.DisplayInfo}").ToList();
            if (books.Count == 0)
            {
                MessageBox.Show("Книг не знайдено.");
                DisplayBooks(library.Books);
            }

        }

        private void EditBookButton_Click(object sender, EventArgs e)
        {
            if (ResultList.SelectedIndex == -1)
            {
                MessageBox.Show("Оберіть книгу для редагування.");
                return;
            }

            var selectedBook = library.Books[ResultList.SelectedIndex];
            using (var editBookForm = new EditBookForm(selectedBook, true, library, false, isLibrarian))
            {
                if (editBookForm.ShowDialog() == DialogResult.OK)
                {
                    DisplayBooks(library.Books);
                }
            }
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            var newBook = new Book
            {
                Id = library.Books.Max(b => b.Id) + 1 
            };

            using (var addBookForm = new EditBookForm(newBook, true, library, true, isLibrarian))
            {
                if (addBookForm.ShowDialog() == DialogResult.OK)
                {
                    DisplayBooks(library.Books);
                }
            }

        }

        private void MainPageButton_Click(object sender, EventArgs e)
        {
            DisplayBooks(library.Books);
            MainPageButton.Visible = false;
         
             
        }

        private void AddCollectionButton_Click(object sender, EventArgs e)
        {
            using (var inputForm = new InputBoxForm())
            {
                if(inputForm.ShowDialog() == DialogResult.OK)
                {
                    string newCollectionName = inputForm.InputText;
                    library.AddNewCollection(newCollectionName);
                    UpdateComboBoxes();
                }
            }
        }

        private void UpdateComboBoxes()
        {
            collectionToolStripComboBox.Items.Clear();
            collectionToolStripComboBox.Items.AddRange(library.Collections.ToArray());

            foreach (Form form in Application.OpenForms)
            {
                if (form is EditBookForm editBookForm)
                {
                    editBookForm.UpdateCollectionComboBoxes(library.Collections);
                }
            }
        }

        private void LibrarianButton_Click(object sender, EventArgs e)
        {
            if (isLibrarian)
            {
                UserFeatures();
               
            }
            else
            {
                using (var loginForm = new LoginForm(librarian))
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        LibrarianFeatures();
                       
                    }
                }
            }
        }

        private void LibrarianFeatures()
        {
            EditBookButton.Visible = true;
            AddBookButton.Visible = true;
            AddCollectionButton.Visible = false;
            DeleteCollectionButton.Visible = false;
            collectionToolStripComboBox.Enabled = false;
            LibrarianButton.Text = "Користувач";
            isLibrarian = true;
            MainPageButton.Visible = false;
        }

        private void UserFeatures()
        {
            EditBookButton.Visible = false;
            AddBookButton.Visible = false;
            AddCollectionButton.Visible = true;
            DeleteCollectionButton.Visible = true;
            collectionToolStripComboBox.Enabled = true;
            LibrarianButton.Text = "Бібліотекар";
            isLibrarian = false;
        }

        private void DeleteCollectionButton_Click(object sender, EventArgs e)
        {
            using (var inputForm = new InputBoxForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    string CollectionName = inputForm.InputText;
                    library.DeleteCollection(CollectionName);
                    List<Book> booksToRemove = library.GetBooksByCollection(CollectionName);

                    foreach (Book book in booksToRemove)
                    {
                        book.Collection = string.Empty; 
                    }

                    UpdateComboBoxes();
                }
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.Title = "Save as TXT";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveResultListAsTxt(filePath);
            }
        }

        private void SaveResultListAsTxt(string FilePath)
        {
            try
            {
                
                library.SaveLibraryAsTxt(searchResults, FilePath);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Помилка збереження списку книг у файл TXT: {ex.Message}");
            }
            
        }
    }
}
