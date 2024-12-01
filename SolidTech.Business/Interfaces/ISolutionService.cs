namespace SolidTech.Business.Interfaces
{
    public interface ISolutionService
    {
        List<SolutionDto> GetServices();

        Solution GetSolutionById(int id);
        void AddSolution(SolutionDto solutionDto);

    }
}
