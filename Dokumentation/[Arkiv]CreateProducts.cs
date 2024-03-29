﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Domain_Models
{



    public class CreateProducts
    {
        public void InsertDummyDataInDB(List<Headset> AllProducts)
        {
            string connectionString = "Host=ep-blue-fire-a2nnh5p7.eu-central-1.aws.neon.tech;Username=sonaredb_owner;Password=8LlUVraRtDs9;Database=sonaredb;SSL Mode=Require";
            using var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;

                foreach (var headset in AllProducts)
                {
                    if (headset is WiredHeadphones wiredHeadphones)
                    {
                        string insertCommand = $@"
                            INSERT INTO Headsets(Brand, Model, Color, FrequencyRange, Microphone, TypeOfConnection, NoiseCancellation, ClosedOrOpen, ItemCondition, Price, ImageUrl, Type)
                            VALUES('{wiredHeadphones.brand}', '{wiredHeadphones.model}', '{wiredHeadphones.color}', '{wiredHeadphones.frequencyRange}', '{wiredHeadphones.microphone}', '{wiredHeadphones.typeOfConnection}', '{wiredHeadphones.noiseCancellation}', '{wiredHeadphones.closedOrOpen}', '{wiredHeadphones.itemCondition}', '{wiredHeadphones.price}', '{wiredHeadphones.imageUrl}', 'WiredHeadphones');";

                        cmd.CommandText = insertCommand;
                        cmd.ExecuteNonQuery();
                    } else if (headset is BluetoothHeadphones bluetoothHeadphones)
                    {
                        string insertCommand = $@"
                            INSERT INTO Headsets(Brand, Model, Color, FrequencyRange, Microphone, TypeOfConnection, NoiseCancellation, ClosedOrOpen, ItemCondition, Price, ImageUrl, Type)
                            VALUES('{bluetoothHeadphones.brand}', '{bluetoothHeadphones.model}', '{bluetoothHeadphones.color}', '{bluetoothHeadphones.frequencyRange}', '{bluetoothHeadphones.microphone}', '{bluetoothHeadphones.typeOfConnection}', '{bluetoothHeadphones.noiseCancellation}', '{bluetoothHeadphones.closedOrOpen}', '{bluetoothHeadphones.itemCondition}', '{bluetoothHeadphones.price}', '{bluetoothHeadphones.imageUrl}', 'BluetoothHeadphones');";

                        cmd.CommandText = insertCommand;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public List<Headset> CreateListOfProducts()
        {
            List<Headset> AllProducts = new List<Headset>();

            // Existing headphones
            AllProducts.Add(new WiredHeadphones("Sony", "S1", "Black", "20-20000hz", false, "3.5m", false, "Closed", "New", 200, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new WiredHeadphones("Bose", "E2", "Silver", "20-30000hz", false, "3.5mm", true, "Closed", "New", 300, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new WiredHeadphones("Audeze", "LCD-X", "Black", "10-40000hz", false, "3.5mm", false, "Open", "Used", 1500, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new BluetoothHeadphones("JBL", "X1", "Black", "15-30000hz", true, "Bluetooth", true, "Closed", "New", 250, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new BluetoothHeadphones("Beats", "Y1", "Red", "25-20000hz", true, "Bluetooth", true, "Closed", "Refurbished", 315, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new BluetoothHeadphones("Bose", "Quiet Comfort", "White", "20-50000hz", true, "Bluetooth", true, "Open", "Used", 300, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));

            // Adding 20 more headphones with existing brand names
            AllProducts.Add(new WiredHeadphones("Sony", "S2", "White", "18-22000hz", true, "3.5mm", false, "Closed", "New", 250, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new WiredHeadphones("Bose", "SoundSport", "Blue", "20-20000hz", true, "3.5mm", true, "Open", "New", 120, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new BluetoothHeadphones("Beats", "Studio3", "Black", "20-20000hz", true, "Bluetooth", true, "Closed", "Used", 280, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new BluetoothHeadphones("Bose", "Sport Earbuds", "Black", "20-20000hz", true, "Bluetooth", true, "Closed", "New", 200, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new WiredHeadphones("Sony", "WH-1000XM3", "Black", "4-40000hz", true, "3.5mm", false, "Closed", "New", 300, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new WiredHeadphones("Bose", "QuietComfort 35 II", "Silver", "20-20000hz", true, "3.5mm", false, "Closed", "Used", 280, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new BluetoothHeadphones("Beats", "Powerbeats Pro", "Red", "20-20000hz", true, "Bluetooth", true, "Closed", "New", 250, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new BluetoothHeadphones("Bose", "SoundLink Color II", "Blue", "20-20000hz", true, "Bluetooth", true, "Closed", "Used", 150, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new WiredHeadphones("Sony", "MDR7506", "Black", "10-20000hz", true, "3.5mm", true, "Closed", "New", 130, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new WiredHeadphones("Bose", "SoundTrue Ultra", "Charcoal", "20-20000hz", true, "3.5mm", false, "Closed", "New", 180, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new BluetoothHeadphones("Beats", "BeatsX", "Black", "20-20000hz", true, "Bluetooth", true, "Closed", "New", 100, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new BluetoothHeadphones("Bose", "SoundSport Free", "Black", "20-20000hz", true, "Bluetooth", true, "Closed", "New", 200, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new WiredHeadphones("Sony", "WH-CH510", "White", "20-20000hz", true, "3.5mm", true, "Closed", "New", 60, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new WiredHeadphones("Bose", "SoundTrue", "Charcoal", "20-20000hz", true, "3.5mm", false, "Closed", "New", 120, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new BluetoothHeadphones("Beats", "Beats Solo Pro", "Gray", "20-20000hz", true, "Bluetooth", true, "Closed", "New", 300, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new BluetoothHeadphones("Bose", "SoundSport Pulse", "Red", "20-20000hz", true, "Bluetooth", true, "Closed", "New", 150, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new WiredHeadphones("Sony", "MDR-Z1R", "Black", "4-120000hz", true, "6.35mm", false, "Closed", "New", 2000, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new WiredHeadphones("Bose", "AE2", "Black", "20-20000hz", true, "3.5mm", false, "Closed", "New", 100, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));
            AllProducts.Add(new BluetoothHeadphones("Beats", "Beats Flex", "Black", "20-20000hz", true, "Bluetooth", true, "Closed", "New", 50, "https://media.karousell.com/media/photos/products/2022/7/15/bose_quietcomfort_35_ii_1657861536_6fbc5e2d_progressive.jpg"));

            return AllProducts;
        }
    }
}