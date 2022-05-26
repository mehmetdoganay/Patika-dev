CREATE TABLE books (
	id SERIAL PRIMARY KEY,
	title VARCHAR(100) NOT NULL,
	page_number INTEGER NOT NULL,
	author_id INTEGER REFERENCES author(id) --FOREIGN KEY 
);


--INSERT
insert into books (title, page_number, author_id) values ('Bourne Identity, The', 50, 5);
insert into books ( title, page_number, author_id) values ('Twist of Faith', 60, 2);
insert into books (title, page_number, author_id) values ('Baby, The', 100, 60);
insert into books (title, page_number, author_id) values ('Alice Upside Down (Alice)', 400, 29);
insert into books (title, page_number, author_id) values ('Colorado Avenue', 500, 55);
insert into books (title, page_number, author_id) values ('Unfinished Song (Song for Marion)', 789, 29);
insert into books (title, page_number, author_id) values ('Way Back, The', 240, 32);
insert into books (title, page_number, author_id) values ('Mutant Action (Acción Mutante)', 112, 10);
insert into books (title, page_number, author_id) values ('Cool World, The', 543, 92);
insert into books (title, page_number, author_id) values ('Bill Cunningham New York', 29, 90);
insert into books (title, page_number, author_id) values ('Cries and Whispers (Viskningar och rop)', 12, 50);
insert into books (title, page_number, author_id) values ('Planes: Fire & Rescue', 124, 9);
insert into books (title, page_number, author_id) values ('Fun with Dick and Jane', 1346, 16);
insert into books (title, page_number, author_id) values ('King of the Children (Hai zi wang)', 89, 13);
insert into books (title, page_number, author_id) values ('10th Victim, The (La decima vittima)', 439, 56);
