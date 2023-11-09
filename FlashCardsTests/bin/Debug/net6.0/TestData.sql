USE FlashCardsTest;

BEGIN TRANSACTION;

CREATE TABLE cards (
	id int IDENTITY(1,1) NOT NULL,
	name varchar(50) NOT NULL,
	category varchar(50) NOT NULL,
	description varchar(500) NOT NULL
	CONSTRAINT pk_cards PRIMARY KEY (id)
)

INSERT INTO cards (name, category, description) VALUES ('dummy', 'dumb', 'this is a dumb category');
INSERT INTO cards (name, category, description) VALUES ('smartie', 'smart', 'this is a smart category!');

COMMIT TRANSACTION;