USE master

IF DB_ID('FlashCards') IS NOT NULL
BEGIN
	ALTER DATABASE FlashCards SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE FlashCards;
END
CREATE DATABASE FlashCards;

USE FlashCards

BEGIN TRANSACTION;

CREATE TABLE cards (
	id int IDENTITY(1,1) NOT NULL,
	name varchar(50) NOT NULL,
	category varchar(50) NOT NULL,
	description varchar(500) NOT NULL
)

INSERT INTO cards (name, category, description) VALUES ('dummy', 'dumb', 'this is a dumb category');
INSERT INTO cards (name, category, description) VALUES ('smartie', 'smart', 'this is a smart category!');

COMMIT;