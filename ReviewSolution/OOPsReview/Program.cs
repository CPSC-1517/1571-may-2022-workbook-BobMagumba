// See https://aka.ms/new-console-template for more information
using OOPsReview.Data;

Employment bobEmployment = new Employment("Programmer", SupervisoryLevel.Entry, 3);
Console.WriteLine(bobEmployment.ToString());

bobEmployment.SetEmploymentResponsibilityLevel(SupervisoryLevel.Owner);
Console.WriteLine(bobEmployment.ToString());

Employment job;

CreateJob(ref job);
Console.WriteLine(job.ToString());