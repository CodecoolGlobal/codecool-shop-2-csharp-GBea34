DROP TABLE IF EXISTS suppliers;
DROP TABLE IF EXISTS productCategory;
DROP TABLE IF EXISTS products;
DROP TABLE IF EXISTS users;

create table suppliers (
	id INT,
	name VARCHAR(50),
	description VARCHAR(250)
);

create table productCategory (
	id INT,
	name VARCHAR(50)
);

create table products (
	id INT,
	name VARCHAR(50),
	default_price DECIMAL(3,1),
	currency VARCHAR(50),
	categories VARCHAR(50),
	supplier INT
);

create table users (
	id INT,
	name VARCHAR(50),
	password VARCHAR(50),
	cart VARCHAR(50),
	access_level VARCHAR(50)
);

insert into suppliers (id, name, description) values (1, 'Chio', 'Taste is Quality');
insert into suppliers (id, name, description) values (2, 'CrikCrok', 'New brand');
insert into suppliers (id, name, description) values (3, 'Eat Real', 'You do what you eat. Take in the power of real food for all the goodness you do and are.');
insert into suppliers (id, name, description) values (4, 'Lays', 'Lays. Get your smile on.');
insert into suppliers (id, name, description) values (5, 'fini', 'Its fun, its fini.');
insert into suppliers (id, name, description) values (6, 'Manner', 'Csokoládét mindenkinek');
insert into suppliers (id, name, description) values (7, 'Milka', 'Dare to be tender..');
insert into suppliers (id, name, description) values (8, 'Mizo', 'Mizo!');
insert into suppliers (id, name, description) values (9, 'Pocky', 'Share happiness.');
insert into suppliers (id, name, description) values (10, 'Snickers', 'You are not you when you are hungry');
insert into suppliers (id, name, description) values (11, 'Sour Patch', 'Sour Then Sweet');
insert into suppliers (id, name, description) values (12, 'Toffifee', 'Theres so much fun in Toffifee!');


insert into productCategory (name) values ('Sweet');
insert into productCategory (name) values ('Sour');
insert into productCategory (name) values ('Salty');
insert into productCategory (name) values ('Spicy');


insert into products (id, name, default_price, currency, categories, supplier) values (1, 'Chio Chees', 2.0, 'USD', 'Salty', 1);
insert into products (id, name, default_price, currency, categories, supplier) values (2, 'CrikCrok jalapeno', 1.5, 'USD', 'Spicy,Salty', 2);
insert into products (id, name, default_price, currency, categories, supplier) values (3, 'Eat Real chilli&lemon', 5.0, 'USD', 'Spicy,Sour', 3);
insert into products (id, name, default_price, currency, categories, supplier) values (4, 'fini Roller', 1.8, 'USD', 'Sweet,Sour', 5);
insert into products (id, name, default_price, currency, categories, supplier) values (5, 'Lays Classic', 2.1, 'USD', 'Salty', 4);
insert into products (id, name, default_price, currency, categories, supplier) values (6, 'Manner WIEN', 0.9, 'USD', 'Sweet', 6);
insert into products (id, name, default_price, currency, categories, supplier) values (7, 'Milka Choc and Choc', 4.0, 'USD', 'Sweet', 7);
insert into products (id, name, default_price, currency, categories, supplier) values (8, 'Mizo rudi', 0.8, 'USD', 'Sweet', 8);
insert into products (id, name, default_price, currency, categories, supplier) values (9, 'Pocky COOKIES and CREAM', 1.5, 'USD', 'Sweet', 9);
insert into products (id, name, default_price, currency, categories, supplier) values (10, 'Pocky STRAWBERRY', 1.7, 'USD', 'Sweet', 9);
insert into products (id, name, default_price, currency, categories, supplier) values (11, 'Snickers', 2.1, 'USD', 'Sweet', 10);
insert into products (id, name, default_price, currency, categories, supplier) values (12, 'Sour patch kids', 3.0, 'USD', 'Sour', 11);
insert into products (id, name, default_price, currency, categories, supplier) values (13, 'Toffifee', 8.0, 'USD', 'Sweet', 12);


insert into users (id, name, password, cart, access_level) values (1, 'admin', 'admin', null, 'admin');
insert into users (id, name, password, cart, access_level) values (2, 'test', 'test', null, 'user');