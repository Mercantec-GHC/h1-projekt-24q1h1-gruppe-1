CREATE TABLE UserAccount
(
    ID SERIAL PRIMARY KEY,
    Firstname VARCHAR(255),
    Lastname VARCHAR(255),
    YearOfBirth INT,
    Email VARCHAR(255),
    Phonenumber INT,
    UserPassword VARCHAR(255),
    Address VARCHAR(255),
    Country VARCHAR(255),
    City VARCHAR(255),
    Status VARCHAR(255)
);