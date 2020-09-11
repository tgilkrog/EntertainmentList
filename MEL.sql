use master;
if exists (select * from sys.databases where name='MEL')
	drop database MEL;
go
create database MEL;
go

use MEL;

CREATE TABLE MELUser(
	id int primary key identity(1,1),
	userName varchar(max) NOT NULL,
	userPassword varchar(max) NOT NULL,
	userEmail varchar(max) not NULL,
	fullname varchar(max),
	profilePic varchar(MAX),
	favCat varchar(50)
);

CREATE TABLE Movie(
	id int primary key identity(1,1),
	itemName varchar(50) NOT NULL,
	itemPicture varchar(MAX),
	itemGenre varchar(50) NOT NULL,
	movieLength int NOT NULL
);

CREATE TABLE TvSerie(
	id int primary key identity(1,1),
	itemName varchar(50) NOT NULL,
	itemPicture varchar(MAX),
	itemGenre varchar(50) NOT NULL,
	seasons int NOT NULL,
	episodeLength int NOT NULL
);

CREATE TABLE Game(
	id int primary key identity(1,1),
	itemName varchar(50) NOT NULL,
	itemPicture varchar(MAX),
	itemGenre varchar(50) NOT NULL,
	avgPlayTime int
);

CREATE TABLE MovieReview(
	id int primary key identity(1,1),
	thoughts varchar(MAX) NOT NULL,
	score int NOT NULL,
	movieId int NOT NULL foreign key references Movie(id),
	userId int NOT NULL foreign key references MELUser(id)
);

CREATE TABLE TvSerieReview(
	id int primary key identity(1,1),
	thoughts varchar(MAX) NOT NULL,
	score int NOT NULL,
	tvSerieId int NOT NULL foreign key references TvSerie(id),
	userId int NOT NULL foreign key references MELUser(id)
);

CREATE TABLE GameReview(
	id int primary key identity(1,1),
	thoughts varchar(MAX) NOT NULL,
	score int NOT NULL,
	gameId int NOT NULL foreign key references Game(id),
	userId int NOT NULL foreign key references MELUser(id)
);




INSERT INTO MELUser VALUES('Rhazhin', 'hejsa', 'tgilkrog@gmail.com', 'Thais Gilkrog', 'https://as1.ftcdn.net/jpg/02/02/16/26/500_F_202162608_C67aJbhpDgKQqmV8SSSBbmgIb7dqg32i.jpg', 'Gyser');
INSERT INTO MELUser VALUES('SlimCrack', 'dav', 'hej@hejsa.dk', 'Paw Gilkrog', 'https://as1.ftcdn.net/jpg/03/29/11/46/500_F_329114666_8miv370k2Nys2kH7wRL7ZJ2lTzWv3Kv2.jpg', 'Romantik');

INSERT INTO Movie VALUES('Gonjiam: Haunted Asylum', 'https://www.kultunaut.dk/images/film/7097615/plakat.jpg', 'Horror', 95);
INSERT INTO Movie VALUES('Event Horizon', 'https://images-na.ssl-images-amazon.com/images/I/81I-1PhUy2S._SL1410_.jpg', 'Horror', 97);
INSERT INTO Movie VALUES('Spirited Away', 'https://alchetron.com/cdn/Spirited-Away-images-60c5d1ac-a342-476d-a3a6-80e9a6b5d0f.jpg', 'Anime', 125);
INSERT INTO Movie VALUES('Akira', 'https://artfiles.alphacoders.com/100/100534.jpg', 'Anime', 126);

INSERT INTO TvSerie VALUES('Breaking Bad', 'https://m.media-amazon.com/images/M/MV5BMjhiMzgxZTctNDc1Ni00OTIxLTlhMTYtZTA3ZWFkODRkNmE2XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg', 'Crime', 5, 50);
INSERT INTO TvSerie VALUES('The Sopranos', 'https://scale.coolshop-cdn.com/product-media.coolshop-cdn.com/AE6F9U/f165304195554b5babb70832120fe68d.jpeg/f/sopranos-box-komplet-saeson-1-6-blu-ray.jpeg', 'Crime', 6, 50);
INSERT INTO TvSerie VALUES('Vikings', 'https://www.imusic.dk/images/item/scaled/517/7333018015517/vikings-2019-vikings-season-5-vol-2-dvd.jpg', 'Drama', 6, 50);
INSERT INTO TvSerie VALUES('Sons Of Anarchy', 'https://www.slantmagazine.com/wp-content/uploads/2011/09/sonsofanarchy3.jpg', 'Drama', 7, 50);


INSERT INTO Game VALUES('Vampire Masquerade Bloodlines', 'https://images-na.ssl-images-amazon.com/images/I/51KRPG1YWPL._AC_.jpg', 'RPG', 22);
INSERT INTO Game VALUES('The Witcher 3', 'https://static.posters.cz/image/750/plakater/the-witcher-3-wild-hunt-i49441.jpg', 'RPG', 51);
INSERT INTO Game VALUES('Remnant From the Ashes', 'https://store-images.s-microsoft.com/image/apps.14175.14118342467613503.205f1a58-c4f9-4e91-a8a7-29e8dbdd704d.40542df8-d5f7-4cf4-a755-19bd1ebdf88a', 'RPG', 13);

INSERT INTO MovieReview VALUES('Dette er en god asiatisk found footage gyser, hvor de filmer på et sinsyg hospital. Den er lidt langsom i starten, men har en fantastisk sidste del.', 5, 1, 1);
INSERT INTO MovieReview VALUES('Den er uhyggelig.', 5, 2, 1);

INSERT INTO MovieReview VALUES('Den har jeg ikke set endnu', 1, 3, 2)

INSERT INTO TvSerieReview VALUES('En af mine favorit serier som omhandler en kemi lære der får kraft og beynger at lave meth for at tjene penge.', 5, 1, 1);