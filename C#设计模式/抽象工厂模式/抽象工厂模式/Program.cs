﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式 {
    class Program {
        static void Main(string[] args) {
            Factory.FacilitiesFactory facilitiesFactory=new Factory.FacilitiesFactory();
            GameManager gameManager = new GameManager(facilitiesFactory);
            gameManager.BulidGameFacilties();
        }
    }
}
