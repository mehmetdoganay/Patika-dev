CREATE TABLE employee (
	id SERIAL PRIMARY KEY,
	name VARCHAR(50) ,
	email VARCHAR(100),
	birthday DATE
);


insert into employee (name, email, birthday) values ('Misti', 'mlillyman0@redcross.org', '1981-08-21');
insert into employee (name, email, birthday) values ('Yurik', 'ydrage1@google.co.jp', '1952-05-30');
insert into employee (name, email, birthday) values ('Tallou', 'tgabriel2@alibaba.com', '1953-12-07');
insert into employee (name, email, birthday) values ('Corissa', 'corme3@ed.gov', '1999-01-02');
insert into employee (name, email, birthday) values ('Cale', 'cdenyer4@washingtonpost.com', '1999-12-31');
insert into employee (name, email, birthday) values ('Alice', 'agoatcher5@gizmodo.com', '1978-10-16');
insert into employee (name, email, birthday) values ('Abigale', 'ahenrys6@newsvine.com', '1974-03-02');
insert into employee (name, email, birthday) values ('Brooke', 'bdunsmuir7@google.de', '1973-02-13');
insert into employee (name, email, birthday) values ('Alphard', 'aalfonsetti8@un.org', '1963-10-07');
insert into employee (name, email, birthday) values ('Deonne', 'dgolagley9@google.ru', '1957-06-01');
insert into employee (name, email, birthday) values ('Udale', 'ucasta@feedburner.com', '1977-01-03');
insert into employee (name, email, birthday) values ('Paulette', 'pdonnellb@hugedomains.com', '1982-01-29');
insert into employee (name, email, birthday) values ('Ike', 'imaccartairc@nature.com', '1977-12-21');
insert into employee (name, email, birthday) values ('Myra', 'mbencherd@jigsy.com', '1981-01-10');
insert into employee (name, email, birthday) values ('Tabbatha', 'tferrerese@github.com', '1959-07-08');
insert into employee (name, email, birthday) values ('Farlie', 'fsharnockf@ucoz.com', '1974-06-18');
insert into employee (name, email, birthday) values ('Maxim', 'mmcausleneg@ed.gov', '1993-01-10');
insert into employee (name, email, birthday) values ('Albrecht', 'aloobyh@unicef.org', '1968-04-26');
insert into employee (name, email, birthday) values ('Elenore', 'emickani@tinypic.com', '1974-12-07');
insert into employee (name, email, birthday) values ('Drud', 'dprickettj@vk.com', '2004-09-28');
insert into employee (name, email, birthday) values ('Albert', 'aglaviask@npr.org', '2004-11-22');
insert into employee (name, email, birthday) values ('Maudie', 'mviviansl@moonfruit.com', '2006-12-14');
insert into employee (name, email, birthday) values ('Lorilyn', 'lleysm@bloglovin.com', '1966-07-07');
insert into employee (name, email, birthday) values ('Rudolf', 'rmcuren@yellowpages.com', '2001-09-27');
insert into employee (name, email, birthday) values ('Farica', 'fdowno@boston.com', '1973-03-09');
insert into employee (name, email, birthday) values ('Bevin', 'bblaaschp@geocities.com', '1961-06-13');
insert into employee (name, email, birthday) values ('Tarra', 'tmuehleq@java.com', '1969-12-28');
insert into employee (name, email, birthday) values ('Ashla', 'adipietror@theglobeandmail.com', '2001-03-28');
insert into employee (name, email, birthday) values ('Temp', 'tlosselyongs@wufoo.com', '1994-05-17');
insert into employee (name, email, birthday) values ('Madelina', 'mbaymant@last.fm', '1951-12-02');
insert into employee (name, email, birthday) values ('Esme', 'erealyu@about.me', '1993-09-05');
insert into employee (name, email, birthday) values ('Natalina', 'nklimkinv@ustream.tv', '1981-10-20');
insert into employee (name, email, birthday) values ('Paulo', 'psaltersw@behance.net', '1976-02-27');
insert into employee (name, email, birthday) values ('Reinhold', 'rsketchleyx@booking.com', '1962-11-09');
insert into employee (name, email, birthday) values ('Juliane', 'jjeandillouy@google.com.au', '1960-04-09');
insert into employee (name, email, birthday) values ('Stillmann', 'smuxworthyz@geocities.com', '1997-01-10');
insert into employee (name, email, birthday) values ('Maren', 'mnockles10@etsy.com', '1973-10-24');
insert into employee (name, email, birthday) values ('Carlyle', 'cmullett11@de.vu', '1981-12-02');
insert into employee (name, email, birthday) values ('Janifer', 'jtrotter12@freewebs.com', '1990-02-08');
insert into employee (name, email, birthday) values ('Maddy', 'mstare13@tripod.com', '1978-03-04');
insert into employee (name, email, birthday) values ('Ced', 'cnoot14@webnode.com', '2002-05-10');
insert into employee (name, email, birthday) values ('Michaela', 'mmclaverty15@prlog.org', '1960-10-27');
insert into employee (name, email, birthday) values ('Laetitia', 'lbales16@bloglovin.com', '1993-03-02');
insert into employee (name, email, birthday) values ('Pryce', 'pcropton17@msu.edu', '1993-09-20');
insert into employee (name, email, birthday) values ('Tanhya', 'tbaldrey18@digg.com', '1989-12-17');
insert into employee (name, email, birthday) values ('Wynne', 'wdonizeau19@latimes.com', '1993-05-11');
insert into employee (name, email, birthday) values ('Terrance', 'trapp1a@de.vu', '2007-02-19');
insert into employee (name, email, birthday) values ('Gerome', 'gludlamme1b@reddit.com', '1996-09-10');
insert into employee (name, email, birthday) values ('Aurelie', 'akittredge1c@digg.com', '2006-06-23');
insert into employee (name, email, birthday) values ('Jackelyn', 'jwilshin1d@icq.com', '1997-05-07');



UPDATE employee
SET name = 'Ahmet',
	email = 'ahmet@gmail.com',
	birthday = '1979.05.21'
WHERE id = 22;

UPDATE employee
SET name = 'Mehmet',
	email = 'mehmet@gmail.com',
	birthday = '1999.06.06'
WHERE name = 'Misti';

UPDATE employee
SET name = 'Elif',
	email= 'elif@gmail.com',
	birthday = '2000.08.07'
WHERE email = 'ydrage1@google.co.jp';

UPDATE employee
SET name = 'Aleyna',
	email = 'aleyna@gmail.com',
	birthday = '1960.04.19'
WHERE birthday = '1953-12-07';

UPDATE employee
SET name = 'Ayse',
	email= 'ayse@gmail.com',
	birthday = '1970.09.23'
WHERE id = 44;


DELETE FROM employee
WHERE id = 11;

DELETE FROM employee
WHERE name ='Myra';

DELETE FROM employee
WHERE email = 'bdunsmuir7@google.de';

DELETE FROM employee
WHERE birthday = '1977-12-21';

DELETE FROM employee
WHERE id = 38;
	


