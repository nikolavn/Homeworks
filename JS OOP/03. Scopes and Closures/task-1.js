/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function() {
		var books = [];
		var categories = [];

		function listBooks(filter) {
			var output = [],
				filterType;
			if (arguments.length === 0) {
				return books;
			}

			for (filterType in filter) {
				books.map(function(book) {
					if (book[filterType] === filter[filterType] || book[filterType] === filter[filterType]) {
						output.push(book);
					}
				});
			}

			return output;
		}

		function addBook(book) {
			book.ID = books.length + 1;
			book.title = validateName(book.title);
			book.isbn = validateISBN(book.isbn);
			book.author = validateAuthor(book.author);
			if (categories.indexOf(book.category) < 0) {
				addCategory(book.category);
			}
			books.push(isUniqueBook(book, books));
			return book;
		}

		function listCategories() {
			return categories.sort(function(catA, catB) {
				return catA.ID - catB.ID;
			});
		}

		function addCategory(category) {
			category.ID = categories.length + 1;
			category.name = category;
			categories.push(category);

			return category;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories,
				add: addCategory
			}
		};
	}());
	return library;

	//Validation functions

	function validateISBN(isbn) {
		if (isbn.length !== 10) {
			if (isbn.length !== 13) {
				if (!(/([0-9])+/g.test(isbn))) {
					throw new Error('ISBN is 10 or 13 digits.');
				}
			}
		}
		return isbn;
	}

	function validateName(name) {
		if (name.length < 2 || name.length > 100) {
			throw new Error('Book title/Category name should be between 2 and 100 characters');
		}

		return name;
	}

	function validateAuthor(author) {
		if (!author.trim()) {
			throw new Error('Author must have a name');
		}

		return author;
	}

	function isUniqueBook(book, books) {
		for (var currenBook = 0; currenBook < books.length; currenBook += 1) {
			if (book.isbn === books[currenBook].isbn) {
				throw new Error('Book with same ISBN already added');
			}

			if (book.title === books[currenBook].title) {
				throw new Error('Book with same title already exists');
			}
		}

		return book;
	}
}
module.exports = solve;



