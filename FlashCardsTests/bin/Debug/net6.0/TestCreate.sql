IF DB_ID('FlashCardsTest') IS NOT NULL
BEGIN
	ALTER DATABASE FlashCardsTest SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE FlashCardsTest;
END
CREATE DATABASE FlashCardsTest;