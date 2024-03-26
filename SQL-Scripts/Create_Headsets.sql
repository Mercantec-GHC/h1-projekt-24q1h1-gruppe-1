CREATE TABLE Headsets
(
    ID SERIAL PRIMARY KEY,
    Brand VARCHAR(255),
    Model VARCHAR(255),
    Color VARCHAR(255),
    FrequencyRange VARCHAR(255),
    Microphone BOOLEAN,
    TypeOfConnection VARCHAR(255),
    NoiseCancellation BOOLEAN,
    ClosedOrOpen VARCHAR(255),
    ItemCondition VARCHAR(255),
    Price INT,
    ImageUrl VARCHAR(255),
    Description VARCHAR(255),
    Type VARCHAR(255)
);