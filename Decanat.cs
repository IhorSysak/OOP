<<<<<<< HEAD
﻿using Nancy.Json;
using Newtonsoft.Json.Linq;
=======
﻿using Newtonsoft.Json.Linq;
using OOP_Turniket;
>>>>>>> Work Project
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using VDS.RDF.Parsing;
=======
using System.IO;
>>>>>>> Work Project

namespace Turniket_OOP
{
    class Decanat
    {
        private static Decanat decanat = null;

        private Decanat() { }
        public static Decanat GetDecanat()
        {
            if (decanat == null)
            {
                decanat = new Decanat();
            }
            return decanat;
        }

<<<<<<< HEAD
        List<Student> Arr_late = new List<Student>();
        List<Student> Arr_missing = new List<Student>();
        List<Student> Arr_present = new List<Student>();

        internal List<Student> Arr_late1 { get => Arr_late; set => Arr_late = value; }
        internal List<Student> Arr_missing1 { get => Arr_missing; set => Arr_missing = value; }
        internal List<Student> Arr_present1 { get => Arr_present; set => Arr_present = value; }

        private bool IsStudentLate(Student traspasser)
=======
        public void IsStudentLate(Student traspasser)
>>>>>>> Work Project
        {
            string GroupToRequest = traspasser.Group; // get this param from traspasser
            string URL = "http://api.rozklad.org.ua/v2/groups/" + GroupToRequest + "/timetable";

            var client = new RestClient(URL);
            var request = new RestRequest(Method.GET);
<<<<<<< HEAD
            
=======

>>>>>>> Work Project
            //request.AddHeader("cache-control", "no-cache");
            //request.AddHeader("Connection", "keep-alive");
            //request.AddHeader("Referer", URL);
            //request.AddHeader("Accept-Encoding", "gzip, deflate");
            //request.AddHeader("Postman-Token", "201e677b-45ae-4ad4-a6e8-9e713deadfa1,c2e87c75-f02f-426a-9296-1c4edf0305f8");
            //request.AddHeader("Cache-Control", "no-cache");
            //request.AddHeader("Accept", "*/*");
            //request.AddHeader("User-Agent", "PostmanRuntime/7.17.1");
<<<<<<< HEAD
            

            IRestResponse response = client.Execute(request);

            if(!response.IsSuccessful) // passed wrong group -- request is failed 404
=======


            IRestResponse response = client.Execute(request);

            if (!response.IsSuccessful) // passed wrong group -- request is failed 404
>>>>>>> Work Project
            {
                const string message = "You passed wrong group name. Cancel this operation?";
                const string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
<<<<<<< HEAD
                return true;
            }

            JObject JSONObj = JObject.Parse(response.Content);
                       
=======
            }

            JObject JSONObj = JObject.Parse(response.Content);

>>>>>>> Work Project
            var CurrentDay = DateTime.Now.Date.DayOfWeek;

            int DayOfTheWeek = 0;
            switch (CurrentDay)
            {
                case DayOfWeek.Sunday:
                    {
                        DayOfTheWeek = 7;
                        break;
                    }
                case DayOfWeek.Monday:
                    {
                        DayOfTheWeek = 1;

                        break;
                    }
                case DayOfWeek.Tuesday:
                    {
                        DayOfTheWeek = 2;

                        break;
                    }
                case DayOfWeek.Wednesday:
                    {
                        DayOfTheWeek = 3;

                        break;
                    }
                case DayOfWeek.Thursday:
                    {
                        DayOfTheWeek = 4;

                        break;
                    }
                case DayOfWeek.Friday:
                    {
                        DayOfTheWeek = 5;

                        break;
                    }
                case DayOfWeek.Saturday:
                    {
                        DayOfTheWeek = 6;

                        break;
                    }
            }


            // IMPLEMENT DETECTING WEEK OF THE SCHEDULE TO PASS HERE ↓

            JToken TimeStart = JSONObj["data"]["weeks"]["1"/*week of schedule*/]["days"][DayOfTheWeek.ToString()]["lessons"][0]["time_start"];
<<<<<<< HEAD
=======
            JToken LessonNumber = JSONObj["data"]["weeks"]["1"/*week of schedule*/]["days"][DayOfTheWeek.ToString()]["lessons"];
            int length = LessonNumber.Count();
>>>>>>> Work Project

            TimeSpan TimeLessonStart = DateTime.Parse(TimeStart.ToString()).TimeOfDay;

            TimeSpan TimeNow = DateTime.Now.Date.TimeOfDay;

<<<<<<< HEAD
            int value = TimeSpan.Compare(TimeLessonStart, TimeNow);

            if (value > 0)
            {
                return false;
            }
            return true;
        }

        public void Inform(Student student)
        {
            if (IsStudentLate(student) == true) //pars
            {
                Arr_late.Add(student);
            }
            else
            {
                Arr_present.Add(student);
            }
            decanat.Arr_missing.Add(student); // ???
        }

    }
}
=======
            //
            DateTime now = DateTime.Now;
            DateTime dateLesson1 = new DateTime(2019, 11, 21, 8, 30, 00);
            DateTime dateLesson2 = new DateTime(2019, 11, 21, 10, 25, 00);
            DateTime dateLesson3 = new DateTime(2019, 11, 21, 12, 20, 00);
            DateTime dateLesson4 = new DateTime(2019, 11, 21, 14, 15, 00);
            DateTime dateLesson5 = new DateTime(2019, 11, 21, 16, 10, 00);

            now.ToLongTimeString();
            dateLesson1.ToLongTimeString();
            dateLesson2.ToLongTimeString();
            dateLesson3.ToLongTimeString();
            dateLesson4.ToLongTimeString();
            dateLesson5.ToLongTimeString();

            int walk = 0;
            if (now > dateLesson2 && now < dateLesson3)
            {
                walk = 1;
            }
            else if (now > dateLesson3 && now < dateLesson4)
            {
                walk = 2;
            }
            else if (now > dateLesson4 && now < dateLesson5)
            {
                walk = 3;
            }
            else if (now > dateLesson5) 
            {
                walk = 4;
            }

            //int CountNow = int.Parse(LessonNumber[0].ToString());
            //int CountResult = length - CountNow;
            //

            int value = TimeSpan.Compare(TimeLessonStart, TimeNow);
            bool IsLate = value < 0 ? true : false;
            Walkers.GetWalkers().Inform(traspasser, IsLate, walk);
        }
    }
}
>>>>>>> Work Project
