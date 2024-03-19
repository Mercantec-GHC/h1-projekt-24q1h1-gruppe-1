CREATE TABLE Headsets
(
    Id BIGINT PRIMARY KEY,
    Url VARCHAR(255),
    Brand VARCHAR(255),
    Model VARCHAR(255),
    Color VARCHAR(255),
    FrequencyRange VARCHAR(255),
    Microphone BIT,
    TypeOfConnection VARCHAR(255),
    NoiseCancellation BIT,
    ClosedOrOpen VARCHAR(255),
    ItemCondition VARCHAR(255),
    Price INT,
    ImageUrl VARCHAR(255)
);