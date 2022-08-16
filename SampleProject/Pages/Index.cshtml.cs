using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SampleProject.Data;
using SampleProject.Models;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Pages
{
    public class IndexModel : PageModel
    {

        private readonly TrainsetLogContext db;
        public IndexModel(TrainsetLogContext db) => this.db = db;
        public List<TrainsetLog> TrainsetLogs { get; set; } = new List<TrainsetLog>();
        public TrainsetLog FeaturedProduct { get; set; }
        public async Task OnGetAsync()
        {
            TrainsetLogs = await db.TrainsetLogs.ToListAsync();
            FeaturedProduct = TrainsetLogs.ElementAt(new Random().Next(TrainsetLogs.Count));
        }

        /*
         * public string RequestMethod
         { get; set; }
         public string RequestValues
         { get; set; }
         */

        /* public int Trainset { get; set; }
         public int Trainset2 { get; set; }
         public int Trainset3 { get; set; }
         public string DisplayTrainset { get; set; }
         public string RollingStock { get; set; }
         public string Line { get; set; }
         public string Line2 { get; set; }
         public DateTime Date { get; set; }
         public int RunNo { get; set; }
         public string DisplayRunNo { get; set; }
         public string Remarks { get; set; }


         public void OnGet()
         {


              RequestMethod = "GET";
              RequestValues = "n/a";


             Trainset = 679;
             Line = "NSL";
             Date = new DateTime(2000, 3, 24);
         }

         public void OnPost(int trainset, string line, string line2, DateTime date, int runno, string remarks)
         {
             // For debugging
             // RequestMethod = "POST";
             // RequestValues = GetFormValues();

             // Assign property values here
             Trainset = trainset;
             Line = line;
             Line2 = line2;
             Date = date;
             RunNo = runno;
             Remarks = remarks;

             Trainset2 = Trainset + 1;
             Trainset3 = Trainset - 1;



             //lines

             if (Trainset >= 0 && Trainset <= 724)
             {
                 Line = "NSL";
                 Line2 = "EWL";
             }

             else if (Trainset >= 2001 && Trainset <= 2091)
             {
                 Line = "TEL";

             }

             //rolling stock

             if (Trainset >= 000 && Trainset <= 132)
             {
                 RollingStock = "C151";

             }

             else if (Trainset >= 201 && Trainset <= 238)
             {
                 RollingStock = "C651";

             }

             else if (Trainset >= 311 && Trainset <= 352)
             {
                 RollingStock = "C751B";

             }

             else if (Trainset >= 501 && Trainset <= 570)
             {
                 RollingStock = "C151A";

             }

             else if (Trainset >= 601 && Trainset <= 690)
             {
                 RollingStock = "C151B";

             }

             else if (Trainset >= 701 && Trainset <= 724)
             {
                 RollingStock = "C151C";

             }

             else if (Trainset >= 2001 && Trainset <= 2091)
             {
                 RollingStock = "T251";

             }

             //trainset

             if (Line == "NSL" || Line == "EWL")
             {

                 if (Trainset % 2 == 1)
                 {
                     DisplayTrainset = $"{Trainset.ToString()} / {Trainset2.ToString()}";

                 }

                 else if (Trainset % 2 == 0)
                 {
                     DisplayTrainset = $"{Trainset3.ToString()} / {Trainset.ToString()}";
                 }

             }


             else
             {
                 DisplayTrainset = $"{Trainset}";
             };

             //trainset add 0 in front

             if (Trainset < 100 && Trainset % 2 == 1)
             {
                 DisplayTrainset = $"0{Trainset.ToString()} / 0{Trainset2.ToString()}";

             }

             else if (Trainset < 100 && Trainset % 2 == 0)
             {
                 DisplayTrainset = $"0{Trainset3.ToString()} / 0{Trainset.ToString()}";
             }



             //run number

             if (RunNo == 0)
             {
                 DisplayRunNo = "";
             }

             else
             {
                 DisplayRunNo = $"T{RunNo}";
             }


             // For debugging
             /* string GetFormValues(bool ignoreRequestVerificationToken = true)
             {
                 string formData = "";
                 string separator = " | ";
                 foreach (var pair in this.Request.Form)
                 {
                     if (ignoreRequestVerificationToken && pair.Key == "__RequestVerificationToken")
                     {
                         continue;
                     }
                     else
                     {
                         formData += pair.Key + ": " + Request.Form[pair.Key] + separator;
                     }
                 }
                 if (formData.EndsWith(separator))
                 {
                     formData = formData.Substring(0, formData.Length - separator.Length);
                 }
                 return formData;
             }
             */
    }

    }
