using Nancy.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VDS.RDF.Parsing;

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

        List<Student> Arr_late = new List<Student>();
        List<Student> Arr_missing = new List<Student>();
        List<Student> Arr_present = new List<Student>();

        internal List<Student> Arr_late1 { get => Arr_late; set => Arr_late = value; }
        internal List<Student> Arr_missing1 { get => Arr_missing; set => Arr_missing = value; }
        internal List<Student> Arr_present1 { get => Arr_present; set => Arr_present = value; }

        private bool IsStudentLate(Student traspasser)
        {
            string GroupToRequest = traspasser.Group; // get this param from traspasser
            string URL = "http://api.rozklad.org.ua/v2/groups/" + GroupToRequest + "/timetable";

            var client = new RestClient(URL);
            var request = new RestRequest(Method.GET);
            
            //request.AddHeader("cache-control", "no-cache");
            //request.AddHeader("Connection", "keep-alive");
            //request.AddHeader("Referer", URL);
            //request.AddHeader("Accept-Encoding", "gzip, deflate");
            //request.AddHeader("Postman-Token", "201e677b-45ae-4ad4-a6e8-9e713deadfa1,c2e87c75-f02f-426a-9296-1c4edf0305f8");
            //request.AddHeader("Cache-Control", "no-cache");
            //request.AddHeader("Accept", "*/*");
            //request.AddHeader("User-Agent", "PostmanRuntime/7.17.1");
            

            IRestResponse response = client.Execute(request);

            if(!response.IsSuccessful) // passed wrong group -- request is failed 404
            {
                const string message = "You passed wrong group name. Cancel this operation?";
                const string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                return true;
            }

            JObject JSONObj = JObject.Parse(response.Content);
                       
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

            TimeSpan TimeLessonStart = DateTime.Parse(TimeStart.ToString()).TimeOfDay;

            TimeSpan TimeNow = DateTime.Now.Date.TimeOfDay;

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
