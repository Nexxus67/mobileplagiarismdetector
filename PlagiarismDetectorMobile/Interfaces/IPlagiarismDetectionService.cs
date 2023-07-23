using System;
namespace PlagiarismDetectorMobile.Interfaces
{
    public interface IPlagiarismDetectionService
    {
        double CalculatePlagiarismScore(string code1, string code2, int n);  
    }
}

