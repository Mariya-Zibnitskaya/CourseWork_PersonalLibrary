using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



namespace ExampleCourseWork.Models
{
    public class Library
    {
        public List<Book> Books {get; set; }
        public List<string> Collections { get; set; }

        public Library()
        {
           Books = new List<Book>();
           Collections = new List<string> {"Прочитані", "Хочу прочитати", "Улюблені"};
        }

        public void LoadBooksFromJson(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonText = File.ReadAllText(filePath);
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var data = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonText, options);

                    if (data.TryGetValue("Books", out object booksObject))
                    {
                        Books = JsonSerializer.Deserialize<List<Book>>(booksObject.ToString(), options) ?? new List<Book>();
                    }
                    else
                    {
                        Books = new List<Book>();
                    }

                    if (data.TryGetValue("Collections", out object collectionsObject))
                    {
                        Collections = JsonSerializer.Deserialize<List<string>>(collectionsObject.ToString(), options) ?? new List<string>();
                    }
                    else
                    {
                        Collections = new List<string>();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантажені даних з Json: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void SaveBooksToJson(string filePath)
        {
            try
            {
                var libraryData = new
                {
                    Books = Books,
                    Collections = Collections
                };
                var options = new JsonSerializerOptions { 
                    WriteIndented = true
                    };
                
                var json = JsonSerializer.Serialize(libraryData, options);
                json = System.Text.RegularExpressions.Regex.Unescape(json);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Помилка при завантажені даних з Json: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public List<Book> SearchBooks(string id, string title, string author, string year, string genre, string language)
        {
            int.TryParse(id, out int parsedId);
            bool isYearValid = int.TryParse(year, out int parsedYear);

            int currentYear = DateTime.Now.Year;

            return Books.Where(book =>
                (string.IsNullOrEmpty(id) || book.Id == parsedId) &&
                (string.IsNullOrEmpty(title) || book.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0) &&
                (string.IsNullOrEmpty(author) || book.Author.IndexOf(author, StringComparison.OrdinalIgnoreCase) >= 0) &&
                (string.IsNullOrEmpty(year) ||
                (isYearValid && year.Length == 4 && book.Year == parsedYear) ||
                (isYearValid && year.Length == 3 && book.Year >= parsedYear * 10 && book.Year <= currentYear)) &&
                (string.IsNullOrEmpty(genre) || book.Genre.IndexOf(genre, StringComparison.OrdinalIgnoreCase) >= 0) &&
                (string.IsNullOrEmpty(language) || book.Language.IndexOf(language, StringComparison.OrdinalIgnoreCase) >= 0)
            ).ToList();
        }


        public void AddBookToCollection(Book book, string collectionName)
        {
            if (Collections.Contains(collectionName))
            {
                book.Collection = collectionName;
            }
        }

       

        public void RemoveBookFromCollection(Book book, string collectionName)
        {
            if(Collections.Contains(collectionName) && book.Collection == collectionName)
            {
                book.Collection = string.Empty;
            }
        }
        public List<Book> GetBooksByCollection(string collectionName)
        {
            return Books.Where(book => book.Collection == collectionName).ToList();
        }

        public void AddNewCollection(string collectionName)
        {
            if (!Collections.Contains(collectionName))
            {
                Collections.Add(collectionName);
                
            }
        }

        public List<string> GetAllCollections()
        {
            return Collections.ToList();
        }

        public void DeleteCollection(string collectionName)
        {
            if (collectionName == "Прочитані" || collectionName == "Хочу прочитати" || collectionName == "Улюблені")
            {
                MessageBox.Show("Стандартні колекції не можна видаляти.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Collections.Contains(collectionName))
            {
                Collections.Remove(collectionName);
                
                MessageBox.Show($"Колекцію '{collectionName}' успішно видалено.", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Колекція '{collectionName}' не існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveLibraryAsTxt(List<Book> filteredBook, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Список книг");
                    writer.WriteLine("=================");
                    writer.WriteLine();

                    foreach (var book in filteredBook)
                    {
                        writer.WriteLine($"Title: {book.Title}");
                        writer.WriteLine($"Author: {book.Author}");
                        writer.WriteLine($"Year: {book.Year}");
                        writer.WriteLine($"Genre: {book.Genre}");
                        writer.WriteLine($"Language: {book.Language}");
                        writer.WriteLine($"Collection: {book.Collection}");
                        writer.WriteLine($"Annotation: {book.Annotation}");
                        writer.WriteLine();
                        writer.WriteLine("-----------------");
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Список книг успішно збережено.", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження книг до файлу TXT: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
