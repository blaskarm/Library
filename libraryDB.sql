-- DROP DATABASE librarydb;

CREATE DATABASE librarydb;
USE librarydb;

/*CREATE USER library_manager IDENTIFIED BY "librarypassword";
GRANT SELECT, INSERT, UPDATE, DELETE, EXECUTE
ON librarydb.*
TO library_manager;*/

CREATE TABLE members (
	member_id INT PRIMARY KEY AUTO_INCREMENT,
    full_name VARCHAR(150),
    member_password VARCHAR(25),
    email VARCHAR(320)
);

INSERT INTO members
VALUES (DEFAULT, "Emil Lindhult", "hej123", "emil@gmail.com"),
	   (DEFAULT, "Ricky Anderson", "lol123", "ricky@gmail.com"),
	   (DEFAULT, "Carl Boo", "wtf321", "carl@outlook.com"),
       (DEFAULT, "Anne Schultz", "lmao222", "anne@gmail.com"),
       (DEFAULT, "Fred Jackson", "hehehe34", "fred@gmail.com"),
       (DEFAULT, "Violet Johnson", "hurdur090", "violet@hotmail.com"),
       (DEFAULT, "John Jones", "derp666", "john@gmail.com"),
       (DEFAULT, "Monica Manson", "schmo415", "monica@gmail.com"),
       (DEFAULT, "Nick Carlson", "slasla333", "nick@hotmail.com");


CREATE TABLE authors (
	author_id INT PRIMARY KEY AUTO_INCREMENT,
    full_name VARCHAR(150),
    birthdate DATE,
    nationality VARCHAR(45)
);

INSERT INTO authors
VALUES (DEFAULT, "Hanya Yanagihara", "1974-09-20", "American"),
	   (DEFAULT, "David Nicholls", "1966-11-30", "British"),
	   (DEFAULT, "Abdulrazak Gurnah", "1948-12-20", "Tanzanian"),
	   (DEFAULT, "Rebecca Yarros", "1981-04-14", "American"),
	   (DEFAULT, "John Green", "1977-08-24", "American"),
	   (DEFAULT, "Dolly Alderton", "1988-08-31", "British"),
	   (DEFAULT, "John Grisham", "1955-02-08", "American"),
	   (DEFAULT, "Susanna Clarke", "1959-11-01", "British"),
       (DEFAULT, "Peter James", "1948-08-22", "British");


CREATE TABLE books (
	book_id INT PRIMARY KEY AUTO_INCREMENT,
    title VARCHAR(100),
    pages INT,
    published DATE,
    available_copies INT,
    author_id INT,
    FOREIGN KEY(author_id) REFERENCES authors(author_id)
);

INSERT INTO books
VALUES (DEFAULT, "To Paradise", 736, "2022-01-05", 5, 1),
	   (DEFAULT, "A Little Life", 832, "2016-01-26", 3, 1),
	   (DEFAULT, "One Day", 448, "2010-02-04", 6, 2),
	   (DEFAULT, "Sweet Sorrow", 416, "2020-08-04", 2, 2),
	   (DEFAULT, "Us", 416, "2015-05-07", 1, 2),
	   (DEFAULT, "Afterlives", 288, "2021-09-02", 2, 3),
	   (DEFAULT, "Gravel Heart", 272, "2018-05-17", 3, 3),
	   (DEFAULT, "By The Sea", 256, "2002-07-01", 2, 3),
	   (DEFAULT, "Desertion", 272, "2006-05-01", 1, 3),
	   (DEFAULT, "Fourth Wing", 512, "2023-05-02", 4, 4),
	   (DEFAULT, "Iron Flame", 512, "2023-11-07", 3, 4),
	   (DEFAULT, "Looking for Alaska", 272, "2013-02-28", 2, 5),
	   (DEFAULT, "Turtles All the Way Down", 320, "2018-09-20", 3, 5),
	   (DEFAULT, "Everything I Know About Love", 368, "2019-02-07", 2, 6),
	   (DEFAULT, "Good Material", 352, "2023-11-09", 3, 6),
       (DEFAULT, "Ghosts", 352, "2021-07-22", 1, 6),
       (DEFAULT, "Dear Dolly", 240, "2022-10-27", 2, 6),
       (DEFAULT, "Sparring Partners", 368, "2022-05-31", 2, 7),
       (DEFAULT, "Guardians", 368, "2020-06-11", 3, 7),
       (DEFAULT, "Time For Mercy", 448, "2021-06-29", 5, 7),
       (DEFAULT, "Piranesi", 272, "2021-09-02", 2, 8),
       (DEFAULT, "The Ladies of Grace Adieu", 256, "2007-09-01", 3, 8),
       (DEFAULT, "Left You Dead", 512, "2021-10-14", 5, 9),
       (DEFAULT, "Dead If You Don't", 512, "2018-10-18", 2, 9);


CREATE TABLE borrowed (
	borrowed_id INT PRIMARY KEY AUTO_INCREMENT,
    book_id INT,
    member_id INT,
    FOREIGN KEY(book_id) REFERENCES books(book_id),
    FOREIGN KEY(member_id) REFERENCES members(member_id)
);


CREATE TABLE favorites (
    book_id INT,
    member_id INT,
    FOREIGN KEY(book_id) REFERENCES books(book_id),
    FOREIGN KEY(member_id) REFERENCES members(member_id)
);

INSERT INTO favorites
VALUES (5, 2),
	   (3, 6),
	   (1, 1),
	   (9, 1),
	   (4, 3),
	   (12, 8),
	   (7, 1),
	   (2, 2);


DELIMITER $$
CREATE PROCEDURE change_available_copies(id INT, add_or_sub INT)
BEGIN
	UPDATE books
    SET available_copies = available_copies + add_or_sub
    WHERE book_id = id;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE get_member_favorites(id INT)
BEGIN
	SELECT books.book_id, title, pages, published, available_copies, author_id, members.member_id
	FROM books
	INNER JOIN favorites
	ON books.book_id = favorites.book_id
	INNER JOIN members
	ON favorites.member_id = members.member_id
	WHERE favorites.member_id = id;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE get_member_borrowed_books(id INT)
BEGIN
	SELECT books.book_id, title, pages, published, available_copies, author_id, members.member_id
    FROM books
    INNER JOIN borrowed
    ON books.book_id = borrowed.book_id
    INNER JOIN members
    ON borrowed.member_id = members.member_id
    WHERE borrowed.member_id = id;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE search_book_title(search_text VARCHAR(100))
BEGIN
	SELECT * FROM books
    WHERE title
    LIKE CONCAT('%', search_text, '%');
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE search_author_name(search_text VARCHAR(100))
BEGIN
	SELECT * FROM authors
    WHERE full_name
    LIKE CONCAT('%', search_text, '%');
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE add_to_favorites(book_id INT, member_id INT)
BEGIN
	INSERT INTO favorites
    VALUES (book_id, member_id);
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE remove_from_favorites(book_id INT, member_id INT)
BEGIN
	DELETE FROM favorites
    WHERE book_id = favorites.book_id
    AND member_id = favorites.member_id;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE borrow_book(book_id INT, member_id INT)
BEGIN
	INSERT INTO borrowed
    VALUES (DEFAULT, book_id, member_id);
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE return_book(book_id INT, member_id INT)
BEGIN
	DELETE FROM borrowed
    WHERE borrowed.book_id = book_id
    AND borrowed.member_id = member_id;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE change_member_name(id INT, _name VARCHAR(150))
BEGIN
	UPDATE members
    SET full_name = _name
    WHERE member_id = id;
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE change_member_password(id INT, _password VARCHAR(25))
BEGIN
	UPDATE members
    SET member_password = _password
    WHERE member_id = id;
END$$

CREATE PROCEDURE change_member_email(id INT, _email VARCHAR(320))
BEGIN
	UPDATE members
    SET email = _email
	WHERE member_id = id;
END$$

CREATE PROCEDURE add_new_author(_name VARCHAR(150), _birthdate DATE, _nationality VARCHAR(45))
BEGIN
	INSERT INTO authors
    VALUES (DEFAULT, _name, _birthdate, _nationality);
END$$

CREATE PROCEDURE add_new_book(_title VARCHAR(100), _pages INT, _published DATE, _available_copies INT, _author_id INT)
BEGIN
	INSERT INTO books
    VALUES (DEFAULT, _title, _pages, _published, _available_copies, _author_id);
END$$
DELIMITER ;

-- SELECT * FROM members;
-- SELECT * FROM books;
-- SELECT * FROM authors;
-- SELECT * FROM loans;
-- SELECT * FROM favorites;