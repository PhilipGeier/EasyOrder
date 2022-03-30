using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using OrderingSystem.Domain;
using OrderingSystem.Logic;
using OrderingSystem.Logic.Json;

namespace OrderingSystem.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var tableLogic = new TableLogic();
            
            tableLogic.CreateTable("1", WpfInfo.Create(150, 150, 50,50,"Ellipse"));
            tableLogic.CreateTable("2", WpfInfo.Create(250, 400, 50,50,"Ellipse"));
            tableLogic.CreateTable("3", WpfInfo.Create(400, 200, 50,50,"Ellipse"));
            tableLogic.CreateTable("5", WpfInfo.Create(400, 400, 50,50,"Ellipse"));
            
        }
    }
}