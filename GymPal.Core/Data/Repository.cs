﻿using GymPal.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymPal.Core.Data
{
    public class Repository
    {
        private static List<Machine> machines = new List<Machine>()
        {

                        new Machine()
                        {
                             machineid = 1,
                              Name = "ab-isolator",
                              PictureUrl="IMG_1039",
                               BeginDesc = "start nn",
                               shortDesc = "blshb blsh"

                        },
                        new Machine()
                        {
                             machineid = 2,
                              Name = "arm-cross",
                              PictureUrl="john",
                               BeginDesc = "start nn",
                               shortDesc = "blshb blsh"

                        },
                        new Machine()
                        {
                             machineid = 3,
                              Name = "chest-press",
                              PictureUrl="john",
                               BeginDesc = "start nn",
                               shortDesc = "blshb blsh"

                        }

        };
        private static List<Routine> Routines = new List<Routine>()
        {
            new Routine()
            {
                 Name = "group1",
                 id = 1,
                 userid = 2,
                 Machines = new  List<Machine>(){machines[0] }

            }
        };
        private static List<User> Users = new List<User>()
        {
            new User(){ id = 1, Email="jmcfet@bellsouth.net", Password="test" },
            new User(){ id = 2, Email="foo@bellsouth.net", Password="test" }
        };
        public List<Routine> GetRoutines()
        {
            return Routines;
        }
        public List<Machine> GetAllMachines()
        {
            //IEnumerable<Machine> machines =
            //    from Routine in Routines
            //    from machine in Routine.Machines

            //    select machine;
            return machines.ToList<Machine>();
        }
        public User isUserValid(string userid, string password)
        {
            return Users.Where(u => u.Email == userid && u.Password == password).SingleOrDefault();
        }
    }
}
