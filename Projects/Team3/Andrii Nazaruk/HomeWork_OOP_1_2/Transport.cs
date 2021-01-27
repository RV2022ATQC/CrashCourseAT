﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace HomeWork_OOP_1_2
{
    [XmlInclude(typeof(Transport))]
    [Serializable]
    public abstract class Transport
    {
        public Transport()
        {

        }
        public Transport(string model,string mark,double price,string transportType,int yearOfExploatation,int speed,bool isWorking)
        {
            Model = model;
            Mark = mark;
            TransportType = transportType;
            Price = price;
            YearOfExploatation = yearOfExploatation;
            Speed = speed;
            IsWorking = IsWorking;

        }     
        public string Model { get; set; }      
        public string Mark { get; set; }      
        public string TransportType { get; set; }     
        public double Price { get; set; }       
        public int Speed { get; set; }       
        public int YearOfExploatation { get; set; }      
        public bool IsWorking { get; set; }
    }
}
